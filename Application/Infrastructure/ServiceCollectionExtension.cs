using Application.Skipass;
using Application.Tariff;
using Application.Visitor;
using Application.VisitorAction;
using Newtonsoft.Json;
using Microsoft.Extensions.DependencyInjection;

namespace Application.Infrastructure;

public static class ServiceCollectionExtension
{
    public static IServiceCollection ConfigureSkipassServices(this IServiceCollection services)
    {
        services.AddTransient<ISkipassService, SkipassService>();
        return services;
    }

    public static IServiceCollection ConfigureTariffServices(this IServiceCollection services)
    {
        services.AddTransient<ITariffService, TariffService>();
        return services;
    }

    public static IServiceCollection ConfigureVisitorServices(this IServiceCollection services)
    {
        services.AddTransient<IVisitorService, VisitorService>();
        return services;
    }

    public static IServiceCollection ConfigureVisitorActionsServices(this IServiceCollection services)
    {
        services.AddTransient<IVisitorActions, VisitorActionsService>();
        return services;
    }
}