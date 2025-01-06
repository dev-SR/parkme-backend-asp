using System;
using Domain.Entities.Models;

namespace Domain.Contracts;

public interface IRefreshTokenRepository
{

    Task<RefreshToken?> GetRefreshTokenByToken(string refreshToken);
    Task<RefreshToken?> GetRefreshTokenByUser(MyUser user);

    void SaveRefreshToken(RefreshToken refreshToken);
    void DeleteRefreshToken(RefreshToken refreshToken);
}
