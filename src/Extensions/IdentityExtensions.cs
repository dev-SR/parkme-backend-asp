using System;
using System.Text;
using Domain.Entities.Models;
using Infrastructure.Data;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;

namespace src.Extensions;

public static class IdentityExtensions
{

    public static IServiceCollection AddIdentityHandlersAndStores(this IServiceCollection services)
    {
        services.AddIdentity<User, IdentityRole>(o =>
        {
            o.Password.RequireDigit = true;
            o.Password.RequireLowercase = false;
            o.Password.RequireUppercase = false;
            o.Password.RequireNonAlphanumeric = false;
            o.Password.RequiredLength = 6;
            o.User.RequireUniqueEmail = true;
        })
        .AddEntityFrameworkStores<RepositoryDbContext>()
        .AddDefaultTokenProviders();

        return services;
    }

    public static IServiceCollection AddIdentityAuth(this IServiceCollection services)
    {

        string? JWT_ISSUER = Environment.GetEnvironmentVariable("JWT_ISSUER");
        string? JWT_AUDIENCE = Environment.GetEnvironmentVariable("JWT_AUDIENCE");
        string? JWT_SECRET = Environment.GetEnvironmentVariable("JWT_SECRET");

        if (JWT_SECRET == null || JWT_ISSUER == null || JWT_AUDIENCE == null)
        {
            throw new ArgumentNullException("JWT_SECRET, JWT_ISSUER, JWT_AUDIENCE");
        }

        services.AddAuthentication(opt =>
        {
            opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
        })
        .AddJwtBearer(options =>
        {
            options.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuer = false,
                ValidateAudience = false,
                ValidateLifetime = true,
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(JWT_SECRET!))
            };
        });

        services.AddAuthorization();

        return services;
    }

    public static WebApplication AddIdentityAuthMiddlewares(this WebApplication app)
    {
        app.UseAuthentication();//MUST BE BEFORE AUTHORIZATION
        app.UseAuthorization();
        return app;
    }

}