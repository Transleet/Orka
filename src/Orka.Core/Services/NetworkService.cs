﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.NetworkInformation;
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

    private List<IPEndPoint> _servers = new();
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
        SvcRspHttpServerList svcRspHttpServerList = await FetchServerListAsync(device);
        _servers = await PingServerAsync(svcRspHttpServerList);
        if (_servers.Count < 1)
        {
            _logger.LogError("Server list was null, connect failed.");
            return;
        }
    }


    private async Task<SvcRspHttpServerList> FetchServerListAsync(DeviceInfo deviceInfo)
    {
        _logger.LogInformation("Fetching server list...");
        var httpClient = _httpClientFactory.CreateClient();
        httpClient.Timeout = TimeSpan.FromSeconds(10);
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
        byte[] pkt = new RequestPacket
        {
            IVersion = 3,
            CPacketType = 0,
            IMessageType = 0,
            IRequestId = 0,
            SServantName = "ConfigHttp",
            SFuncName = "HttpServerListReq",
            SBuffer = new RequestDataVersion3 { Map = new JceMap { ["HttpServerListReq"] = BinaryPacket.PackUniRequestData(payload) } }.ToByteArray(),
            ITimeout = 0,
            Context = new JceMap(),
            Status = new JceMap()
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
            throw;
        }
        byte[] dec = tea.Decrypt(body);
        var rspPacket = JceSerializer.Deserialize<RequestPacket>(dec[4..]);
        var data = JceSerializer.Deserialize<RequestDataVersion3>(rspPacket.SBuffer);
        if (data.Map["HttpServerListRes"] is byte[] res)
        {
            var serverList = JceSerializer.Deserialize<SvcRspHttpServerList>(res[1..^1]);
            return serverList;
        }
        else
        {
            throw new Exception("Unable to fetch server list.");
        }
    }

    private async Task<List<IPEndPoint>> PingServerAsync(SvcRspHttpServerList list)
    {
        Ping ping = new();
        var pinged = new List<dynamic>();
        foreach (SsoServerInfo ssoServerInfo in list.Servers)
        {
            PingReply pingReply = await ping.SendPingAsync(ssoServerInfo.Server,2000);
            if (pingReply.Status != IPStatus.Success)
            {
                continue;
            }
            pinged.Add(new
            {
                Ms = pingReply.RoundtripTime,
                Ip = pingReply.Address,
                ssoServerInfo.Port
            });
        }

        var sorted = pinged.OrderBy(o => o.Ms);
        return sorted.Select(o => new IPEndPoint(o.Ip, o.Port)).ToList();
    }
}
