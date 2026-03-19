using Microsoft.Extensions.DependencyInjection;
using Together.Application.Common.Interfaces;
using Together.Infrastructure.Persistence;

namespace Together.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddService(this IServiceCollection services)
    {
        //services.AddScoped<IEventRepository, EventMemoryRepository>();
        services.AddScoped<IEventRepository, EventEFCoreRepository>();
        return services;
    }
}