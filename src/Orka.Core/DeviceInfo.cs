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
    public string Bootloader { get; set; }
    public string FingerPrint { get; set; }
    public string BootId { get; set; }
    public string ProcVersion { get; set; }
    public string BaseBand { get; set; }
    public byte[] SimInfo { get; set; }
    public string OSType { get; set; }
    public byte[] MacAddress { get; set; }
    public byte[] IpAddress { get; set; }
    public byte[] WifiBSSID { get; set; }
    public byte[] WifiSSID { get; set; }
    public byte[] IMSI { get; set; }
    public string IMEI { get; set; }
    public string AndroidId { get; set; }
    public byte[] APN { get; set; }
    public byte[] VendorName { get; set; }
    public byte[] VendorOSName { get; set; }
    public byte[] Guid { get; set; }
    public byte[] TgtgtKey { get; set; }
    public ApkInfo ApkInfo { get; set; }
    public Version Version { get; set; }
}

public class Version
{
    public string Incremental { get; set; }
    public string Release { get; set; }
    public string CodeName { get; set; }
    public uint Sdk { get; set; }
}
