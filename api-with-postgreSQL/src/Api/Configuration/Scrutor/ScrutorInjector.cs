using System.Reflection;
using Application.Configuration;
using Infrastructure.Configuration;

namespace Api.Configuration.Scrutor;

internal static class ScrutorInjector
{
    public static IServiceCollection AddScrutorScan(this IServiceCollection services)
    {
        Assembly[] assemblies =
        {
            typeof(InfrastructureLayerInjector).Assembly,
            typeof(ApplicationLayerInjector).Assembly,
            Assembly.GetExecutingAssembly()
        };

        services.Scan(scan =>
        {
            scan.FromAssemblies(assemblies)
                .AddClasses()
                .AsMatchingInterface();
        });

        return services;
    }
}