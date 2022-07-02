using Orka.Core.Crypto;
using Orka.Core.Serialization.Jce.Structs;
using Orka.Core.Serialization.Jce;
using Orka.Core;
using System.Net.Http;
using System;
using System.Threading.Tasks;
using Orka.Core.Extensions;
using Xunit;
using Xunit.Abstractions;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net;

namespace Orka.Tests.Network;
public class NetworkTests
{
    private readonly ITestOutputHelper _testOutputHelper;

    public NetworkTests(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
    }

    [Fact]
    internal async Task<SvcRspHttpServerList> SsoTests()
    {
        DeviceInfo deviceInfo = new DeviceManager().GetDefaultDevice();
        var httpClient = new HttpClient();
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
        catch(Exception e)
        {
            throw e;
            // ignored
        }

        byte[] dec = tea.Decrypt(body);
        var rspPacket = JceSerializer.Deserialize<RequestPacket>(dec[4..]);
        var data = JceSerializer.Deserialize<RequestDataVersion3>(rspPacket.SBuffer);
        if (data.Map["HttpServerListRes"] is byte[] res)
        {
            var serverList = JceSerializer.Deserialize<SvcRspHttpServerList>(res[1..^1]);
            _testOutputHelper.WriteLine(serverList.ToString());
            return serverList;
        }
        else
        {
            throw new Exception("Unable to fetch server list.");
        }
    }

    [Fact]
    private async Task<IPEndPoint[]> PingServerAsync()
    {
        var list = await SsoTests();
        Ping ping = new();
        var pinged = new List<dynamic>();
        foreach (SsoServerInfo ssoServerInfo in list.Servers)
        {
            PingReply pingReply = await ping.SendPingAsync(ssoServerInfo.Server);
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
        return sorted.Select(o => new IPEndPoint(o.Ip, o.Port)).ToArray();
    }
}
