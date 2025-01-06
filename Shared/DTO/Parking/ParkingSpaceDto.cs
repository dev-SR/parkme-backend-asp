namespace Shared.DTO.Parking;

public record ParkingSpaceDto(
    Guid Id,
    string SectionName,
    int SpotNumber,
    string VehicleType,
    double PricePerHour,
    bool isBooked
);