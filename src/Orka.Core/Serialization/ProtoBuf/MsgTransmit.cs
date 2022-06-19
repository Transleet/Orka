using System.Collections.Generic;
using ProtoBuf;

namespace Orka.Core.Serialization.ProtoBuf;

internal class MsgTransmit
{
    [ProtoContract]
    internal class PbMultiMsgItem
    {
        [ProtoMember(1)] public string FileName { get; set; }
        [ProtoMember(2)] public byte[] Buffer { get; set; }
    }

    [ProtoContract]
    internal class PbMultiMsgNew
    {
        [ProtoMember(1)] public List<MsgComm.Msg> Msg { get; set; }
    }

    [ProtoContract]
    internal class PbMultiMsgTransmit
    {
        [ProtoMember(1)] public List<MsgComm.Msg> Msg { get; set; }
        [ProtoMember(2)] public List<PbMultiMsgItem> PbItemList { get; set; }
    }
}
