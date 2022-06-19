using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Orka.Core.Services;
using Orka.Core.Services.WtLogin;

namespace Orka.Core.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection TyrAddOrkaClient(this IServiceCollection services, Action<OrkaClientOptions>? options = null)
    {
        if (options is not null)
        {
            services.Configure(options);
        }
        services.TryAddSingleton<WtLoginContext>();
        services.TryAddSingleton<WtLoginService>();
        services.TryAddSingleton<SocketService>();
        services.TryAddSingleton<IOrkaClient, OrkaClient>();
        return services;
    }


}
