using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Logging;
using Orka.Core.Services;

namespace Orka.Core.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection TyrAddOrkaClient(this IServiceCollection services, Action<OrkaClientOptions>? options = null)
    {
        if (options is not null)
        {
            services.Configure(options);
        }

        services.AddOptions();

        services.AddHttpClient();
        services.TryAddSingleton<DeviceManager>();
        services.TryAddSingleton<NetworkService>();
        services.TryAddSingleton<SocketService>();
        services.TryAddSingleton<IOrkaClient, OrkaClient>();
        return services;
    }


}
