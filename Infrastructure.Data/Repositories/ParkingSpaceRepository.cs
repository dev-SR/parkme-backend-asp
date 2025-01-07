using Domain.Contracts;
using Domain.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Shared.DTO.Parking;
using Shared.Enums;

namespace Infrastructure.Data.Repositories;

public class ParkingSpaceRepository : RepositoryBase<ParkingSpace>, IParkingSpaceRepository
{
    public ParkingSpaceRepository(RepositoryDbContext dbContext) : base(dbContext)
    {
    }

    public async Task<ParkingSpace?> GetParkingSpaceById(Guid id)
    {
        return await FindByCondition(space => space.Id == id, trackChanges: false).Include(space => space.ParkingLot).FirstOrDefaultAsync();
    }

    public async Task<IEnumerable<ParkingSpaceDto>> GetParkingSpacesForParkingLot(Guid parkingLotId,
                                                                    ParkingSpacesFilterReqBodyDto filter)
    {
        return await FindByCondition(space => space.ParkingLotId == parkingLotId, trackChanges: false)
                    .Select(space => new ParkingSpaceDto(
                        space.Id,
                        space.SectionName,
                        space.SpotNumber,
                        space.VehicleType.ToString(),
                        space.PricePerHour,
                        space.Bookings.Any(booking =>
                            booking.Status == BookingStatus.CONFIRMED &&
                            filter.StartDate < booking.EndDate &&  // Filter StartDate before Booking EndDate
                            filter.EndDate > booking.StartDate    // Filter EndDate after Booking StartDate
                        )
                    ))
                    .ToListAsync();
    }

}
