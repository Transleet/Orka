using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Orka.Services;

[assembly: InternalsVisibleTo("Orka.Tests")]

namespace Orka;

public partial class OrkaClient : IOrkaClient
{
    private IOptions<OrkaClientOptions> _options;
    private ILogger<OrkaClient> _logger;
    private WtLoginService _wtLogin;

    public OrkaClient(
        IOptions<OrkaClientOptions> options,
        ILogger<OrkaClient> logger,
        WtLoginService wtLogin)
    {
        _options = options;
        _logger = logger;
        _wtLogin = wtLogin;
    }

    public async Task LoginAsync()
    {
        await _wtLogin.LoginAsync();
    }

}
