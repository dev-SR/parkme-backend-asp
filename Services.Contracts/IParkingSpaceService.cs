using System;
using Shared.DTO.Parking;

namespace Services.Contracts;

public interface IParkingSpaceService
{
    Task<IEnumerable<ParkingSpaceDto>> GetParkingSpacesForParkingLot(Guid parkingLotId,
                                                                    ParkingSpacesFilterReqBodyDto filter);
}
