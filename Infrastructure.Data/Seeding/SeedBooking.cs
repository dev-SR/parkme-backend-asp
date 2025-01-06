using Bogus;
using Domain.Entities.Models;
using Shared.Enums;

namespace Infrastructure.Data.Seeding;

public class SeedBooking
{
    public static List<Booking> GenerateSeedData(int count, Guid userId, IEnumerable<ParkingSpace> parkingSpacesDhaka)
    {
        List<Booking> bookings = new();

        for (int i = 0; i < count; i++)
        {
            // Generate random dates
            // var randomMonth = new Faker().PickRandom(1, 2);
            var randomMonth = 2;
            // var randomDay = new Faker().PickRandom(1, 10);
            var randomDay = 1;
            var randomDuration = new Faker().PickRandom(1, 5);

            var startDate = new DateTime(2025, randomMonth, randomDay);
            var endDate = startDate.AddHours(randomDuration);

            // Pick a random parking space and its price per hour
            var parkingSpace = new Faker().PickRandom(parkingSpacesDhaka);
            var pricePerHour = parkingSpace.PricePerHour;

            // Calculate the total price based on the duration
            var totalPrice = pricePerHour * randomDuration;

            // Generate a booking
            var booking = new Faker<Booking>()
                .RuleFor(b => b.Id, f => Guid.NewGuid())
                .RuleFor(b => b.StartDate, f => startDate)
                .RuleFor(b => b.EndDate, f => endDate)
                .RuleFor(b => b.PricePerHour, f => pricePerHour)
                .RuleFor(b => b.TotalPrice, f => totalPrice)
                .RuleFor(b => b.VehicleNumber, f => f.Vehicle.Vin()) // Random vehicle number
                .RuleFor(b => b.Passcode, f => f.Random.String2(6, "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"))
                .RuleFor(b => b.PhoneNumber, f => f.Phone.PhoneNumber("+8801#########")) // Random Bangladeshi phone number
                .RuleFor(b => b.Status, f => f.PickRandom<BookingStatus>())
                .RuleFor(b => b.UserId, f => userId)
                .RuleFor(b => b.ParkingSpaceId, f => parkingSpace.Id)
                .RuleFor(b => b.CreatedAt, f => DateTime.UtcNow)
                .RuleFor(b => b.UpdatedAt, f => DateTime.UtcNow)
                .Generate();

            bookings.Add(booking);
        }

        return bookings;
    }
}
