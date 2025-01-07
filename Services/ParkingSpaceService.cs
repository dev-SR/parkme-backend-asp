using System;
using AutoMapper;
using Domain.Contracts;
using Domain.Entities.Models;
using Services.Contracts;
using Shared.DTO.Parking;

namespace Services;

public class ParkingSpaceService : IParkingSpaceService
{
    private IRepositoryManager repositoryManager;
    private ILoggerManager logger;
    private IMapper mapper;

    public ParkingSpaceService(IRepositoryManager repositoryManager, ILoggerManager logger, IMapper mapper)
    {
        this.repositoryManager = repositoryManager;
        this.logger = logger;
        this.mapper = mapper;
    }

    public async Task<ParkingSpace?> GetParkingSpaceById(Guid id)
    {
        return await repositoryManager.ParkingSpace.GetParkingSpaceById(id);
    }

    public async Task<IEnumerable<ParkingSpaceDto>> GetParkingSpacesForParkingLot(
                                                                    Guid parkingLotId,
                                                                    ParkingSpacesFilterReqBodyDto filter)
    {
        return await repositoryManager.ParkingSpace.GetParkingSpacesForParkingLot(parkingLotId, filter);
    }
}
