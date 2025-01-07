using Bogus;
using Domain.Contracts;
using Domain.Entities.Exceptions;
using Domain.Entities.Exceptions.BadRequests;
using Domain.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Shared.DTO.Book;
using Shared.Enums;

namespace Infrastructure.Data.Repositories;

public class BookingRepository : RepositoryBase<Booking>, IBookingRepository
{
    private readonly RepositoryManager _repositoryManager;
    public BookingRepository(RepositoryDbContext dbContext, RepositoryManager repositoryManager) : base(dbContext)
    {
        _repositoryManager = repositoryManager;
    }

    public void CreateSession(Guid userId, ParkingSpace parkingSpace, CreateSessionRequestDto createSessionRequestDto, string? stripeSessionId)
    {

        var PricePerHour = parkingSpace.PricePerHour;
        var Duration = createSessionRequestDto.endTime - createSessionRequestDto.startTime;
        var TotalPrice = PricePerHour * Duration.TotalHours;

        string generatePassCode = new Faker().Random.AlphaNumeric(6);

        var booking = new Booking
        {
            StartDate = createSessionRequestDto.startTime,
            EndDate = createSessionRequestDto.endTime,
            TotalPrice = TotalPrice,
            PricePerHour = PricePerHour,
            ParkingSpaceId = createSessionRequestDto.parkingSpotId,
            UserId = userId,
            Passcode = generatePassCode,
            Status = BookingStatus.PENDING,
            PhoneNumber = createSessionRequestDto.phoneNumber,
            VehicleNumber = createSessionRequestDto.vehicleNumber,
            StripePaymentSessionId = stripeSessionId

        };

        Create(booking);

    }

    public async Task<Booking?> FindBySessionId(string sessionId, bool trackChanges)
    {
        return await FindByCondition(b => b.StripePaymentSessionId == sessionId, trackChanges)
                    .Include(b => b.User)
                    .Include(b => b.ParkingSpace)
                    .Include(b => b.ParkingSpace.ParkingLot).FirstOrDefaultAsync();
    }
}
