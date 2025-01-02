using System;
using Domain.Entities.Models;
using Shared.DTO.Parking;

namespace Infrastructure.Data.Extensions;

public static class ParkingLotRepositoryExtensions
{
    public static IQueryable<ParkingLot> MatchesVehicle(this IQueryable<ParkingLot> parkingLots,
                                                            List<string> VehicleTypes)
    {
        if (VehicleTypes == null || VehicleTypes.Count == 0)
        {
            return parkingLots;

        }
        return parkingLots.Where(p => p.ParkingSpaces.Any(ps => VehicleTypes.Contains(ps.VehicleType.ToString())));
    }

    public static IQueryable<ParkingLot> MatchesPrizeRange(this IQueryable<ParkingLot> parkingLots,
                                                            List<double> PricePerHourRange)
    {
        if (PricePerHourRange == null || PricePerHourRange.Count != 2)
        {
            return parkingLots;
        }

        return parkingLots.Where(p => p.ParkingSpaces.Any(ps => ps.PricePerHour >= PricePerHourRange[0] && ps.PricePerHour <= PricePerHourRange[1]));
    }
}
