namespace Shared.DTO.Parking;

public record ParkingLotDto(
    Guid Id,
    string Name,
    string Description,
    string Address,
    double Latitude,
    double Longitude,
    List<ParkingSpaceDto> ParkingSpaces
);

public record ParkingSpaceDto(
    Guid Id,
    string SectionName,
    string VehicleType,
    int PricePerHour,
    int Capacity
);
