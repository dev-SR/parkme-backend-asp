namespace Domain.Entities.ConfigurationModels;

public class JwtConfiguration
{
    public string ValidIssuer { get; set; }
    public string ValidAudience { get; set; }
    public string Secret { get; set; }

    public double AccessTokenExpirationInMinutes { get; set; }
    public double RefreshTokenExpirationInDays { get; set; }


    public JwtConfiguration()
    {
        ValidIssuer = Environment.GetEnvironmentVariable("JWT_ISSUER")!;
        ValidAudience = Environment.GetEnvironmentVariable("JWT_AUDIENCE")!;
        Secret = Environment.GetEnvironmentVariable("JWT_SECRET")!;
        string _accessTokenExpiration = Environment.GetEnvironmentVariable("JWT_ACCESS_TOKEN_MINUTES")!;
        string _refreshTokenExpiration = Environment.GetEnvironmentVariable("JWT_REFRESH_TOKEN_DAYS")!;
        AccessTokenExpirationInMinutes = Convert.ToDouble(_accessTokenExpiration);
        RefreshTokenExpirationInDays = Convert.ToDouble(_refreshTokenExpiration);
    }
}
