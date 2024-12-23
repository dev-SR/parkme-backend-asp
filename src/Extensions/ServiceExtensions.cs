using System;
using Services;
using Services.Contracts;

namespace src.Extensions;

public static class ServiceExtensions
{
        public static void ConfigureLoggerService(this IServiceCollection services) =>
                services.AddScoped<ILoggerManager, LoggerManager>();

        public static void ConfigureServiceManager(this IServiceCollection services) =>
                        services.AddScoped<IServiceManager, ServiceManager>();

}
