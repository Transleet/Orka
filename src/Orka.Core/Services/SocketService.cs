using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Runtime.Intrinsics.X86;
using System.Threading.Tasks;

using Microsoft.Extensions.Logging;

using Orka.Core.Crypto;
using Orka.Core.Serialization.Jce;
using Orka.Core.Serialization.Jce.Structs;

namespace Orka.Core.Services;

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

    private async Task<IPEndPoint> GetServerListAsync(DeviceInfo deviceInfo)
    {
        _logger.LogInformation("Fetching server list...");
        var key = (byte[])Convert.FromHexString("F0441F5FF42DA58FDCF7949ABA62D411");
        var protocol = deviceInfo.Protocol;
        var payload = new SvcReqHttpServerListReq(0, 0, 1, "00000", 100, (int)protocol.AppId, deviceInfo.IMEI, 0, 0, 0, 0, 0, 0, 1);
        var buf = new RequestDataVersion3() { Map = new JceMap() { ["HttpServerListReq"] = Utils.PackUniRequestData(JceSerializer.Serialize(payload)) } };
        var pkt = new RequestPacket()
        {
            IVersion = 3,
            SServantName = "ConfigHttp",
            SFuncName = "HttpServerListReq",
            SBuffer = JceSerializer.Serialize(buf)
        };
        var tea = new Tea(key);
        byte[] reqData = tea.Encrypt(new BinaryStream().WriteIntLvPacket(0, JceSerializer.Serialize(pkt)).ToArray());
        byte[] rsp;
        try
        {
            rsp = await (await new HttpClient().PostAsync("https://configsvr.msf.3g.qq.com/configsvr/serverlist.jsp",
                new ByteArrayContent(reqData))).Content.ReadAsByteArrayAsync();
        }
        catch (Exception e)
        {
            _logger.LogTrace(e, e.Message);
            throw new Exception("Unable to fetch server list.");
        }

        byte[] dec = tea.Decrypt(rsp);
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
