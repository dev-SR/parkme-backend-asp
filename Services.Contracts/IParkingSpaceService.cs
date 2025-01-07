using System;
using Domain.Entities.Models;
using Shared.DTO.Parking;

namespace Services.Contracts;

public interface IParkingSpaceService
{
    Task<ParkingSpace?> GetParkingSpaceById(Guid id);

    Task<IEnumerable<ParkingSpaceDto>> GetParkingSpacesForParkingLot(Guid parkingLotId,
                                                                    ParkingSpacesFilterReqBodyDto filter);
}
