using Infrastructure.Ef;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Configuration;

public static class InfrastructureLayerInjector
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services, 
        IConfiguration configuration)
    {
        string connectionString = configuration.GetConnectionString(OperationalContext.Name);
        
        services
            .AddDbContext<OperationalContext>(x => x
                .UseNpgsql(connectionString, options =>
                {
                    options.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery);
                })
                .UseSnakeCaseNamingConvention());
        
        return services;
    }
}