using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Orka.Core.Services.WtLogin;

[assembly: InternalsVisibleTo("Orka.Tests")]

namespace Orka.Core;

public partial class OrkaClient : IOrkaClient
{
    private readonly ILogger<OrkaClient> _logger;
    private IOptions<OrkaClientOptions> _options;
    private WtLoginService _wtLogin;

    public OrkaClient(IOptions<OrkaClientOptions> options, ILogger<OrkaClient> logger, WtLoginService wtLogin)
    {
        _logger = logger;
        _options = options;
        _wtLogin = wtLogin;
    }

    public async Task LoginAsync()
    {
        await _wtLogin.LoginAsync();
    }

    public event EventHandler MessageRecieved;
}
