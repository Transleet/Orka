using System;
using ProtoBuf;

namespace Orka.Core.Serialization.ProtoBuf
{
    [ProtoContract]
    internal class SyncCookie{
        [ProtoMember(1)] public  Long?  Time1 { get; set; }
        [ProtoMember(2)] public  long Time { get; set; }
        [ProtoMember(3)] public  long  Unknown1 { get; set; }
        [ProtoMember(4)] public  long  Unknown2 { get; set; }
        [ProtoMember(5)] public  long  Const1 { get; set; }
        [ProtoMember(11)] public  long  Const2 { get; set; }
        [ProtoMember(12)] public  long  Unknown3 { get; set; }
        [ProtoMember(13)] public  Long?  LastSyncTime { get; set; }
        [ProtoMember(14)] public  long  Unknown4 { get; set; }
    }
} 

private val const1_: long = Random.nextLong().absoluteValue
private val const2_: long = Random.nextLong().absoluteValue


/*

[ProtoContract]
internal class SyncCookie{
    @SerialId(1)] public time1: Long? , // 1580277992
    @SerialId(2)] public time: Long, // 1580277992
    @SerialId(3)] public unknown1: long = 678328038,// 678328038
    @SerialId(4)] public unknown2: long = 1687142153, // 1687142153
    @SerialId(5)] public const1: long = 1458467940, // 1458467940
    @SerialId(11)] public const2: long = 2683038258, // 2683038258
    @SerialId(12)] public unknown3: long = 0x1d,
    @SerialId(13)] public lastSyncTime: Long? ,
    @SerialId(14)] public unknown4: long = 0
} 
 */
