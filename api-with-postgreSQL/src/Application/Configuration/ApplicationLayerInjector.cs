using Microsoft.Extensions.DependencyInjection;

namespace Application.Configuration;

public static class ApplicationLayerInjector
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        return services;
    }
}