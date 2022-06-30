using System;
using System.Security.Cryptography;
using System.Text;

using Orka.Core.Extensions;
using Orka.Core.Serialization.ProtoBuf;

namespace Orka.Core;

public class DeviceInfo
{

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

    public void GenerateRandomDeviceInfo()
    {
        throw new NotImplementedException();
    }


}
