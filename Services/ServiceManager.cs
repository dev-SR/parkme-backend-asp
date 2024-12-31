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

    public ServiceManager(IRepositoryManager repositoryManager, ILoggerManager logger, IMapper mapper, UserManager<User> userManager, IConfiguration configuration)
    {

        _tokenService = new Lazy<ITokenService>(() => new TokenService(repositoryManager, userManager, logger));
        _authenticationService = new Lazy<IAuthenticationService>(() =>
                        new AuthenticationService(repositoryManager, logger, mapper, userManager, _tokenService.Value));
    }

    public IAuthenticationService AuthenticationService => _authenticationService.Value;

    public ITokenService TokenService => _tokenService.Value;
}