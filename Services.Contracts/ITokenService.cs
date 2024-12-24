using System;
using Domain.Entities.Models;
using Shared.DTO;
using Shared.DTO.Auth;

namespace Services.Contracts;

public interface ITokenService
{

    Task<string> GenerateAccessToken(User user);
    Task<string> GenerateAndSaveRefreshToken(User user);
    Task<TokenPairDto> ReGenerateAccessToken(RefreshTokenRequestDto requestTokenDto);
}
