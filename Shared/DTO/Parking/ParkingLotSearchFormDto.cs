
namespace Shared.DTO.Parking;

public record ParkingLotFilterFormDto(
    BoundsDto Bounds,
    // DateTime? StartDate,
    // DateTime? EndDate,
    List<string> VehicleTypes,
    List<double> PricePerHourRange
);
public record BoundsDto(
    double NeLat,
    double NeLng,
    double SwLat,
    double SwLng
);
