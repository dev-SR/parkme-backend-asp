namespace Shared.DTO.Parking;

public record ParkingLotDto(
    Guid Id,
    string Name,
    string Description,
    string Address,
    double Latitude,
    double Longitude
);
