using Microsoft.Extensions.Logging;

namespace Orka;

public class OrkaClientConfiguration
{
    public static readonly OrkaClientConfiguration Default = new OrkaClientConfiguration
    {
        IgnoreSelf = true,
        CacheGroupMember = true,
        AutoServer = true,
        ReconnectionInterval = 5,
        Resend = true,
        LogLevel = LogLevel.Information,
        Platform = Platform.Android,
        DataDirectory = Path.Combine(Directory.GetCurrentDirectory(), "Orka", "data")
    };

    public LogLevel LogLevel { get; set; }
    public Platform Platform { get; set; }

    public bool IgnoreSelf { get; set; }
    public bool Resend { get; set; }
    public string? DataDirectory { get; set; }
    public int ReconnectionInterval { get; set; }
    public bool CacheGroupMember { get; set; }
    public bool AutoServer { get; set; }
}
