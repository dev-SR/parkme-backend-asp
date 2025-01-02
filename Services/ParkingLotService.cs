using System;
using AutoMapper;
using Domain.Contracts;
using Services.Contracts;
using Shared.DTO.Parking;

namespace Services;

public class ParkingLotService : IParkingLotService
{
    private readonly IRepositoryManager _repository;
    private readonly ILoggerManager _logger;
    private readonly IMapper _mapper;
    public ParkingLotService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
    {
        _mapper = mapper;
        _repository = repository;
        _logger = logger;
    }


    public async Task<IEnumerable<ParkingLotDto>> GetParkingLotsWithinBoundingBox(
                                            ParkingLotSearchFormDto searchFormData)
    {
        var parkingLots = await _repository.ParkingLot.GetParkingLotsWithinBoundingBox(searchFormData);
        return _mapper.Map<IEnumerable<ParkingLotDto>>(parkingLots);
    }
}
