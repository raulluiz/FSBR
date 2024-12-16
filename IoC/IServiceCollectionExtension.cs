using Core.Interfaces.Repository;
using Core.Interfaces.Services;
using Core.Service;
using Ibge.API.Infra.Context;
using Ibge.API.Infra.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace IoC;

public static class IServiceCollectionExtension
{
    public static IServiceCollection RegisterServices(this IServiceCollection services)
    {
        services.AddScoped(typeof(IBaseService<>), typeof(BaseService<>));
        services.AddScoped<IProcessoService, ProcessoService>();
        

        RegisterRepository(services);
        RegisterContext(services);

        return services;
    }

    public static IServiceCollection RegisterRepository(this IServiceCollection services)
    {
        services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
        services.AddScoped<IProcessoRepository, ProcessoRepository>();
        

        return services;
    }
    public static IServiceCollection RegisterContext(this IServiceCollection services)
    {
        services.AddScoped<IbgeContext>();
        return services;
    }
}
