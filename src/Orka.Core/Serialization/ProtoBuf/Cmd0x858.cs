using System.Collections.Generic;
using ProtoBuf;

namespace Orka.Core.Serialization.ProtoBuf;

[ProtoContract]
internal class Oidb0x858
{
    [ProtoContract]
    internal class GoldMsgTipsElem
    {
        [ProtoMember(1)] public int Type { get; set; }
        [ProtoMember(2)] public string Billno { get; set; }
        [ProtoMember(3)] public int Result { get; set; }
        [ProtoMember(4)] public int Amount { get; set; }
        [ProtoMember(5)] public int Total { get; set; }
        [ProtoMember(6)] public int Interval { get; set; }
        [ProtoMember(7)] public int Finish { get; set; }
        [ProtoMember(8)] public List<long> Uin { get; set; }
        [ProtoMember(9)] public int Action { get; set; }
    }

    [ProtoContract]
    internal class MessageRecallReminder
    {
        [ProtoMember(1)] public long Uin { get; set; }
        [ProtoMember(2)] public byte[] Nickname { get; set; }
        [ProtoMember(3)] public List<MessageMeta> RecalledMsgList { get; set; }
        [ProtoMember(4)] public byte[] ReminderContent { get; set; }
        [ProtoMember(5)] public byte[] Userdef { get; set; }

        [ProtoContract]
        internal class MessageMeta
        {
            [ProtoMember(1)] public int Seq { get; set; }
            [ProtoMember(2)] public int Time { get; set; }
            [ProtoMember(3)] public int MsgRandom { get; set; }
        }
    }

    [ProtoContract]
    internal class NotifyMsgBody
    {
        [ProtoMember(1)] public int OptEnumType { get; set; }
        [ProtoMember(2)] public long OptUint64MsgTime { get; set; }
        [ProtoMember(3)] public long OptUint64MsgExpires { get; set; }
        [ProtoMember(4)] public long OptUint64ConfUin { get; set; }
        [ProtoMember(5)] public RedGrayTipsInfo? OptMsgRedtips { get; set; }
        [ProtoMember(6)] public MessageRecallReminder? OptMsgRecallReminder { get; set; }
        [ProtoMember(7)] public NotifyObjmsgUpdate? OptMsgObjUpdate { get; set; }
        // @SerialId(8)] public optStcmGameState: ApolloGameStatus.STCMGameMessage? ,
        // @SerialId(9)] public aplloMsgPush: ApolloPushMsgInfo.STPushMsgElem? ,
        [ProtoMember(10)] public Oidb0x858.GoldMsgTipsElem? OptMsgGoldtips { get; set; }
    }

    [ProtoContract]
    internal class NotifyObjmsgUpdate
    {
        [ProtoMember(1)] public byte[] ObjmsgId { get; set; }
        [ProtoMember(2)] public int UpdateType { get; set; }
        [ProtoMember(3)] public byte[] ExtMsg { get; set; }
    }

    [ProtoContract]
    internal class RedGrayTipsInfo
    {
        [ProtoMember(1)] public int OptUint32ShowLastest { get; set; }
        [ProtoMember(2)] public long SenderUin { get; set; }
        [ProtoMember(3)] public long ReceiverUin { get; set; }
        [ProtoMember(4)] public byte[] SenderRichContent { get; set; }
        [ProtoMember(5)] public byte[] ReceiverRichContent { get; set; }
        [ProtoMember(6)] public byte[] Authkey { get; set; }
        [ProtoMember(7)] public int Sint32Msgtype { get; set; }
        [ProtoMember(8)] public int LuckyFlag { get; set; }
        [ProtoMember(9)] public int HideFlag { get; set; }
        [ProtoMember(10)] public byte[] PcBody { get; set; }
        [ProtoMember(11)] public int Icon { get; set; }
        [ProtoMember(12)] public long LuckyUin { get; set; }
        [ProtoMember(13)] public int Time { get; set; }
        [ProtoMember(14)] public int Random { get; set; }
        [ProtoMember(15)] public byte[] BroadcastRichContent { get; set; }
        [ProtoMember(16)] public byte[] Idiom { get; set; }
        [ProtoMember(17)] public int IdiomSeq { get; set; }
        [ProtoMember(18)] public byte[] IdiomAlpha { get; set; }
        [ProtoMember(19)] public byte[] Jumpurl { get; set; }
    }
}
