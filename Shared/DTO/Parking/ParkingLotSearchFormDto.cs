
namespace Shared.DTO.Parking;
public enum VehicleType
{
    CAR,
    MOTORCYCLE,
    TRUCK
}

public record ParkingLotSearchFormDto(
    BoundsDto Bounds,
    List<string> VehicleTypes,
    List<double> PricePerHourRange
);
public record BoundsDto(
    double NeLat,
    double NeLng,
    double SwLat,
    double SwLng
);
