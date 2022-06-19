using System.Collections.Generic;
using ProtoBuf;

namespace Orka.Core.Serialization.ProtoBuf;

internal class MsgRevokeUserDef  {
    [ProtoContract]
    internal class MsgInfoUserDef{
        [ProtoMember(1)] public  int LongMessageFlag { get; set; }
        [ProtoMember(2)] public  List<MsgInfoDef>  LongMsgInfo { get; set; }
        [ProtoMember(3)] public  List<string>  FileUuid { get; set; }
    }  
    [ProtoContract]
    internal class MsgInfoDef{
        [ProtoMember(1)] public  int  MsgSeq { get; set; }
        [ProtoMember(2)] public  int  LongMsgId { get; set; }
        [ProtoMember(3)] public  int  LongMsgNum { get; set; }
        [ProtoMember(4)] public  int  LongMsgIndex { get; set; }
    } 
    

    [ProtoContract]
    internal class UinTypeUserDef{
        [ProtoMember(1)] public  int FromUinType { get; set; }
        [ProtoMember(2)] public  long  FromGroupCode { get; set; }
        [ProtoMember(3)] public  List<string>  FileUuid { get; set; }
    } 
}
