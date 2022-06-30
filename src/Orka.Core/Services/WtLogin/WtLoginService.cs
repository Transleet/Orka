using System.Threading.Tasks;

using Microsoft.Extensions.Logging;

namespace Orka.Core.Services.WtLogin;

internal class WtLoginService
{
    private readonly WtLoginContext _context;
    private readonly ILogger<WtLoginService> _logger;
    private readonly NetworkService _networkService;

    public WtLoginService(WtLoginContext context, ILogger<WtLoginService> logger, NetworkService networkService)
    {
        _context = context;
        _logger = logger;
        _networkService = networkService;
    }

    public async Task LoginAsync()
    {
        if (_context.Status == WtLoginStatus.Online)
        {
            _logger.LogWarning("Can't login while bot is Online.");
            return;
        }

        _logger.LogInformation("Connecting server.");
        await _networkService.ConnectAsync();

    }
}
