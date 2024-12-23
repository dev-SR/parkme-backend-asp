using System;
using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Services.Contracts;
using Shared;
using Shared.DTO;
using System.Text;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Security.Cryptography;
namespace Services;

internal sealed class AuthenticationService : IAuthenticationService
{

    private readonly ILoggerManager _logger;
    private readonly IMapper _mapper;
    private readonly UserManager<User> _userManager;
    private readonly IConfiguration _configuration;

    private User? _user;

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
        user.UserName = userForRegistration.Email; //email is used as username

        var result = await _userManager.CreateAsync(user, userForRegistration.Password!);

        if (result.Succeeded)
            await _userManager.AddToRolesAsync(user, ["User"]);
        return result;
    }

    public async Task<bool> ValidateUser(UserForLoginDto userForLogin)
    {
        _user = await _userManager.FindByNameAsync(userForLogin.Email);
        var result = _user != null && await _userManager.CheckPasswordAsync(_user, userForLogin.Password);
        if (!result)
            _logger.LogWarn($"{nameof(ValidateUser)}: Authentication failed. Wrong email or password.");
        return result;
    }
    public async Task<TokenDto> CreateToken(bool populateExp)
    {
        var signingCredentials = GetSigningCredentials();
        var claims = await GetClaims();
        var tokenOptions = GenerateTokenOptions(signingCredentials, claims);

        var refreshToken = GenerateRefreshToken();

        _user!.RefreshToken = refreshToken;

        if (populateExp)
            _user.RefreshTokenExpiryTime = DateTime.Now.AddDays(7);

        await _userManager.UpdateAsync(_user);

        var accessToken = new JwtSecurityTokenHandler().WriteToken(tokenOptions);

        return new TokenDto(accessToken, refreshToken);
    }

    private string GenerateRefreshToken()
    {
        var randomNumber = new byte[32];
        using (var rng = RandomNumberGenerator.Create())
        {
            rng.GetBytes(randomNumber);
            return Convert.ToBase64String(randomNumber);
        }
    }

    /* 
    GetSigningCredentials is used to get the signing credentials for the token. We are using the HMACSHA256 algorithm for the token.
     */
    private SigningCredentials GetSigningCredentials()
    {
        string? JWT_SECRET = Environment.GetEnvironmentVariable("JWT_SECRET");

        var key = Encoding.UTF8.GetBytes(JWT_SECRET!);
        var secret = new SymmetricSecurityKey(key);
        return new SigningCredentials(secret, SecurityAlgorithms.HmacSha256);
    }
    private async Task<List<Claim>> GetClaims()
    {
        var claims = new List<Claim>{new Claim(ClaimTypes.Name, _user!.UserName!)
    };
        var roles = await _userManager.GetRolesAsync(_user);
        foreach (var role in roles)
        {
            claims.Add(new Claim(ClaimTypes.Role, role));
        }
        return claims;
    }
    private JwtSecurityToken GenerateTokenOptions(SigningCredentials signingCredentials, List<Claim> claims)
    {

        string? JWT_ISSUER = Environment.GetEnvironmentVariable("JWT_ISSUER");
        string? JWT_AUDIENCE = Environment.GetEnvironmentVariable("JWT_AUDIENCE");
        string? JWT_EXPIRES = Environment.GetEnvironmentVariable("JWT_EXPIRES");


        var tokenOptions = new JwtSecurityToken
                                (
                                issuer: JWT_ISSUER,
                                audience: JWT_AUDIENCE,
                                claims: claims,
                                expires: DateTime.Now.AddMinutes(Convert.ToDouble(JWT_EXPIRES)),
                                signingCredentials: signingCredentials
                                );
        return tokenOptions;
    }



    /* GetPrincipalFromExpiredToken is used to get the user principal from from the JwtSecurityTokenHandler class for this purpose.  principal is the user object that we will use to generate the new token.

Also, you can see the ValidateLifetime property set to `true`. sometimes in our client app, we want to refresh the token before it expires, and that’s what we forced here in our API. But if you want to
allow the refresh token functionality for the expired token as well, set this property to false.

 */
    private ClaimsPrincipal GetPrincipalFromExpiredToken(string token)
    {
        string? JWT_SECRET = Environment.GetEnvironmentVariable("JWT_SECRET");
        string? JWT_ISSUER = Environment.GetEnvironmentVariable("JWT_ISSUER");
        string? JWT_AUDIENCE = Environment.GetEnvironmentVariable("JWT_AUDIENCE");

        var tokenValidationParameters = new TokenValidationParameters
        {
            ValidateAudience = true,
            ValidateIssuer = true,
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(JWT_SECRET!)),
            ValidateLifetime = true,
            ValidIssuer = JWT_ISSUER,
            ValidAudience = JWT_AUDIENCE,
        };

        var tokenHandler = new JwtSecurityTokenHandler();

        SecurityToken securityToken;
        var principal = tokenHandler.ValidateToken(token, tokenValidationParameters, out securityToken);

        var jwtSecurityToken = securityToken as JwtSecurityToken;
        if (jwtSecurityToken == null || !jwtSecurityToken.Header.Alg.Equals(SecurityAlgorithms.HmacSha256,
            StringComparison.InvariantCultureIgnoreCase))
        {
            throw new SecurityTokenException("Invalid token");
        }

        return principal;
    }
}