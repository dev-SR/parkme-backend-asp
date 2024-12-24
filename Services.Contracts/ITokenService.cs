using System;
using Domain.Entities.Models;
using Shared.DTO;

namespace Services.Contracts;

public interface ITokenService
{

    Task<string> GenerateAccessToken(User user);
    Task<string> GenerateAndSaveRefreshToken(User user);
    // Task<RefreshToken?> GetRefreshTokenByToken(string token);
    // Task SaveRefreshToken(RefreshToken refreshToken);

}
