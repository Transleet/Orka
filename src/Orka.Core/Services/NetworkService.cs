using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
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
using Orka.Core.Packets;
using Orka.Core.Serialization.Jce;
using Orka.Core.Serialization.Jce.Structs;

namespace Orka.Core.Services;

internal class NetworkService
{
    private readonly ILogger<SocketService> _logger;
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly SocketService _socketService;
    private readonly DeviceManager _deviceManager;

    private ImmutableArray<IPEndPoint> _servers;
    private bool _connected;
    private DeviceInfo _deviceInfo;

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
        _deviceInfo = _deviceManager.GetDefaultDevice();
        var servers = new List<IPEndPoint>
        {
            new(IPAddress.Parse("42.81.172.81"),80),
            new(IPAddress.Parse("114.221.148.59"),14000),
            new(IPAddress.Parse("42.81.172.147"),443),
            new(IPAddress.Parse("125.94.60.146"),80),
            new(IPAddress.Parse("114.221.144.215"),80),
            new(IPAddress.Parse("42.81.172.22"),80)
        };
        servers.AddRange(await FetchServerListAsync(_deviceInfo));
        servers.AddRange((await Dns.GetHostAddressesAsync("msfwifi.3g.qq.com")).Select(_ => new IPEndPoint(_, 8080)));
        _servers = await PingServersAsync(servers);
        if (servers.Count < 1)
        {
            _logger.LogError("Server list was null, connect failed.");
            return;
        }
        await _socketService.ConnectAsync(servers);
    }

    public async Task SendLoginPacketAsync(OrkaClient client)
    {
        var uin = client.Uin;
        var protocol = _deviceInfo.Protocol;
        var deviceInfo = _deviceInfo;
        var sigInfo = client.SigInfo;
        var stream = new MemoryStream();
        stream.Write(Number.FromUInt16(9));
        stream.Write(Number.FromUInt16(23));
        stream.Write(Tlv.T18(uin, protocol));
        stream.Write(Tlv.T1(uin));
        stream.Write(Tlv.T106(uin, _deviceInfo, protocol, sigInfo, client.HashedPassword));
        stream.Write(Tlv.T116(protocol));
        stream.Write(Tlv.T100(protocol));
        stream.Write(Tlv.T107());
        stream.Write(Tlv.T142(protocol));
        stream.Write(Tlv.T144(deviceInfo,sigInfo));
        stream.Write(Tlv.T145(deviceInfo));
        stream.Write(Tlv.T147(protocol));
        stream.Write(Tlv.T154(sigInfo));
        stream.Write(Tlv.T141(deviceInfo));
        stream.Write(Tlv.T8());
        stream.Write(Tlv.T511());
        stream.Write(Tlv.T187(deviceInfo));
        stream.Write(Tlv.T188(deviceInfo));
        stream.Write(Tlv.T194(deviceInfo));
        stream.Write(Tlv.T191());
        stream.Write(Tlv.T202(deviceInfo));
        stream.Write(Tlv.T177(protocol));
        stream.Write(Tlv.T516());
        stream.Write(Tlv.T521());
        stream.Write(Tlv.T525());
        var body = stream.ToArray();
        await _socketService.SendAsync(body);
    }


    private async Task<List<IPEndPoint>> FetchServerListAsync(DeviceInfo deviceInfo)
    {
        _logger.LogInformation("Start fetching server list.");
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
            var rsp = await httpClient.PostAsync("https://configsvr.msf.3g.qq.com/configsvr/serverlist.jsp",
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
            return serverList.Servers.Where(_ => IPAddress.TryParse(_.Server, out var _)).Select(_ => new IPEndPoint(IPAddress.Parse(_.Server), _.Port)).ToList();
        }
        throw new Exception("Unable to fetch server list.");
    }

    private async Task<ImmutableArray<IPEndPoint>> PingServersAsync(IEnumerable<IPEndPoint> ips)
    {
        var ipList = ips.ToList();
        var tasks = ipList.Select(_ =>
        {
            var ping = new Ping();
            return ping.SendPingAsync(_.Address, 2000);
        }).ToList();
        var result = await Task.WhenAll(tasks);
        return result.Where(_ => _.Status == IPStatus.Success).OrderBy(_ => _.RoundtripTime)
            .Join(ipList, _ => _.Address, _ => _.Address, (_, ip) => ip).ToImmutableArray();
    }
}
