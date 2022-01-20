using System;
using System.Threading.Tasks;

using Serilog;
using Serilog.Core;

namespace Orka.Sample
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var uin = Environment.GetEnvironmentVariable("BotAccount");
            var password = Environment.GetEnvironmentVariable("BotPassword");
            OrkaClient client = OrkaClient.Create(uin);
            var logger = new LoggerConfiguration()
                .Enrich.FromLogContext()
                .MinimumLevel.Information()
                .WriteTo.Console()
                .CreateLogger();
            client.AddLogger(f => f.AddSerilog(logger));
            await client.LoginAsync();
        }
    }
}
