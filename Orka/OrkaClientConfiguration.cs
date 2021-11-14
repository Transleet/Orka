using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace Orka
{
    public class OrkaClientConfiguration
    {
        public LogLevel LogLevel { get; set; }
        public Platform Platform { get; set; }

        public bool IgnoreSelf { get; set; }
        public bool Resend { get; set; }
        public string? DataDirectory { get; set; }
        public int ReconnectionInterval { get; set; }
        public bool CacheGroupMember { get; set; }
        public bool AutoServer { get; set; }
    }
}
