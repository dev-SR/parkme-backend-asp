using System;
using Microsoft.AspNetCore.Identity;
using Shared;
using Shared.DTO.Auth;

namespace Services.Contracts;

public interface IAuthenticationService
{
    Task<IdentityResult> Register(RegistrationRequestDto registerRequestBody);
    Task<LoginResponseDto> Login(LoginRequestDto loginRequestBody);

}
