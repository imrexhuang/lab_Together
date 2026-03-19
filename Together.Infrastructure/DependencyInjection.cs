using Microsoft.Extensions.DependencyInjection;

namespace Together.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddService(this IServiceCollection services)
    {
        return services;
    }
}