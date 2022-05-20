using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Konata.Core;
using Konata.Core.Common;
using Konata.Core.Interfaces;
using Konata.Core.Interfaces.Api;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Orka.Sample;

internal class SimpleBot : OrkaBot
{
    private readonly ILogger<SimpleBot> _logger;
    private readonly IOptions<OrkaClientOptions> _options;
    private readonly Bot _bot;
    private readonly BotDevice _device;
    private readonly BotKeyStore _keyStore;
    private readonly BotConfig _config;

    public SimpleBot(ILogger<SimpleBot> logger, IOptions<OrkaClientOptions> options)
    {
        _logger = logger;
        _options = options;
        _bot = BotFather.Create("1684736227", "bot!summpot",out _config,out _device,out _keyStore);
    }


    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        if (await _bot.Login())
        {
            await _bot.SendFriendMessage(1507180359, "1111");
        }
    }

}
