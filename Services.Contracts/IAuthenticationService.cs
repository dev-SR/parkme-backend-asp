using System;
using Microsoft.AspNetCore.Identity;
using Shared;
using Shared.DTO;

namespace Services.Contracts;

public interface IAuthenticationService
{
    Task<IdentityResult> RegisterUser(UserForRegistrationDto userForRegistration);
    Task<bool> ValidateUser(UserForLoginDto userForLogin);
    Task<TokenDto> CreateToken(bool populateExp);
}
