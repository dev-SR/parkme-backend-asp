namespace Shared.DTO.Parking;

public record ParkingSpacesFilterReqBodyDto(
    DateTime StartDate,
    DateTime EndDate
);