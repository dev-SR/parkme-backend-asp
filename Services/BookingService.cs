using System;
using AutoMapper;
using Domain.Contracts;
using Domain.Entities.Exceptions;
using Domain.Entities.Exceptions.BadRequests;
using Domain.Entities.Exceptions.Notfound;
using Services.Contracts;
using Shared.DTO;
using Shared.DTO.Book;
using Shared.Enums;
using Stripe;
using Stripe.Checkout;

namespace Services;

public class BookingService : IBookingService
{
    private IRepositoryManager repositoryManager;
    private ILoggerManager logger;
    private IMapper mapper;
    private readonly IServiceManager _serviceManager;
    private string STRIPE_SECRET_KEY;
    private string STRIPE_SUCCESSURL;
    private string STRIPE_CANCELURL;

    public BookingService(IRepositoryManager repositoryManager, ILoggerManager logger, IMapper mapper, IServiceManager serviceManager)
    {
        _serviceManager = serviceManager;
        this.repositoryManager = repositoryManager;
        this.logger = logger;
        this.mapper = mapper;

        string? _STRIPE_SECRET_KEY = Environment.GetEnvironmentVariable("STRIPE_SECRET_KEY");

        string? _STRIPE_SUCCESSURL = Environment.GetEnvironmentVariable("STRIPE_SUCCESSURL");
        string? _STRIPE_CANCELURL = Environment.GetEnvironmentVariable("STRIPE_CANCELURL");

        if (string.IsNullOrEmpty(_STRIPE_SECRET_KEY) || string.IsNullOrEmpty(_STRIPE_SUCCESSURL) || string.IsNullOrEmpty(_STRIPE_CANCELURL))
        {
            throw new ArgumentNullException("STRIPE_SECRET_KEY, STRIPE_SUCCESSURL, STRIPE_CANCELURL");
        }
        else
        {
            STRIPE_SECRET_KEY = _STRIPE_SECRET_KEY!;
            STRIPE_SUCCESSURL = _STRIPE_SUCCESSURL!;
            STRIPE_CANCELURL = _STRIPE_CANCELURL!;

        }





    }


    public async Task<CreateSessionResponseDto> CreateSession(Guid userId, CreateSessionRequestDto createSessionRequestDto)
    {
        if (createSessionRequestDto.endTime < createSessionRequestDto.startTime)
        {
            throw new InvalidDateRequest("EndDate must be greater than StartDate.");
        }
        Console.WriteLine($">>>> StartDate: {createSessionRequestDto.startTime}, EndDate: {createSessionRequestDto.endTime},Current Date: {DateTime.Now},current time: {DateTime.UtcNow}");
        if (createSessionRequestDto.startTime < DateTime.UtcNow || createSessionRequestDto.endTime < DateTime.UtcNow)
        {
            throw new InvalidDateRequest("StartDate and/or EndDate must be greater than current date.");
        }
        var parkingSpace = await _serviceManager.ParkingSpaceService.GetParkingSpaceById(createSessionRequestDto.parkingSpotId);
        if (parkingSpace == null)
        {
            throw new ParkingSpaceNotFoundException(createSessionRequestDto.parkingSpotId);
        }

        // Console.WriteLine(parkingSpace.ParkingLot.Address);



        StripeConfiguration.ApiKey = STRIPE_SECRET_KEY;

        var options = new SessionCreateOptions
        {
            PaymentMethodTypes = new List<string>
        {
            "card",
        },
            LineItems = new List<SessionLineItemOptions>
        {
            new SessionLineItemOptions
            {
                PriceData = new SessionLineItemPriceDataOptions
                {
                    Currency = "usd",
                    UnitAmount = 5000, // Amount in cents
                    ProductData = new SessionLineItemPriceDataProductDataOptions
                    {
                        Name = $"To book a parking at {parkingSpace.ParkingLot.Address}",
                    },
                },
                Quantity = 1,
            },
        },
            Mode = "payment",
            SuccessUrl = STRIPE_SUCCESSURL,
            CancelUrl = STRIPE_CANCELURL
        };

        var service = new SessionService();
        Session session = await service.CreateAsync(options);

        // Save booking information to the database
        repositoryManager.Booking.CreateSession(userId, parkingSpace, createSessionRequestDto, session.Id);
        await repositoryManager.SaveAsync();

        return new CreateSessionResponseDto(session.Url); // Return Stripe session URL

    }

    public async Task<BookingDto> ConfirmBooking(string sessionId)
    {
        StripeConfiguration.ApiKey = STRIPE_SECRET_KEY;

        var service = new SessionService();
        var session = await service.GetAsync(sessionId);

        if (session == null || session.PaymentStatus != "paid")
        {
            throw new PaymentBadRequest("Payment not confirmed.");
        }

        // Confirm the booking in your system
        var booking = await repositoryManager.Booking.FindBySessionId(sessionId, trackChanges: true);
        if (booking == null)
        {
            throw new BookingsNotFound("Booking not found.");
        }
        booking.Status = BookingStatus.CONFIRMED;
        await repositoryManager.SaveAsync();
        // var bookingDto = mapper.Map<BookingDto>(booking);
        // logger.LogInfo($"Booking parkingSpaceId: {bookingDto.ParkingSpace.Id}");
        // logger.LogInfo($"Booking parkingLotAddress: {bookingDto.ParkingSpace.ParkingLot?.Address}");

        return new BookingDto(
            booking.StartDate,
            booking.EndDate,
            booking.Passcode,
            booking.TotalPrice,
            booking.ParkingSpace.VehicleType.ToString(),
            booking.ParkingSpace.SectionName,
            booking.ParkingSpace.SpotNumber,
            booking.ParkingSpace.ParkingLot.Address
        );
    }
}
