using System;

namespace src.Extensions;

public static class AppConfigExtensions
{
    //Extend ConfigureCors()
    public static void ConfigureCors(this IServiceCollection services)
    {
        services.AddCors(options =>
        {
            options.AddPolicy("CorsPolicy", builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
        });
    }/* 
        middleware cors in Program.cs
        app.UseCors("CorsPolicy");
     */


}
