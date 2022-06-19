using System.Collections.Generic;
using ProtoBuf;

namespace Orka.Core.Serialization.ProtoBuf;

[ProtoContract]
internal class MarketFaceExtPb
{
    [ProtoContract]
    internal class ResvAttr
    {
        [ProtoMember(1)] public List<SupportSize> SupportSize { get; set; }
        [ProtoMember(2)] public int SourceType { get; set; }
        [ProtoMember(3)] public string SourceName { get; set; }
        [ProtoMember(4)] public string SourceJumpUrl { get; set; }
        [ProtoMember(5)] public string SourceTypeName { get; set; }
        [ProtoMember(6)] public int StartTime { get; set; }
        [ProtoMember(7)] public int EndTime { get; set; }
        [ProtoMember(8)] public int EmojiType { get; set; }
        [ProtoMember(9)] public List<SupportSize> ApngSupportSize { get; set; }
        [ProtoMember(10)] public int HasIpProduct { get; set; }
    }

    [ProtoContract]
    internal class SupportSize
    {
        [ProtoMember(1)] public int Width { get; set; }
        [ProtoMember(2)] public int Height { get; set; }
    }
}
