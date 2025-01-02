using Domain.Entities.Models;
using Shared.DTO.Parking;

namespace Domain.Contracts;

public interface IParkingLotRepository
{
    Task<IEnumerable<ParkingLot>> GetParkingLotsWithinBoundingBox(ParkingLotSearchFormDto searchFormData);

}
