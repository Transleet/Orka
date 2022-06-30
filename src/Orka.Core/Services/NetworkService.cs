using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Orka.Core.Crypto;
using Orka.Core.Extensions;
using Orka.Core.Serialization.Jce;
using Orka.Core.Serialization.Jce.Structs;

namespace Orka.Core.Services;

internal class NetworkService
{
    private readonly ILogger<SocketService> _logger;
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly SocketService _socketService;
    private readonly DeviceManager _deviceManager;

    private readonly List<IPEndPoint> _servers = new();
    private bool _connected;

    public NetworkService(ILogger<SocketService> logger, IHttpClientFactory httpClientFactory, SocketService socketService, DeviceManager deviceManager)
    {
        _logger = logger;
        _httpClientFactory = httpClientFactory;
        _socketService = socketService;
        _deviceManager = deviceManager;
    }

    public async Task ConnectAsync()
    {
        if (_connected)
        {
            _logger.LogError("Can't connect to server while already connected");
        }
        var device = _deviceManager.GetDefaultDevice();
        await FetchServersAsync(device);
    }


    private async Task FetchServersAsync(DeviceInfo deviceInfo)
    {
        _logger.LogInformation("Fetching server list...");
        var httpClient = _httpClientFactory.CreateClient();
        byte[] key = Convert.FromHexString("F0441F5FF42DA58FDCF7949ABA62D411");
        byte[] payload = new SvcReqHttpServerList
        {
            L1 = 0,
            L2 = 0,
            B3 = 1,
            S4 = "00000",
            I5 = 100,
            I6 = (int)deviceInfo.Protocol.AppId,
            S7 = deviceInfo.IMEI,
            L8 = 0,
            L9 = 0,
            L10 = 0,
            L11 = 0,
            B12 = 0,
            L13 = 0,
            B14 = 1
        }.ToByteArray();
        byte[] pkt = new RequestPacket()
        {
            IVersion = 3,
            SServantName = "ConfigHttp",
            SFuncName = "HttpServerListReq",
            SBuffer = new RequestDataVersion3 { Map = new JceMap { ["HttpServerListReq"] = BinaryPacket.PackUniRequestData(payload) } }.ToByteArray()
        }.ToByteArray();
        var tea = new Tea(key);
        byte[] reqData = tea.Encrypt(BinaryPacket.CombineLength((uint)pkt.Length, pkt));
        byte[] body;
        try
        {
            var rsp = await httpClient.PostAsync("https://configsvr.msf.3g.qq.com/configsvr/serverlist.jsp?mType=getssolist",
                new ByteArrayContent(reqData));
            body = await rsp.Content.ReadAsByteArrayAsync();
        }
        catch (Exception e)
        {
            _logger.LogTrace(e, e.Message);
            throw new Exception("Unable to fetch server list.");
        }
        byte[] dec = tea.Decrypt(body);
        var rspPacket = JceSerializer.Deserialize<RequestPacket>(dec);
        var data = JceSerializer.Deserialize<RequestDataVersion3>(rspPacket.SBuffer);
        if (data.Map["HttpServerListRes"] is byte[] bytes)
        {

        }
        else
        {
            throw new Exception("Unable to fetch server list.");
        }
    }
}
