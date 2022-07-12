using System.Net;
using System.Net.Sockets;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Orka.Core.Services;

internal class SocketService
{
    private readonly ILogger<SocketService> _logger;

    private readonly TcpClient _tcpClient = new();
    private NetworkStream? _dataStream;
    private Task _loopTask;

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
        _loopTask = StartNetLoopAsync();
    }

    public async Task SendAsync(byte[] pkt)
    {
        if (!Connected || _dataStream is null)
        {
            _logger.LogError("Can't send packet when TcpClient is not connected.");
            throw new Exception("Try to send packet when TcpClient is not connected.");
        }

        try
        {
            await _dataStream.WriteAsync(pkt);
            _logger.LogInformation("Send pkt with length : {length}", pkt.Length);
        }
        catch (Exception e)
        {
            _logger.LogError(e, "Failed to send packet.");
            throw;
        }

    }

    private async Task StartNetLoopAsync()
    {
        while (Connected && _dataStream is not null)
        {
            await Task.Delay(1000);
            Console.WriteLine($"Available: {_tcpClient.Available}");
            if (_tcpClient.Available > 0)
            {
                byte[] buffer = new byte[4];
                await _dataStream.ReadExactlyAsync(buffer);
                int length = Number.ToInt32(buffer);
                _logger.LogInformation("Receive packet with length: {length}", length);
            }

        }
    }
}
