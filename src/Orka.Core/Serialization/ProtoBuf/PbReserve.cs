using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Orka.Core.Serialization.ProtoBuf;

internal class NotOnlineImage {
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
        [ProtoMember(16)] public  string  CameraCaptureTemplateinfo { get; set; }
        [ProtoMember(17)] public  string  CameraCaptureMaterialname { get; set; }
        [ProtoMember(18)] public  string  AdEmoJumpUrl { get; set; }
        [ProtoMember(19)] public  string  AdEmoDescStr { get; set; }
    } 
}

internal class CustomFace {
    [ProtoContract]
    internal class AnimationImageShow{
        [ProtoMember(1)] public  int  Int32EffectId { get; set; }
        [ProtoMember(2)] public  byte[]  AnimationParam { get; set; }
    } 

    [ProtoContract]
    internal class ResvAttr{
        [ProtoMember(1)] public  int  ImageBizType { get; set; }
        [ProtoMember(2)] public  int  CustomfaceType { get; set; }
        [ProtoMember(3)] public  int  EmojiPackageid { get; set; }
        [ProtoMember(4)] public  int  EmojiId { get; set; }
        [ProtoMember(5)] public  string  Text { get; set; }
        [ProtoMember(6)] public  string  DoutuSuppliers { get; set; }
        [ProtoMember(7)] public  AnimationImageShow?  MsgImageShow { get; set; }
        [ProtoMember(9)] public  byte[]  TextSummary { get; set; }
        [ProtoMember(10)] public  int  EmojiFrom { get; set; }
        [ProtoMember(11)] public  string  EmojiSource { get; set; }
        [ProtoMember(12)] public  string  EmojiWebUrl { get; set; }
        [ProtoMember(13)] public  string  EmojiIconUrl { get; set; }
        [ProtoMember(14)] public  string  EmojiMarketFaceName { get; set; }
        [ProtoMember(15)] public  int  Source { get; set; }
        [ProtoMember(16)] public  string  CameraCaptureTemplateinfo { get; set; }
        [ProtoMember(17)] public  string  CameraCaptureMaterialname { get; set; }
        [ProtoMember(18)] public  string  AdEmoJumpUrl { get; set; }
        [ProtoMember(19)] public  string  AdEmoDescStr { get; set; }
    } 
}

internal class Generalflags  {
    [ProtoContract]
    internal class ResvAttr{
        [ProtoMember(1)] public  int  GlobalGroupLevel { get; set; }
        [ProtoMember(2)] public  int  NearbyCharmLevel { get; set; }
        [ProtoMember(3)] public  long  RedbagMsgSenderUin { get; set; }
        [ProtoMember(4)] public  int  TitleId { get; set; }
        [ProtoMember(5)] public  int  RobotMsgFlag { get; set; }
        [ProtoMember(6)] public  long  WantGiftSenderUin { get; set; }
        [ProtoMember(7)] public  float  StickerX { get; set; }
        [ProtoMember(8)] public  float  StickerY { get; set; }
        [ProtoMember(9)] public  float  StickerWidth { get; set; }
        [ProtoMember(10)] public  float  StickerHeight { get; set; }
        [ProtoMember(11)] public  int  StickerRotate { get; set; }
        [ProtoMember(12)] public  long  StickerHostMsgseq { get; set; }
        [ProtoMember(13)] public  long  StickerHostMsguid { get; set; }
        [ProtoMember(14)] public  long  StickerHostTime { get; set; }
        [ProtoMember(15)] public  int  MobileCustomFont { get; set; }
        [ProtoMember(16)] public  int  TailKey { get; set; }
        [ProtoMember(17)] public  int  ShowTailFlag { get; set; }
        [ProtoMember(18)] public  int  DoutuMsgType { get; set; }
        [ProtoMember(19)] public  int  DoutuCombo { get; set; }
        [ProtoMember(20)] public  int  CustomFeatureid { get; set; }
        [ProtoMember(21)] public  int  GoldenMsgType { get; set; }
        [ProtoMember(22)] public  byte[]  GoldenMsgInfo { get; set; }
        [ProtoMember(23)] public  int  BotMessageClassId { get; set; }
        [ProtoMember(24)] public  byte[]  SubscriptionUrl { get; set; }
        [ProtoMember(25)] public  int  PendantDiyId { get; set; }
        [ProtoMember(26)] public  int  TimedMessage { get; set; }
        [ProtoMember(27)] public  int  HolidayFlag { get; set; }
        [ProtoMember(29)] public  byte[]  KplInfo { get; set; }
        [ProtoMember(30)] public  int  FaceId { get; set; }
        [ProtoMember(31)] public  int  DiyFontTimestamp { get; set; }
        [ProtoMember(32)] public  int  RedEnvelopeType { get; set; }
        [ProtoMember(33)] public  byte[]  ShortVideoId { get; set; }
        [ProtoMember(34)] public  int  ReqFontEffectId { get; set; }
        [ProtoMember(35)] public  int  LoveLanguageFlag { get; set; }
        [ProtoMember(36)] public  int  AioSyncToStoryFlag { get; set; }
        [ProtoMember(37)] public  int  UploadImageToQzoneFlag { get; set; }
        [ProtoMember(39)] public  byte[]  UploadImageToQzoneParam { get; set; }
        [ProtoMember(40)] public  byte[]  GroupConfessSig { get; set; }
        [ProtoMember(41)] public  long  SubfontId { get; set; }
        [ProtoMember(42)] public  int  MsgFlagType { get; set; }
        [ProtoMember(43)] public  List<int>  Uint32CustomFeatureid { get; set; }
        [ProtoMember(44)] public  int  RichCardNameVer { get; set; }
        [ProtoMember(47)] public  int  MsgInfoFlag { get; set; }
        [ProtoMember(48)] public  int  ServiceMsgType { get; set; }
        [ProtoMember(49)] public  int  ServiceMsgRemindType { get; set; }
        [ProtoMember(50)] public  byte[]  ServiceMsgName { get; set; }
        [ProtoMember(51)] public  int  VipType { get; set; }
        [ProtoMember(52)] public  int  VipLevel { get; set; }
        [ProtoMember(53)] public  byte[]  PbPttWaveform { get; set; }
        [ProtoMember(54)] public  int  UserBigclubLevel { get; set; }
        [ProtoMember(55)] public  int  UserBigclubFlag { get; set; }
        [ProtoMember(56)] public  int  Nameplate { get; set; }
        [ProtoMember(57)] public  int  AutoReply { get; set; }
        [ProtoMember(58)] public  int  ReqIsBigclubHidden { get; set; }
        [ProtoMember(59)] public  int  ShowInMsgList { get; set; }
        [ProtoMember(60)] public  byte[]  OacMsgExtend { get; set; }
        [ProtoMember(61)] public  int  GroupMemberFlagEx2 { get; set; }
        [ProtoMember(62)] public  int  GroupRingtoneId { get; set; }
        [ProtoMember(63)] public  byte[]  RobotGeneralTrans { get; set; }
        [ProtoMember(64)] public  int  TroopPobingTemplate { get; set; }
        [ProtoMember(65)] public  byte[]  HudongMark { get; set; }
        [ProtoMember(66)] public  int  GroupInfoFlagEx3 { get; set; }
    } 
}

