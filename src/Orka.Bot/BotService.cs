using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Orka.Core;

namespace Orka.Bot;

internal class BotService<T> : BackgroundService where T : IOrkaBot
{
    private readonly IOrkaClient _client;
    private readonly ILogger<T> _logger;
    private readonly T _bot;


    public BotService(ILogger<T> logger, T bot, IOrkaClient client)
    {
        _logger = logger;
        _bot = bot;
        _client = client;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        await Task.Delay(1000, stoppingToken);
        await _client.LoginAsync();
    }
}
