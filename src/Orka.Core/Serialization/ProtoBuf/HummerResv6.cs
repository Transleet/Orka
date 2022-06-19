using ProtoBuf;

namespace Orka.Core.Serialization.ProtoBuf;

[ProtoContract]
internal class NotOnlineImageExtPb  {
    [ProtoContract]
    internal class ResvAttr{
        [ProtoMember(1)] public  int  ImageBizType { get; set; }
        [ProtoMember(2)] public  int  CustomfaceType { get; set; }
        [ProtoMember(3)] public  int  EmojiPackageid { get; set; }
        [ProtoMember(4)] public  int  EmojiId { get; set; }
        [ProtoMember(5)] public  string  Text { get; set; }
        [ProtoMember(6)] public  string  DoutuSuppliers { get; set; }
        [ProtoMember(8)] public  byte[]  TextSummary { get; set; }
        [ProtoMember(10)] public  int  EmojiFrom { get; set; }
        [ProtoMember(11)] public  string  EmojiSource { get; set; }
        [ProtoMember(12)] public  string  EmojiWebUrl { get; set; }
        [ProtoMember(13)] public  string  EmojiIconUrl { get; set; }
        [ProtoMember(14)] public  string  EmojiMarketFaceName { get; set; }
        [ProtoMember(15)] public  int  Source { get; set; }
    } , ImgExtPbResvAttrCommon
}
