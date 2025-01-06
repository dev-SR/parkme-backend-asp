using Domain.Entities.Models;
using Shared.DTO.Parking;
namespace Domain.Contracts;

public interface IParkingSpaceRepository
{
    Task<ParkingSpace?> GetParkingSpaceById(Guid id);

    Task<IEnumerable<ParkingSpaceDto>> GetParkingSpacesForParkingLot(Guid parkingLotId,
                                                                    ParkingSpacesFilterReqBodyDto filter);

}

