using System.Text.Json.Serialization;

namespace Orka;

public class ShortDevice
{
    public string? Product { get; set; }
    public string? Device { get; set; }
    public string? Board { get; set; }
    public string? Brand { get; set; }
    public string? Model { get; set; }
    public string? WifiSsid { get; set; }
    public string? BootLoader { get; set; }
    public string? AndroidId { get; set; }
    public string? BootId { get; set; }
    public string? ProcVersion { get; set; }
    public string? MacAddress { get; set; }
    public string? IpAddress { get; set; }
    public string? Imei { get; set; }
    public uint Incremental { get; set; }
}

public class FullDevice : ShortDevice
{
    public string? Fingerprint { get; set; }
    public string? BaseBand { get; set; }
    public string? Sim { get; set; }
    public string? OsType { get; set; }
    public string? Apn { get; set; }
    public DeviceVersion? Version { get; set; }
    public byte[]? Imsi { get; set; }
    public byte[]? Guid { get; set; }
}

public class DeviceVersion
{ 
    public uint Incremental { get; set; }
    public string? Release { get; set; }
    public string? CodeName { get; set; }
    public int Sdk { get; set; }
}

[JsonSourceGenerationOptions(PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
    WriteIndented = true)]
[JsonSerializable(typeof(ShortDevice))]
internal partial class ShortDeviceContext : JsonSerializerContext
{
}

[JsonSourceGenerationOptions(PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
    WriteIndented = true)]
[JsonSerializable(typeof(FullDevice))]
internal partial class FullDeviceContext : JsonSerializerContext
{
}