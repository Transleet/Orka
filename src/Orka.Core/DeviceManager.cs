using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Orka.Core.Extensions;

namespace Orka.Core
{
    internal class DeviceManager
    {
        private static DeviceInfo s_default = new()
        {
            Display = Encoding.UTF8.GetBytes("Orka.114514.810"),
            Product = Encoding.UTF8.GetBytes("Orka"),
            Device = Encoding.UTF8.GetBytes("Orka"),
            Board = Encoding.UTF8.GetBytes("Orka"),
            Brand = Encoding.UTF8.GetBytes("Orka"),
            Model = Encoding.UTF8.GetBytes("Orka"),
            Bootloader = Encoding.UTF8.GetBytes("unknown"),
            FingerPrint = Encoding.UTF8.GetBytes("Orka:10/Orka.114514.810/114514:user/release-keys"),
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
            AndroidId = Encoding.UTF8.GetBytes("Orka.123456.001"),
            APN = Encoding.UTF8.GetBytes("wifi"),
            VendorName = Encoding.UTF8.GetBytes("Orka"),
            VendorOSName = Encoding.UTF8.GetBytes("Orka"),
            Protocol = ClientProtocol.Ipad,
            Guid = System.Guid.NewGuid().ToByteArray(),
            TgtgtKey = MD5.HashData(Random.Shared.GetRandomBytes(16)),
            IMSIMd5 = MD5.HashData(Encoding.UTF8.GetBytes("468356291846738")),
            Version = new Version
            {
                Incremental = Encoding.UTF8.GetBytes("5891938"),
                Release = Encoding.UTF8.GetBytes("10"),
                CodeName = Encoding.UTF8.GetBytes("REL"),
                Sdk = 29,
            }
        };
        public DeviceInfo GetDefaultDevice() => s_default;
    }
}
