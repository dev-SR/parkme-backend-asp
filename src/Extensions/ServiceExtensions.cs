using Domain.Contracts;
using Infrastructure.Data.Repositories;
using Services.Contracts;
using Services;

namespace src.Extensions;

public static class ServiceExtensions
{
        public static void ConfigureLoggerService(this IServiceCollection services) =>
                services.AddSingleton<ILoggerManager, LoggerManager>();

        public static void ConfigureServiceManager(this IServiceCollection services) =>
                services.AddScoped<IServiceManager, ServiceManager>();

        public static void ConfigureRepositoryManager(this IServiceCollection services) =>
                services.AddScoped<IRepositoryManager, RepositoryManager>();
}
