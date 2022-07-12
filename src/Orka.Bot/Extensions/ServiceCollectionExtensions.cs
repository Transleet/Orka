using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace Orka.Bot.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddOrkaBot<T>(this IServiceCollection services) where T : class, IOrkaBot
    {
        services.AddHostedService<BotService<T>>();
        services.AddSingleton<DeviceInfoManager>();
        Core.Extensions.ServiceCollectionExtensions.AddOrkaClient(services);
        services.AddSingleton<T>();
        return services;
    }
}
