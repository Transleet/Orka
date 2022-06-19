using System;
using ProtoBuf;

namespace Orka.Core.Serialization.ProtoBuf;

[ProtoContract]
internal class MsgOnlinePush
{
    [ProtoContract]
    internal class PbPushMsg
    {
        [ProtoMember(1)] public MsgComm.Msg Msg { get; set; }
        [ProtoMember(2)] public int Svrip { get; set; }
        [ProtoMember(3)] public byte[] PushToken { get; set; }
        [ProtoMember(4)] public int PingFlag { get; set; }
        [ProtoMember(9)] public int GeneralFlag { get; set; }
    }
}

[ProtoContract]
internal class OnlinePushTrans
{
    [ProtoContract]
    internal class ExtGroupKeyInfo
    {
        [ProtoMember(1)] public int CurMaxSeq { get; set; }
        [ProtoMember(2)] public long CurTime { get; set; }
    }

    [ProtoContract]
    internal class PbMsgInfo
    {
        [ProtoMember(1)] public long FromUin { get; set; }
        [ProtoMember(2)] public long ToUin { get; set; }
        [ProtoMember(3)] public int MsgType { get; set; }
        [ProtoMember(4)] public int MsgSubtype { get; set; }
        [ProtoMember(5)] public int MsgSeq { get; set; }
        [ProtoMember(6)] public long MsgUid { get; set; }
        [ProtoMember(7)] public int MsgTime { get; set; }
        [ProtoMember(8)] public int RealMsgTime { get; set; }
        [ProtoMember(9)] public string NickName { get; set; }
        [ProtoMember(10)] public byte[] MsgData { get; set; }
        [ProtoMember(11)] public int SvrIp { get; set; }
        [ProtoMember(12)] public ExtGroupKeyInfo? ExtGroupKeyInfo { get; set; }
        [ProtoMember(17)] public int GeneralFlag { get; set; }
    }
}
