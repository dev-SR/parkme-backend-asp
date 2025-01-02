
using Domain.Contracts;
using Domain.Entities.Models;
using Infrastructure.Data.Extensions;
using Microsoft.EntityFrameworkCore;
using Shared.DTO.Parking;

namespace Infrastructure.Data.Repositories;

public class ParkingLotRepository : RepositoryBase<ParkingLot>, IParkingLotRepository
{
    public ParkingLotRepository(RepositoryDbContext dbContext) : base(dbContext)
    {
    }
    public async Task<IEnumerable<ParkingLot>> GetParkingLotsWithinBoundingBox(ParkingLotSearchFormDto searchFormData)
    {
        // Bounding Box Visualization:
        //
        // (NeLat, SwLng) ---------------------- (NeLat, NeLng)
        //              |                      |
        //              |                      |
        //              |                      |
        // (SwLat, SwLng) ---------------------- (SwLat, NeLng)

        return await FindByCondition((p) =>
            p.Latitude >= searchFormData.Bounds.SwLat &&
            p.Latitude <= searchFormData.Bounds.NeLat &&
            p.Longitude >= searchFormData.Bounds.SwLng &&
            p.Longitude <= searchFormData.Bounds.NeLng, trackChanges: false)
                    .MatchesVehicle(searchFormData.VehicleTypes)
                    .MatchesPrizeRange(searchFormData.PricePerHourRange)
                    .Include(p => p.ParkingSpaces)
                    .ToListAsync();
    }

}
