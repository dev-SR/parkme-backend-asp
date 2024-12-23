using System;
using Microsoft.AspNetCore.Identity;
using Shared.DTO;

namespace Services.Contracts;

public interface IAuthenticationService
{
    Task<IdentityResult> RegisterUser(UserForRegistrationDto userForRegistration);
}
