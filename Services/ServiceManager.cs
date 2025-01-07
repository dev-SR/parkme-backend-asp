using System;
using AutoMapper;
using Domain.Contracts;
using Domain.Entities.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Services.Contracts;

namespace Services;

public sealed class ServiceManager : IServiceManager
{
    private readonly Lazy<IAuthenticationService> _authenticationService;
    private readonly Lazy<ITokenService> _tokenService;
    private readonly Lazy<IParkingLotService> _parkingLotService;

    private readonly Lazy<IParkingSpaceService> _parkingSpaceService;

    private readonly Lazy<IBookingService> _bookingService;

    public ServiceManager(IRepositoryManager repositoryManager, ILoggerManager logger, IMapper mapper, UserManager<MyUser> userManager, IConfiguration configuration)
    {

        _tokenService = new Lazy<ITokenService>(() => new TokenService(repositoryManager, userManager, logger));
        _authenticationService = new Lazy<IAuthenticationService>(() =>
                        new AuthenticationService(repositoryManager, logger, mapper, userManager, _tokenService.Value));
        _parkingLotService = new Lazy<IParkingLotService>(() => new ParkingLotService(repositoryManager, logger, mapper));

        _parkingSpaceService = new Lazy<IParkingSpaceService>(() => new ParkingSpaceService(repositoryManager, logger, mapper));

        _bookingService = new Lazy<IBookingService>(() => new BookingService(repositoryManager, logger, mapper, this));
    }

    public IAuthenticationService AuthenticationService => _authenticationService.Value;
    public IParkingLotService ParkingLotService => _parkingLotService.Value;

    public ITokenService TokenService => _tokenService.Value;

    public IParkingSpaceService ParkingSpaceService => _parkingSpaceService.Value;

    public IBookingService BookingService => _bookingService.Value;
}