using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Domain.Contracts;
using Domain.Entities.ConfigurationModels;
using Domain.Entities.Exceptions;
using Domain.Entities.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using Services.Contracts;
using Shared.DTO.Auth;

namespace Services;

public class TokenService : ITokenService
{
    private readonly UserManager<User> _userManager;
    private readonly JwtConfiguration _jwtConfiguration;
    private readonly IRepositoryManager _repository;
    private readonly ILoggerManager _logger;
    public TokenService(IRepositoryManager repository, UserManager<User> userManager, ILoggerManager logger)
    {
        _logger = logger;
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


    public async Task<AccessTokenDto> ReGenerateAccessToken(RefreshTokenRequestDto requestTokenDto)
    {
        var refreshToken = await _repository.RefreshToken.GetRefreshTokenByToken(requestTokenDto.refreshToken);
        if (refreshToken == null || refreshToken.ExpiryDate < DateTime.Now)
        {
            throw new RefreshTokenBadRequest();
        }
        // _logger.LogInfo($"Refreshing token for user: {refreshToken.User.Id}");

        var newAccessToken = await GenerateAccessToken(refreshToken.User);

        return new AccessTokenDto(newAccessToken);
    }


    public async Task<TokenPairDto> ReGenerateAccessAndRefreshToken(RefreshTokenRequestDto requestTokenDto)
    {
        var refreshToken = await _repository.RefreshToken.GetRefreshTokenByToken(requestTokenDto.refreshToken);
        if (refreshToken == null || refreshToken.ExpiryDate < DateTime.Now)
        {
            throw new RefreshTokenBadRequest();
        }
        // _logger.LogInfo($"Refreshing token for user: {refreshToken.User.Id}");

        var newAccessToken = await GenerateAccessToken(refreshToken.User);
        var newRefreshToken = await GenerateAndSaveRefreshToken(refreshToken.User);
        return new TokenPairDto(newAccessToken, newRefreshToken);
    }

    private SigningCredentials GetSigningCredentials()
    {

        var key = Encoding.UTF8.GetBytes(_jwtConfiguration.Secret!);
        var secret = new SymmetricSecurityKey(key);
        return new SigningCredentials(secret, SecurityAlgorithms.HmacSha256);
    }

    private async Task<List<Claim>> GetClaimsPayLoad(User user)
    {
        var claims = new List<Claim>{
            new Claim(ClaimTypes.Email, user.Email!),
            new Claim(ClaimTypes.NameIdentifier, user.Id)
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
        var expiresAt = _jwtConfiguration.AccessTokenExpirationInMinutes;
        _logger.LogInfo($"Access token expires in {expiresAt} minutes.");
        return new JwtSecurityToken(
                                    issuer: null,
                                    audience: null,
                                    claims: payload,//token payload information
                                    expires: DateTime.Now.AddMinutes(expiresAt),
                                    signingCredentials: signingCredentials//Defines the SecurityKey, algorithm and digest for digital signatures.,
                                );
    }


}
