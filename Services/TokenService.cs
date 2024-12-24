using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using AutoMapper;
using Domain.Contracts;
using Domain.Entities.ConfigurationModels;
using Domain.Entities.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Services.Contracts;

namespace Services;

public class TokenService : ITokenService
{
    private readonly UserManager<User> _userManager;
    private readonly JwtConfiguration _jwtConfiguration;

    private readonly IRepositoryManager _repository;
    public TokenService(IRepositoryManager repository, UserManager<User> userManager)
    {
        _repository = repository;
        _userManager = userManager;
        _jwtConfiguration = new JwtConfiguration();

    }

    public async Task<string> GenerateAccessToken(User user)
    {
        var signingCredentials = GetSigningCredentials();
        var payload = await GetClaimsPayLoad(user);
        var tokenOptions = GenerateTokenOptions(signingCredentials, payload);
        return new JwtSecurityTokenHandler().WriteToken(tokenOptions);
    }

    public async Task<string> GenerateAndSaveRefreshToken(User user)
    {
        RefreshToken? existingRefreshToken = await _repository.RefreshToken.GetRefreshTokenByUser(user);
        if (existingRefreshToken != null)
        {
            _repository.RefreshToken.DeleteRefreshToken(existingRefreshToken);
            await _repository.SaveAsync();
        }
        string token = Guid.NewGuid().ToString().Replace("-", "");


        var refreshTokenEntity = new RefreshToken
        {
            Token = token,
            UserId = user.Id,
            ExpiryDate = DateTime.Now.AddDays(_jwtConfiguration.RefreshTokenExpirationInDays),
        };
        _repository.RefreshToken.SaveRefreshToken(refreshTokenEntity);
        await _repository.SaveAsync();

        return token;
    }
    private SigningCredentials GetSigningCredentials()
    {

        var key = Encoding.UTF8.GetBytes(_jwtConfiguration.Secret!);
        var secret = new SymmetricSecurityKey(key);
        return new SigningCredentials(secret, SecurityAlgorithms.HmacSha256);
    }

    private async Task<List<Claim>> GetClaimsPayLoad(User user)
    {
        var claims = new List<Claim>{new Claim(ClaimTypes.Email, user.Email!)
    };
        var roles = await _userManager.GetRolesAsync(user);
        foreach (var role in roles)
        {
            claims.Add(new Claim(ClaimTypes.Role, role));
        }
        return claims;
    }

    private JwtSecurityToken GenerateTokenOptions(SigningCredentials signingCredentials, List<Claim> payload)
    {
        return new JwtSecurityToken(
                                    issuer: null,
                                    audience: null,
                                    claims: payload,//token payload information
                                    expires: DateTime.Now.AddDays(_jwtConfiguration.AccessTokenExpirationInMinutes),
                                    signingCredentials: signingCredentials//Defines the SecurityKey, algorithm and digest for digital signatures.


                                );
    }

}
