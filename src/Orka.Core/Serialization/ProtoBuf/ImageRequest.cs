using ProtoBuf;

namespace Orka.Core.Serialization.ProtoBuf;

[ProtoContract]
internal class GetImgUrlReq
{
    [ProtoMember(1)] public int SrcUni { get; set; }
    [ProtoMember(2)] public int DstUni { get; set; }
    [ProtoMember(3)] public string FileResID { get; set; }
    [ProtoMember(4)] public int UrlFlag { get; set; }
    [ProtoMember(6)] public int UrlType { get; set; }
    [ProtoMember(7)] public int RequestTerm { get; set; }
    [ProtoMember(8)] public int RequestPlatformType { get; set; }
    [ProtoMember(9)] public int SrcFileType { get; set; }
    [ProtoMember(10)] public int InnerIP { get; set; }
    [ProtoMember(11)] public int AddressBook { get; set; }
    [ProtoMember(12)] public int BuType { get; set; }
    [ProtoMember(13)] public string BuildVer { get; set; }
    [ProtoMember(14)] public int Timestamp { get; set; }
    [ProtoMember(15)] public int RequestTransferType { get; set; }
}