[ProtoContract]
internal class ResvAttrForGiftMsg  {
    [ProtoContract]
    internal class ActivityGiftInfo{
        [ProtoMember(1)] public  int  IsActivityGift { get; set; }
        [ProtoMember(2)] public  string  TextColor { get; set; }
        [ProtoMember(3)] public  string  Text { get; set; }
        [ProtoMember(4)] public  string  Url { get; set; }
    } 

    [ProtoContract]
    internal class InteractGift{
        [ProtoMember(1)] public  byte[]  InteractId { get; set; }
    } 

    [ProtoContract]
    internal class ResvAttr{
        [ProtoMember(1)] public  int  Int32SendScore { get; set; }
        [ProtoMember(2)] public  int  Int32RecvScore { get; set; }
        [ProtoMember(3)] public  byte[]  CharmHeroism { get; set; }
        [ProtoMember(4)] public  int  ButtonFlag { get; set; }
        [ProtoMember(5)] public  int  ObjColor { get; set; }
        [ProtoMember(6)] public  int  AnimationType { get; set; }
        [ProtoMember(7)] public  InteractGift?  MsgInteractGift { get; set; }
        [ProtoMember(8)] public  ActivityGiftInfo?  ActivityGiftInfo { get; set; }
    } 
}

[ProtoContract]
internal class SourceMsg  {
    [ProtoContract]
    internal class ResvAttr{
        [ProtoMember(1)] public byte[]?  RichMsg2 { get; set; }
        [ProtoMember(2)] public  int?  OriMsgtype { get; set; }
        [ProtoMember(3)] public  List<long>?  OrigUids { get; set; }
    } 
}

[ProtoContract]
internal class VideoFile  {
    [ProtoContract]
    internal class ResvAttr{
        [ProtoMember(1)] public  byte[]  HotvideoIcon { get; set; }
        [ProtoMember(2)] public  byte[]  HotvideoTitle { get; set; }
        [ProtoMember(3)] public  byte[]  HotvideoUrl { get; set; }
        [ProtoMember(4)] public  byte[]  HotvideoIconSub { get; set; }
        [ProtoMember(5)] public  int  SpecialVideoType { get; set; }
        [ProtoMember(6)] public  byte[]  DynamicText { get; set; }
        [ProtoMember(7)] public  int  MsgTailType { get; set; }
        [ProtoMember(8)] public  int  RedEnvelopeType { get; set; }
        [ProtoMember(9)] public  byte[]  ShortVideoId { get; set; }
        [ProtoMember(10)] public  byte[]  AnimojiModelId { get; set; }
        [ProtoMember(11)] public  int  LongVideoKandianType { get; set; }
        [ProtoMember(12)] public  int  Source { get; set; }
    } 
}
