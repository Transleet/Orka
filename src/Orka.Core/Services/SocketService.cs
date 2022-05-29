using System;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace Orka.Core.Services
{
    internal class SocketService
    {
        private readonly ILogger<SocketService> _logger;
        private bool _connected;
        private TcpClient _tcpClient;

        public SocketService(ILogger<SocketService> logger) => _logger = logger;

        public async Task ConnectAsync()
        {
            if (_connected)
            {
                _logger.LogError("Can't connect to server while already connected");
            }
        }
    }
}
