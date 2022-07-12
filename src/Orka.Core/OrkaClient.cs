using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Org.BouncyCastle.Asn1.Cms;
using Orka.Core.Crypto;
using Orka.Core.Extensions;
using Orka.Core.Packets;
using Orka.Core.Services;

[assembly: InternalsVisibleTo("Orka.Tests")]

namespace Orka.Core;

internal class OrkaClient : IOrkaClient
{
    private readonly ILogger<OrkaClient> _logger;
    private IOptions<OrkaClientOptions> _options;
    private readonly NetworkService _networkService;

    public OrkaClient(ILogger<OrkaClient> logger, IOptions<OrkaClientOptions> options, NetworkService networkService)
    {
        _logger = logger;
        _options = options;
        _networkService = networkService;
    }

    public Uin Uin { get; set; }

    public byte[] HashedPassword { get; set; }

    public Ecdh Ecdh { get; } = new();
    public DeviceInfo DeviceInfo { get; private set; }
    public SigInfo SigInfo { get; } = new()
    {
        SeqId = (uint)Random.Shared.NextInt64(0, uint.MaxValue),
        Session = Random.Shared.GetRandomBytes(4),
        RandomKey = Random.Shared.GetRandomBytes(16),
        Tgtgt = Random.Shared.GetRandomBytes(16),
        Tgt = Array.Empty<byte>(),
        SKey = Array.Empty<byte>(),
        D2 = Array.Empty<byte>(),
        D2Key = Array.Empty<byte>(),
        T104 = Array.Empty<byte>(),
        T174 = Array.Empty<byte>(),
        QRSig = Array.Empty<byte>(),
    };


    public async Task LoginAsync()
    {

    }

    public async Task LoginWithPasswordAsync(DeviceInfo deviceInfo)
    {
        Uin = new Uin(_options.Value.Uin!);
        HashedPassword = MD5.HashData(Encoding.UTF8.GetBytes(_options.Value.Password!));
        DeviceInfo = deviceInfo;
        await _networkService.ConnectAsync(deviceInfo);
        SigInfo.NextSeqId();
        var pkt = Packet.BuildLoginPacket(this, LoginCommand.WtLoginLogin, stream =>
        {
            stream.Write(Number.FromUInt16(9));
            stream.Write(Number.FromUInt16(23));
            stream.Write(Tlv.T18(Uin, deviceInfo.ApkInfo));
            stream.Write(Tlv.T1(Uin));
            stream.Write(Tlv.T106(Uin, deviceInfo, deviceInfo.ApkInfo, SigInfo, HashedPassword));
            stream.Write(Tlv.T116(deviceInfo.ApkInfo));
            stream.Write(Tlv.T100(deviceInfo.ApkInfo));
            stream.Write(Tlv.T107());
            stream.Write(Tlv.T142(deviceInfo.ApkInfo));
            stream.Write(Tlv.T144(deviceInfo, SigInfo));
            stream.Write(Tlv.T145(deviceInfo));
            stream.Write(Tlv.T147(deviceInfo.ApkInfo));
            stream.Write(Tlv.T154(SigInfo));
            stream.Write(Tlv.T141(deviceInfo));
            stream.Write(Tlv.T8());
            stream.Write(Tlv.T511());
            stream.Write(Tlv.T187(deviceInfo));
            stream.Write(Tlv.T188(deviceInfo));
            stream.Write(Tlv.T194(deviceInfo));
            stream.Write(Tlv.T191());
            stream.Write(Tlv.T202(deviceInfo));
            stream.Write(Tlv.T177(deviceInfo.ApkInfo));
            stream.Write(Tlv.T516());
            stream.Write(Tlv.T521());
            stream.Write(Tlv.T525());
        });
        await _networkService.SendLoginPacketAsync(pkt);
    }

}
