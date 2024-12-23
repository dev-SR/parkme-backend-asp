using System;
using AutoMapper;
using Domain.Entities.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Services.Contracts;

namespace Services;

public sealed class ServiceManager : IServiceManager
{
    private readonly Lazy<IAuthenticationService> _authenticationService;


    public ServiceManager(ILoggerManager logger, IMapper mapper, UserManager<User> userManager, IConfiguration configuration
    // IRepositoryManager repositoryManager,
    )
    {

        _authenticationService = new Lazy<IAuthenticationService>(() => new AuthenticationService(logger, mapper, userManager, configuration));
    }

    public IAuthenticationService AuthenticationService => _authenticationService.Value;
}