using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Orka
{
    internal class BotService<T> : BackgroundService where T : IOrkaBot
    {
        private readonly ILogger<T> _logger;
        private readonly T _bot;
        private readonly IOrkaClient _client;

        public BotService(ILogger<T> logger, T bot, IOrkaClient client)
        {
            _logger = logger;
            _bot = bot;
            _client = client;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation("Start login for {BotName}", typeof(T).Name);
            await _client.LoginAsync();
        }
    }
}
