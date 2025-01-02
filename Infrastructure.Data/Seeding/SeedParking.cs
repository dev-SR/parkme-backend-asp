using Bogus;
using Domain.Entities.Models;
using Shared.DTO.Parking;

namespace Infrastructure.Data.Seeding;

public record BoundingBox(double swLng, double swLat, double neLng, double neLat);
// Bounding Box Visualization:
//
// (NeLat, SwLng) ---------------------- (NeLat, NeLng)
//              |                      |
//              |                      |
//              |                      |
// (SwLat, SwLng) ---------------------- (SwLat, NeLng)
//
public class SeedParking
{
    public static (IEnumerable<ParkingLot>, IEnumerable<ParkingSpace>) GenerateSeedData(int count, int spacesPerParking, BoundingBox boundingBox)
    {

        var parkingLotFaker = new Faker<ParkingLot>()
            .RuleFor(p => p.Id, f => Guid.NewGuid())
            .RuleFor(p => p.Name, f => f.Company.CompanyName())
            .RuleFor(p => p.Description, f => f.Lorem.Sentence())
            .RuleFor(p => p.Address, f => f.Address.FullAddress())
            .RuleFor(p => p.Longitude, f => f.Random.Double(boundingBox.swLng, boundingBox.neLng))
            .RuleFor(p => p.Latitude, f => f.Random.Double(boundingBox.swLat, boundingBox.neLat));

        var parkingLots = parkingLotFaker.Generate(count);

        var parkingSpaceFaker = new Faker<ParkingSpace>()
            .RuleFor(s => s.Id, f => Guid.NewGuid())
            .RuleFor(s => s.SectionName, f => $"{f.PickRandom(new[] { "A", "B", "C", "D" })}-{f.Random.Int(1, 20)}")
            .RuleFor(s => s.VehicleType, f => f.PickRandom<VehicleType>())
            .RuleFor(s => s.Capacity, f => f.Random.Int(10, 50))
            .RuleFor(s => s.PricePerHour, f => f.PickRandom(new[] { 100, 150, 200, 300, 500 }))
            .RuleFor(s => s.ParkingLotId, f => f.PickRandom(parkingLots).Id);

        var parkingSpaces = parkingSpaceFaker.Generate(count * spacesPerParking); // Customizable spaces per parking lot

        return (parkingLots, parkingSpaces);
    }
}
