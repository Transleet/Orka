using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;
using Orka.Services;

namespace Orka;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection TyrAddOrkaClient(this IServiceCollection services)
    {
        services.TryAddSingleton<WtLoginContext>();
        services.TryAddSingleton<WtLoginService>();
        services.TryAddSingleton<IOrkaClient, OrkaClient>();
        return services;
    }

    public static IServiceCollection AddOrkaBot<T>(this IServiceCollection services) where T : class, IOrkaBot
    {
        TyrAddOrkaClient(services);
        services.AddSingleton<T>();
        services.AddHostedService<BotService<T>>();
        return services;
    }
}
