using System.Net;
using System.Net.Sockets;
using Microsoft.Extensions.Logging;

namespace Orka.Core.Services;

internal class SocketService
{
    private readonly ILogger<SocketService> _logger;

    private readonly TcpClient _tcpClient = new();
    private NetworkStream? _dataStream;

    public SocketService(ILogger<SocketService> logger)
    {
        _logger = logger;
    }

    public bool Connected => _tcpClient.Connected;

    public async Task ConnectAsync(IEnumerable<IPEndPoint> ips)
    {
        if (Connected)
        {
            _logger.LogWarning("Already connected!");
            return;
        }
        foreach (IPEndPoint ip in ips)
        {
            _logger.LogInformation("Connecting to server {ip}", ip);
            try
            {
                await _tcpClient.ConnectAsync(ip);
                _logger.LogInformation("Successfully connected to server {ip}", ip);
                break;
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Connect to server {ip} failed.", ip);
                throw;
            }
        }
        if (!Connected)
        {
            _logger.LogError("Can't connect to any server.");
        }
        _dataStream = _tcpClient.GetStream();
    }

    public async Task SendAsync(byte[] pkt)
    {
        if (!Connected)
        {
            _logger.LogWarning("Can't send packet when TcpClient is not connected.");
        }

        try
        {
            var stream = _tcpClient.GetStream();
            await stream.WriteAsync(pkt);
        }
        catch (Exception e)
        {
            _logger.LogError(e, "Failed to send packet.");
            throw;
        }

    }
}
