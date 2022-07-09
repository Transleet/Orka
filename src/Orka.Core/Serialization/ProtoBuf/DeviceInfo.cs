using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace Orka.Core.Serialization.ProtoBuf
{
    [ProtoContract]
    internal class DeviceInfo
    {
        [ProtoMember(1)] public string Bootloader { get; set; }
        [ProtoMember(2)] public string ProcVersion { get; set; }
        [ProtoMember(3)] public string Codename { get; set; }
        [ProtoMember(4)] public string Incremental { get; set; }
        [ProtoMember(5)] public string Fingerprint { get; set; }
        [ProtoMember(6)] public string BootId { get; set; }
        [ProtoMember(7)] public string AndroidId { get; set; }
        [ProtoMember(8)] public string BaseBand { get; set; }
        [ProtoMember(9)] public string InnerVersion { get; set; }
    }
}
