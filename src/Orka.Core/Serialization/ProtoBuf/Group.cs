using System.Collections.Generic;
using ProtoBuf;

namespace Orka.Core.Serialization.ProtoBuf;

[ProtoContract]
internal class GroupLabel
{
    [ProtoContract]
    internal class Label
    {
        [ProtoMember(1)] public byte[] Name { get; set; }
        [ProtoMember(2)] public int EnumType { get; set; }
        [ProtoMember(3)] public Color? TextColor { get; set; }
        [ProtoMember(4)] public Color? EdgingColor { get; set; }
        [ProtoMember(5)] public int LabelAttr { get; set; }
        [ProtoMember(6)] public int LabelType { get; set; }
    }

    [ProtoContract]
    internal class RspBody
    {
        [ProtoMember(1)] public byte[] Error { get; set; }
        [ProtoMember(2)] public List<GroupInfo> GroupInfo { get; set; }
    }

    [ProtoContract]
    internal class SourceId
    {
        [ProtoMember(1)] public int SourceId1 { get; set; }
    }

    [ProtoContract]
    internal class GroupInfo
    {
        [ProtoMember(1)] public int Int32Result { get; set; }
        [ProtoMember(2)] public long GroupCode { get; set; }
        [ProtoMember(3)] public List<Label> GroupLabel { get; set; }
    }

    [ProtoContract]
    internal class Color
    {
        [ProtoMember(1)] public int R { get; set; }
        [ProtoMember(2)] public int G { get; set; }
        [ProtoMember(3)] public int B { get; set; }
    }

    [ProtoContract]
    internal class ReqBody
    {
        [ProtoMember(1)] public SourceId? SourceId { get; set; }
        [ProtoMember(2)] public UinInfo? UinInfo { get; set; }
        [ProtoMember(3)] public int NumberLabel { get; set; }
        [ProtoMember(4)] public List<long> GroupCode { get; set; }
        [ProtoMember(5)] public int LabelStyle { get; set; }
    }

    [ProtoContract]
    internal class UinInfo
    {
        [ProtoMember(1)] public long Int64Longitude { get; set; }
        [ProtoMember(2)] public long Int64Latitude { get; set; }
    }
}
