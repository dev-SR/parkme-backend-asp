namespace Domain.Entities.ConfigurationModels;

public class JwtConfiguration
{
    public string? ValidIssuer { get; set; }
    public string? ValidAudience { get; set; }
    public string? Expires { get; set; }
    public string? Secret { get; set; }

    public JwtConfiguration()
    {
        ValidIssuer = Environment.GetEnvironmentVariable("JWT_ISSUER");
        ValidAudience = Environment.GetEnvironmentVariable("JWT_AUDIENCE");
        Expires = Environment.GetEnvironmentVariable("JWT_EXPIRES");
        Secret = Environment.GetEnvironmentVariable("JWT_SECRET");
    }
}
