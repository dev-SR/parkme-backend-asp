namespace Domain.Entities.Models;

public class ParkingLot
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }
    public required string Address { get; set; }
    public required double longitude { get; set; }
    public required double latitude { get; set; }

    public virtual ICollection<ParkingSpace> ParkingSpaces { get; set; } = null!;
}


public class ParkingSpace
{
    public Guid Id { get; set; }

    public required string SectionName { get; set; } // A1, A2, A3, B1, B2, B3, etc.
    public required VehicleType VehicleType { get; set; }
    public required int Capacity { get; set; }
    public required double PricePerHour { get; set; }

    public Guid ParkingLotId { get; set; }
    public virtual ParkingLot ParkingLot { get; set; } = null!;
}

public enum VehicleType
{
    CAR,
    MOTORCYCLE,
    TRUCK
}
