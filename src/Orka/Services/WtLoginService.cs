using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace Orka.Services;

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
        _logger.LogInformation("Start WtLogin");
    }
}
