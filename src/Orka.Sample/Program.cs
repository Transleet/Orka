using Azure.Identity;

namespace Orka.Sample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            if (builder.Environment.IsProduction())
            {
                builder.Configuration.AddAzureKeyVault(new Uri("https://orkasamplesecrets.vault.azure.net/"),
                    new DefaultAzureCredential());
            }

            builder.Services.Configure<OrkaClientOptions>(options =>
            {
                options.Uin = builder.Configuration["Bot:Uin"];
                options.Password = builder.Configuration["Bot:Password"];
            });

            builder.Services.AddOrkaBot<EchoBot>();

            var app = builder.Build();

            app.Run();
        }
    }
}
