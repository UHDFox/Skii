using Application.Infrastructure.Automapper;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using Web.Infrastructure.Automapper;

namespace Web.Infrastructure;

public static class ServiceCollectionExtension
{
    public static IServiceCollection ConfigureAutomapper(this IServiceCollection services)
    {
        services.AddAutoMapper(typeof(WebProfile));
        services.AddAutoMapper(typeof(ApplicationProfile));
        return services;
    }

    public static IServiceCollection ConfigureControllers(this IServiceCollection services)
    {
        services.AddControllers().AddNewtonsoftJson(opts =>
            opts.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore);

        return services;
    }
}