using BlazorAll.Shared.Services;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorAll.Shared;

public static class DependencyInjection
{
    public static IServiceCollection AddSharedDependencies(this IServiceCollection services)
    {
        services.AddScoped<ProductService>();

        return services;
    }
}
