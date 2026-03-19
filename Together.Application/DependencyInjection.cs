using Microsoft.Extensions.DependencyInjection;
using Together.Application.Services;

namespace Together.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IEventService, EventService>();
        return services;
    }
}