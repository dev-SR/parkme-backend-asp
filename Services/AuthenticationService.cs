using System;
using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Services.Contracts;
using Shared.DTO;

namespace Services;

internal sealed class AuthenticationService : IAuthenticationService
{

    private readonly ILoggerManager _logger;
    private readonly IMapper _mapper;
    private readonly UserManager<User> _userManager;
    private readonly IConfiguration _configuration;
    public AuthenticationService(ILoggerManager logger, IMapper mapper, UserManager<User> userManager, IConfiguration configuration)
    {
        _logger = logger;
        _mapper = mapper;
        _userManager = userManager;
        _configuration = configuration;//for accessing appsettings.json [i.e. _configuration["Jwt:Key"]]
    }


    public async Task<IdentityResult> RegisterUser(UserForRegistrationDto userForRegistration)
    {
        var user = _mapper.Map<User>(userForRegistration);

        user.UserName = userForRegistration.Email;
        var result = await _userManager.CreateAsync(user, userForRegistration.Password!);

        if (result.Succeeded)
            await _userManager.AddToRolesAsync(user, ["User"]);
        return result;
    }
}