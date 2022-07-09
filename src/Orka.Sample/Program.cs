using Azure.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Orka.Bot.Extensions;
using Orka.Core;
using Serilog;
using Serilog.Events;

namespace Orka.Sample;

public class Program
{
    public static async Task Main(string[] args) {
        var builder = WebApplication.CreateBuilder(args);
        if (builder.Environment.IsProduction())
        {
            builder.Configuration.AddAzureKeyVault(new Uri("https://orkasamplesecrets.vault.azure.net/"),
                new DefaultAzureCredential());
        }
        
        builder.Host.UseSerilog((context, services, config) =>
        {
            config
                .ReadFrom.Configuration(context.Configuration)
                .ReadFrom.Services(services)
                .Enrich.FromLogContext()
                .WriteTo.Console();
        });
        builder.Services.Configure<OrkaClientOptions>(options =>
        {
            options.Uin = builder.Configuration["Bot:Uin"];
            options.Password = builder.Configuration["Bot:Password"];
        });

        builder.Services.AddOrkaBot<EchoBot>();

        var app = builder.Build();
        app.UseSerilogRequestLogging();
        await app.RunAsync();
    }
}
