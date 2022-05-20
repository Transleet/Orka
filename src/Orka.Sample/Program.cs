using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.UserSecrets;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Serilog;
using Serilog.Core;

namespace Orka.Sample;

internal class Program
{
    private static async Task Main(string[] args)
    {
        var builder = Host.CreateDefaultBuilder(args);
        builder.ConfigureAppConfiguration((_, config) =>
        {
            config.AddUserSecrets<Program>();
        });
        builder.ConfigureServices((context, services) =>
        {
            services.Configure<OrkaClientOptions>(context.Configuration.GetSection("Account"));
            services.AddOrkaClient();
            services.AddLogging(config =>
            {
                config.ClearProviders();
                config.AddSerilog(new LoggerConfiguration()
                    .Enrich.FromLogContext()
                    .MinimumLevel.Information()
                    .WriteTo.Console()
                    .CreateLogger());
            });
            services.AddOrkaBot<SimpleBot>();
        });
        var app = builder.Build();
        await app.RunAsync();
    }
}
