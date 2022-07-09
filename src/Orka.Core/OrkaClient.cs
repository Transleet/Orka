using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Org.BouncyCastle.Asn1.Cms;
using Orka.Core.Extensions;
using Orka.Core.Services;

[assembly: InternalsVisibleTo("Orka.Tests")]

namespace Orka.Core;

internal class OrkaClient : IOrkaClient
{
    private readonly ILogger<OrkaClient> _logger;
    private IOptions<OrkaClientOptions> _options;
    private readonly NetworkService _networkService;

    public Uin Uin { get; set; }

    public byte[] HashedPassword { get; set; }

    public SigInfo SigInfo { get; } = new()
    {
        SequenceId = (uint)Random.Shared.NextInt64(0, uint.MaxValue),
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

    public OrkaClient(ILogger<OrkaClient> logger, IOptions<OrkaClientOptions> options, NetworkService networkService)
    {
        _logger = logger;
        _options = options;
        _networkService = networkService;
    }

    public async Task LoginAsync()
    {
        Uin = new Uin(_options.Value.Uin!);
        HashedPassword = MD5.HashData(Encoding.UTF8.GetBytes(_options.Value.Password!));
        await _networkService.ConnectAsync();
        await _networkService.SendLoginPacketAsync(this);
    }

}
