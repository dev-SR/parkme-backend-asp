using Bogus;
using Domain.Entities.Models;

namespace Infrastructure.Data.Seeding;

public class SeedParking
{
    public static (IEnumerable<ParkingLot>, IEnumerable<ParkingSpace>) GenerateSeedData(int count, int spacesPerParking, double[] boundingBox)
    {
        double sw_lng = boundingBox[0];
        double sw_lat = boundingBox[1];
        double ne_lng = boundingBox[2];
        double ne_lat = boundingBox[3];

        var parkingLotFaker = new Faker<ParkingLot>()
            .RuleFor(p => p.Id, f => Guid.NewGuid())
            .RuleFor(p => p.Name, f => f.Company.CompanyName())
            .RuleFor(p => p.Description, f => f.Lorem.Sentence())
            .RuleFor(p => p.Address, f => f.Address.FullAddress())
            .RuleFor(p => p.longitude, f => f.Random.Double(sw_lng, ne_lng))
            .RuleFor(p => p.latitude, f => f.Random.Double(sw_lat, ne_lat));

        var parkingLots = parkingLotFaker.Generate(count);

        var parkingSpaceFaker = new Faker<ParkingSpace>()
            .RuleFor(s => s.Id, f => Guid.NewGuid())
            .RuleFor(s => s.SectionName, f => $"{f.PickRandom(new[] { "A", "B", "C", "D" })}-{f.Random.Int(1, 20)}")
            .RuleFor(s => s.VehicleType, f => f.PickRandom<VehicleType>())
            .RuleFor(s => s.Capacity, f => f.Random.Int(10, 50))
            .RuleFor(s => s.PricePerHour, f => f.Random.Double(5, 20))
            .RuleFor(s => s.ParkingLotId, f => f.PickRandom(parkingLots).Id);

        var parkingSpaces = parkingSpaceFaker.Generate(count * spacesPerParking); // Customizable spaces per parking lot

        return (parkingLots, parkingSpaces);
    }
}
