using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Orka.Core.Crypto;
using Orka.Core.Extensions;
using Orka.Core.Serialization.Jce;
using Orka.Core.Serialization.Jce.Structs;

namespace Orka.Core.Services;

internal class SocketService
{
    private readonly ILogger<SocketService> _logger;
    private readonly IHttpClientFactory _httpClientFactory;
    internal TcpClient Client { get; private set; } = new();

    public SocketService(ILogger<SocketService> logger, IHttpClientFactory httpClientFactory)
    {
        _logger = logger;
        _httpClientFactory = httpClientFactory;
    }

    public async Task ConnectAsync(IEnumerable<IPEndPoint> ips)
    {
        var queue = new Queue<IPEndPoint>(ips);
        while (queue.Count>0)
        {
            var ip = queue.Dequeue();
            _logger.LogInformation($"Connecting to {ip.Address}:{ip.Port}");
            // todo 自己实现tcpClient
            await Client.ConnectAsync(ip);
            if (!Client.Connected)
            {
                
            }
        }
    }


}
