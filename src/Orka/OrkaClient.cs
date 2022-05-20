using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.Extensions.Options;
using Orka.Services;
using ProtoBuf;

[assembly: InternalsVisibleTo("Orka.Tests")]

namespace Orka;

public partial class OrkaClient : IOrkaClient
{
    private IOptions<OrkaClientOptions> _options;
    private ILogger<OrkaClient> _logger;
    private WtLoginService _wtLogin;

    public OrkaClient(IOptions<OrkaClientOptions> options, ILogger<OrkaClient> logger, WtLoginService wtLogin)
    {
        _options = options;
        _logger = logger;
        _wtLogin = wtLogin;
    }

    public async Task LoginAsync()
    {
        _logger.LogInformation("Start login");
        await _wtLogin.LoginAsync();
    }

}
