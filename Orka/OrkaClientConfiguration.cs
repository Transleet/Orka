using Microsoft.Extensions.Logging;

namespace Orka
{
    public class OrkaClientConfiguration
    {
        public LogLevel LogLevel { get; set; } = LogLevel.Information;
        public Platform Platform { get; set; } = Platform.Android;

        public bool IgnoreSelf { get; set; } = true;
        public bool Resend { get; set; } = true;
        public string? DataDirectory { get; set; }
        public int ReconnectionInterval { get; set; } = 5;
        public bool CacheGroupMember { get; set; } = true;
        public bool AutoServer { get; set; } = true;

        public static readonly OrkaClientConfiguration DefaultConfiguration = new();
    }
}
