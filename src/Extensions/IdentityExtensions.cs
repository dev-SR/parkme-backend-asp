using System;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.AspNetCore.Identity;

namespace src.Extensions;

public static class IdentityExtensions
{
    public static void ConfigureIdentity(this IServiceCollection services)
    {
        var builder = services.AddIdentity<User, IdentityRole>(o =>
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
    }
}
