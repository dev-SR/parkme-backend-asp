
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
    public async Task<IEnumerable<ParkingLot>> GetParkingLotsWithinBoundingBox(ParkingLotFilterFormDto filterFormData)
    {
        // Bounding Box Visualization:
        //
        // (NeLat, SwLng) ---------------------- (NeLat, NeLng)
        //              |                      |
        //              |                      |
        //              |                      |
        // (SwLat, SwLng) ---------------------- (SwLat, NeLng)

        return await FindByCondition((p) =>
            p.Latitude >= filterFormData.Bounds.SwLat &&
            p.Latitude <= filterFormData.Bounds.NeLat &&
            p.Longitude >= filterFormData.Bounds.SwLng &&
            p.Longitude <= filterFormData.Bounds.NeLng, trackChanges: false)
                    .MatchesVehicle(filterFormData.VehicleTypes)
                    .MatchesPrizeRange(filterFormData.PricePerHourRange)
                    .Include(p => p.ParkingSpaces)
                    .ToListAsync();
    }

}