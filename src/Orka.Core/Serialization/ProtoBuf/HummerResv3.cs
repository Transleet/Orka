using ProtoBuf;

namespace Orka.Core.Serialization.ProtoBuf;

[ProtoContract]
internal class CustomFaceExtPb
{
    [ProtoContract]
    internal class AnimationImageShow
    {
        [ProtoMember(1)] public int Int32EffectId { get; set; }
        [ProtoMember(2)] public byte[] AnimationParam { get; set; }
    }

    [ProtoContract]
    internal class ResvAttr
    {
        [ProtoMember(1)] public int ImageBizType { get; set; }
        [ProtoMember(2)] public int CustomfaceType { get; set; }
        [ProtoMember(3)] public int EmojiPackageid { get; set; }
        [ProtoMember(4)] public int EmojiId { get; set; }
        [ProtoMember(5)] public string Text { get; set; }
        [ProtoMember(6)] public string DoutuSuppliers { get; set; }
        [ProtoMember(7)] public AnimationImageShow? MsgImageShow { get; set; }
        [ProtoMember(9)] public byte[] TextSummary { get; set; }
        [ProtoMember(10)] public int EmojiFrom { get; set; }
        [ProtoMember(11)] public string EmojiSource { get; set; }
        [ProtoMember(12)] public string EmojiWebUrl { get; set; }
        [ProtoMember(13)] public string EmojiIconUrl { get; set; }
        [ProtoMember(14)] public string EmojiMarketFaceName { get; set; }
        [ProtoMember(15)] public int Source { get; set; }
        [ProtoMember(16)] public string CameraCaptureTemplateinfo { get; set; }
        [ProtoMember(17)] public string CameraCaptureMaterialname { get; set; }
        [ProtoMember(18)] public string AdEmoJumpUrl { get; set; }
        [ProtoMember(19)] public string AdEmoDescStr { get; set; }
    }
}
