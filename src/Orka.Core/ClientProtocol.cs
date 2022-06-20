namespace Orka.Core
{
    public class ClientProtocol
    {
        public string ApkId { get; set; }
        public uint AppId { get; set; }
        public uint SubAppId { get; set; }
        public uint BuildTime { get; set; }
        public uint SSOVersion { get; set; }
        public uint MiscBitmap { get; set; }
        public uint SubSigMap { get; set; }
        public uint MainSigMap { get; set; }
        public string SortVersionName { get; set; }
        public string SdkVersion { get; set; }
        public ClientProtocol Protocol { get; set; }
        public byte[] ApkSign { get; set; }

        static ClientProtocol()
        {
            AndroidPhone = new ClientProtocol()
            {
                ApkId = "com.tencent.mobileqq",
                AppId = 537066738,
                SubAppId = 537066738,
                SortVersionName = "8.5.0",
                BuildTime = 1607689988,
                ApkSign = new byte[] { 0xA6, 0xB7, 0x45, 0xBF, 0x24, 0xA2, 0xC2, 0x77, 0x52, 0x77, 0x16, 0xF6, 0xF3, 0x6E, 0xB6, 0x8D },
                SdkVersion = "6.0.0.2454",
                SSOVersion = 15,
                MiscBitmap = 184024956,
                SubSigMap = 0x10400,
                MainSigMap = 34869472
            };
            AndroidWatch = new ClientProtocol()
            {
                ApkId = "com.tencent.qqlite",
                AppId = 537064446,
                SubAppId = 537064446,
                SortVersionName = "2.0.5",
                BuildTime = 1559564731,
                ApkSign = new byte[] { 0xA6, 0xB7, 0x45, 0xBF, 0x24, 0xA2, 0xC2, 0x77, 0x52, 0x77, 0x16, 0xF6, 0xF3, 0x6E, 0xB6, 0x8D },
                SdkVersion = "6.0.0.236",
                SSOVersion = 5,
                MiscBitmap = 16252796,
                SubSigMap = 0x10400,
                MainSigMap = 34869472
            };
            Ipad = new ClientProtocol()
            {
                ApkId = "com.tencent.minihd.qq",
                AppId = 537065739,
                SubAppId = 537065739,
                SortVersionName = "5.8.9",
                BuildTime = 1595836208,
                ApkSign = new byte[] { 170, 57, 120, 244, 31, 217, 111, 249, 145, 74, 102, 158, 24, 100, 116, 199 },
                SdkVersion = "6.0.0.2433",
                SSOVersion = 12,
                MiscBitmap = 150470524,
                SubSigMap = 66560,
                MainSigMap = 1970400
            };
            Mac = new ClientProtocol()
            {
                ApkId = "com.tencent.minihd.qq",
                AppId = 537064315,
                SubAppId = 537064315,
                SortVersionName = "5.8.9",
                BuildTime = 1595836208,
                ApkSign = new byte[] { 170, 57, 120, 244, 31, 217, 111, 249, 145, 74, 102, 158, 24, 100, 116, 199 },
                SdkVersion = "6.0.0.2433",
                SSOVersion = 12,
                MiscBitmap = 150470524,
                SubSigMap = 66560,
                MainSigMap = 1970400
            };
            QiDian = new ClientProtocol()
            {
                ApkId = "com.tencent.qidian",
                AppId = 537061386,
                SubAppId = 537036590,
                SortVersionName = "3.8.6",
                BuildTime = 1556628836,
                ApkSign = new byte[] { 160, 30, 236, 171, 133, 233, 227, 186, 43, 15, 106, 21, 140, 133, 92, 41 },
                SdkVersion = "6.0.0.2365",
                SSOVersion = 5,
                MiscBitmap = 49807228,
                SubSigMap = 66560,
                MainSigMap = 34869472
            };
        }

        public static ClientProtocol AndroidPhone { get; set; }
        public static ClientProtocol AndroidWatch { get; set; }
        public static ClientProtocol Ipad { get; set; }
        public static ClientProtocol Mac { get; set; }
        public static ClientProtocol QiDian { get; set; }
    }
}
