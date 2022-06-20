using System;
using System.Security.Cryptography;
using System.Text;

using Orka.Core.Extensions;
using Orka.Core.Serialization.ProtoBuf;

namespace Orka.Core
{
    public class DeviceInfo
    {
        static DeviceInfo()
        {
            byte[] buffer = Random.Shared.GetRandomBytes(16);
            Default = new DeviceInfo()
            {
                Display = Encoding.UTF8.GetBytes("BotReborn.114514.810"),
                Product = Encoding.UTF8.GetBytes("BotReborn"),
                Device = Encoding.UTF8.GetBytes("BotReborn"),
                Board = Encoding.UTF8.GetBytes("BotReborn"),
                Brand = Encoding.UTF8.GetBytes("BotReborn"),
                Model = Encoding.UTF8.GetBytes("BotReborn"),
                Bootloader = Encoding.UTF8.GetBytes("unknown"),
                FingerPrint = Encoding.UTF8.GetBytes("BotReborn:10/BotReborn.114514.810/114514:user/release-keys"),
                BootId = Encoding.UTF8.GetBytes("cb886ae2-00b6-4d68-a230-787f111d12c7"),
                ProcVersion = Encoding.UTF8.GetBytes("Linux version 3.0.31-cb886ae2 (android-build@xxx.xxx.xxx.xxx.com)"),
                BaseBand = Array.Empty<byte>(),
                SimInfo = Encoding.UTF8.GetBytes("T-Mobile"),
                OSType = Encoding.UTF8.GetBytes("android"),
                MacAddress = Encoding.UTF8.GetBytes("00:50:56:C0:00:08"),
                IpAddress = new byte[] { 10, 0, 1, 3 }, // 10.0.1.3
                WifiBSSID = Encoding.UTF8.GetBytes("00:50:56:C0:00:08"),
                WifiSSID = Encoding.UTF8.GetBytes("<unknown ssid>"),
                IMEI = "468356291846738",
                AndroidId = Encoding.UTF8.GetBytes("MIRAI.123456.001"),
                APN = Encoding.UTF8.GetBytes("wifi"),
                VendorName = Encoding.UTF8.GetBytes("MIUI"),
                VendorOSName = Encoding.UTF8.GetBytes("bot"),
                Protocol = ClientProtocol.Ipad,
                Guid = System.Guid.NewGuid().ToByteArray(),
                TgtgtKey = MD5.HashData(buffer),
                IMSIMd5 = MD5.HashData(Encoding.UTF8.GetBytes("468356291846738")),
                Version = new Version()
                {
                    Incremental = Encoding.UTF8.GetBytes("5891938"),
                    Release = Encoding.UTF8.GetBytes("10"),
                    CodeName = Encoding.UTF8.GetBytes("REL"),
                    Sdk = 29,
                }
            };
            Current = Default;
        }
        public byte[] Display { get; set; }
        public byte[] Product { get; set; }
        public byte[] Device { get; set; }
        public byte[] Board { get; set; }
        public byte[] Brand { get; set; }
        public byte[] Model { get; set; }
        public byte[] Bootloader { get; set; }
        public byte[] FingerPrint { get; set; }
        public byte[] BootId { get; set; }
        public byte[] ProcVersion { get; set; }
        public byte[] BaseBand { get; set; }
        public byte[] SimInfo { get; set; }
        public byte[] OSType { get; set; }
        public byte[] MacAddress { get; set; }
        public byte[] IpAddress { get; set; }
        public byte[] WifiBSSID { get; set; }
        public byte[] WifiSSID { get; set; }
        public byte[] IMSIMd5 { get; set; }
        public string IMEI { get; set; }
        public byte[] AndroidId { get; set; }
        public byte[] APN { get; set; }
        public byte[] VendorName { get; set; }
        public byte[] VendorOSName { get; set; }
        public byte[] Guid { get; set; }
        public byte[] TgtgtKey { get; set; }
        public ClientProtocol Protocol { get; set; }
        public Version Version { get; set; }

        public static DeviceInfo Default { get; }

        public static DeviceInfo Current { get; set; }

        public void GenerateRandomDeviceInfo()
        {
            throw new NotImplementedException();
        }


    }
}
