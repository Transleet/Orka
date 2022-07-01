using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Orka.Core.Services.WtLogin;

[assembly: InternalsVisibleTo("Orka.Tests")]

namespace Orka.Core;

internal class OrkaClient : IOrkaClient
{
    private readonly ILogger<OrkaClient> _logger;
    private IOptions<OrkaClientOptions> _options;
    private readonly WtLoginService _wtLoginService;

    public OrkaClient(IOptions<OrkaClientOptions> options, ILogger<OrkaClient> logger, WtLoginService wtLoginService)
    {
        _logger = logger;
        _options = options;
        _wtLoginService = wtLoginService;
    }

    public async Task LoginAsync()
    {
        await _wtLoginService.LoginAsync();
    }

}
