using Core.Interfaces.Repository;
using Core.Interfaces.Services;
using Core.Service;
using Infra.Context;
using Infra.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace IoC;

public static class IServiceCollectionExtension
{
    public static IServiceCollection RegisterServices(this IServiceCollection services)
    {
        services.AddScoped(typeof(IBaseService<>), typeof(BaseService<>));
        //services.AddScoped<IExemploService, ExemploService>();
        

        RegisterRepository(services);
        RegisterContext(services);

        return services;
    }

    public static IServiceCollection RegisterRepository(this IServiceCollection services)
    {
        services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
        //services.AddScoped<IExemploRepository, ExemploRepository>();
        

        return services;
    }
    public static IServiceCollection RegisterContext(this IServiceCollection services)
    {
        services.AddScoped<IbgeContext>();
        return services;
    }
}
