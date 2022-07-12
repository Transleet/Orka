using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Orka.Core;

namespace Orka.Bot;

internal class BotService<T> : BackgroundService where T : IOrkaBot
{
    private readonly IOrkaClient _client;
    private readonly DeviceInfoManager _deviceInfoManager;
    private readonly ILogger<T> _logger;
    private readonly T _bot;


    public BotService(IOrkaClient client, DeviceInfoManager deviceInfoManager, ILogger<T> logger, T bot)
    {
        _client = client;
        _deviceInfoManager = deviceInfoManager;
        _logger = logger;
        _bot = bot;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        var deviceInfo = _deviceInfoManager.GetDefaultDeviceInfo();
        await Task.Delay(1000, stoppingToken);
        await _client.LoginWithPasswordAsync(deviceInfo);
    }
}
