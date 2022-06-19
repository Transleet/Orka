using System.Collections.Generic;
using ProtoBuf;

namespace Orka.Core.Serialization.ProtoBuf;

[ProtoContract]
internal class Vec0xd50
{
    [ProtoContract]
    internal class ExtSnsFrdData
    {
        [ProtoMember(1)] public long FrdUin { get; set; }
        [ProtoMember(91001)] public byte[] MusicSwitch { get; set; }
        [ProtoMember(101001)] public byte[] MutualmarkAlienation { get; set; }
        [ProtoMember(141001)] public byte[] MutualmarkScore { get; set; }
        [ProtoMember(151001)] public byte[] KsingSwitch { get; set; }
        [ProtoMember(181001)] public byte[] LbsShare { get; set; }
    }

    [ProtoContract]
    internal class RspBody
    {
        [ProtoMember(1)] public List<ExtSnsFrdData> MsgUpdateData { get; set; }
        [ProtoMember(11)] public int Over { get; set; }
        [ProtoMember(12)] public int NextStart { get; set; }
        [ProtoMember(13)] public List<long> Uint64UnfinishedUins { get; set; }
    }

    [ProtoContract]
    internal class ReqBody
    {
        [ProtoMember(1)] public long Appid { get; set; }
        [ProtoMember(2)] public int MaxPkgSize { get; set; }
        [ProtoMember(3)] public int StartTime { get; set; }
        [ProtoMember(4)] public int StartIndex { get; set; }
        [ProtoMember(5)] public int ReqNum { get; set; }
        [ProtoMember(6)] public List<long> UinList { get; set; }
        [ProtoMember(91001)] public int ReqMusicSwitch { get; set; }
        [ProtoMember(101001)] public int ReqMutualmarkAlienation { get; set; }
        [ProtoMember(141001)] public int ReqMutualmarkScore { get; set; }
        [ProtoMember(151001)] public int ReqKsingSwitch { get; set; }
        [ProtoMember(181001)] public int ReqMutualmarkLbsshare { get; set; }
    }

    [ProtoContract]
    internal class KSingRelationInfo
    {
        [ProtoMember(1)] public int Flag { get; set; }
    }
}

[ProtoContract]
internal class Vec0xd6b
{
    [ProtoContract]
    internal class ReqBody
    {
        [ProtoMember(1)] public int MaxPkgSize { get; set; }
        [ProtoMember(2)] public int StartTime { get; set; }
        [ProtoMember(11)] public List<long> UinList { get; set; }
    }

    [ProtoContract]
    internal class RspBody
    {
        [ProtoMember(11)] public List<MutualMarkData> MsgMutualmarkData { get; set; }
        [ProtoMember(12)] public List<long> Uint64UnfinishedUins { get; set; }
    }

    [ProtoContract]
    internal class MutualMarkData
    {
        [ProtoMember(1)] public long FrdUin { get; set; }
        [ProtoMember(2)] public int Result { get; set; }
        // @SerialId(11)] public mutualmarkInfo: List<Mutualmark.MutualMark> = emptyList()
    }
}
