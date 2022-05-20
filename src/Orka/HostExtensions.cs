using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Orka.Services;

namespace Orka;

public static class HostExtensions
{
    public static IServiceCollection AddOrkaClient(this IServiceCollection services, Action<OrkaClientOptions>? options = null)
    {
        if (options is not null)
        {
            services.Configure(options);
        }

        services.AddSingleton<WtLoginContext>();
        services.AddSingleton<WtLoginService>();
        services.AddSingleton<IOrkaClient, OrkaClient>();
        return services;
    }

    public static IServiceCollection AddOrkaBot<T>(this IServiceCollection services) where T : class,IOrkaBot
    {
        services.AddHostedService<T>();
        return services;
    }
}
