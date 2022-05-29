using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace Orka.Core.Services.WtLogin;

public class WtLoginService
{
    private readonly WtLoginContext _context;
    private readonly ILogger<WtLoginService> _logger;

    public WtLoginService(WtLoginContext context, ILogger<WtLoginService> logger)
    {
        _context = context;
        _logger = logger;
    }

    public async Task LoginAsync()
    {
        if (_context.Status == WtLoginStatus.Online)
        {
            _logger.LogError("Can't login while bot is Online.");
            return;
        }

        _logger.LogInformation("Connecting server.");

    }
}
