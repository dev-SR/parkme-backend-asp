using Bogus;
using Domain.Entities.Models;
using Shared.Enums;

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
    public static (IEnumerable<ParkingLot>, IEnumerable<ParkingSpace>) GenerateSeedData(int count, int parkingSpotsCount, BoundingBox boundingBox)
    {

        var parkingLotFaker = new Faker<ParkingLot>()
            .RuleFor(p => p.Id, f => Guid.NewGuid())
            .RuleFor(p => p.Name, f => f.Company.CompanyName())
            .RuleFor(p => p.Description, f => f.Lorem.Sentence())
            .RuleFor(p => p.Address, f => f.Address.FullAddress())
            .RuleFor(p => p.Longitude, f => f.Random.Double(boundingBox.swLng, boundingBox.neLng))
            .RuleFor(p => p.Latitude, f => f.Random.Double(boundingBox.swLat, boundingBox.neLat));

        List<ParkingLot> parkingLots = parkingLotFaker.Generate(count);

        string[] parkingSections = ["A", "B"];
        int[] parkingSpotsNo = Enumerable.Range(1, parkingSpotsCount).ToArray();
        List<ParkingSpace> parkingSpaces = []; // Initialize the list outside the loop>

        foreach (var lot in parkingLots)
        {
            foreach (var SectionName in parkingSections)
            {
                var randomVehicleType = new Faker().PickRandom<VehicleType>();
                int PricePerHour = 100;
                switch (randomVehicleType)
                {
                    case VehicleType.MOTORCYCLE:
                        PricePerHour = 50;
                        break;
                    case VehicleType.CAR:
                        PricePerHour = 100;
                        break;
                    case VehicleType.VAN:
                        PricePerHour = 200;
                        break;
                    case VehicleType.TRUCK:
                        PricePerHour = 300;
                        break;
                }


                foreach (var SpotNumber in parkingSpotsNo)
                {
                    var parkingSpaceGenerator = new Faker<ParkingSpace>()
                        .RuleFor(s => s.Id, f => Guid.NewGuid())
                        .RuleFor(s => s.SectionName, f => SectionName)
                        .RuleFor(s => s.SpotNumber, f => SpotNumber)
                        .RuleFor(s => s.VehicleType, f => randomVehicleType)
                        .RuleFor(s => s.PricePerHour, f => PricePerHour)
                        .RuleFor(s => s.ParkingLotId, f => lot.Id);
                    parkingSpaces.Add(parkingSpaceGenerator.Generate());
                }

            }
        }
        return (parkingLots, parkingSpaces);
    }
}
/* 
{
  "bounds": {
    "swLng": 89.095284,
    "swLat": 23.882667,
    "neLng": 89.160215,
    "neLat": 23.910604
  },
  "vehicleTypes": [
    "CAR"
  ],
  "pricePerHourRange": [
    100,500
  ]
}
*/