using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Orka.Core.Crypto;
using Orka.Core.Extensions;
using Orka.Core.Serialization.Jce;
using Orka.Core.Serialization.Jce.Structs;

namespace Orka.Core.Services;

internal class SocketService
{
    private readonly ILogger<SocketService> _logger;
    private readonly IHttpClientFactory _httpClientFactory;


    public SocketService(ILogger<SocketService> logger, IHttpClientFactory httpClientFactory)
    {
        _logger = logger;
        _httpClientFactory = httpClientFactory;
    }




}
