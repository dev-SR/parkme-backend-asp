using System;
using Shared.DTO.Parking;

namespace Services.Contracts;

public interface IParkingLotService
{
    Task<IEnumerable<ParkingLotDto>> GetParkingLotsWithinBoundingBox(ParkingLotFilterFormDto filterFormData);
}
