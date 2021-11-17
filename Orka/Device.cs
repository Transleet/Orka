using System.Text.Json.Serialization;

namespace Orka;

public class ShortDevice
{
    [JsonPropertyName("product")]
    public string? Product { get; set; }
    [JsonPropertyName("device")]
    public string? Device { get; set; }
    [JsonPropertyName("board")]
    public string? Board { get; set; }
    [JsonPropertyName("brand")]
    public string? Brand { get; set; }
    [JsonPropertyName("model")]
    public string? Model { get; set; }
    [JsonPropertyName("wifiSsid")]
    public string? WifiSsid { get; set; }
    [JsonPropertyName("bootLoader")]
    public string? BootLoader { get; set; }
    [JsonPropertyName("androidId")]
    public string? AndroidId { get; set; }
    [JsonPropertyName("bootId")]
    public string? BootId { get; set; }
    [JsonPropertyName("procVersion")]
    public string? ProcVersion { get; set; }
    [JsonPropertyName("macAddress")]
    public string? MacAddress { get; set; }
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }
    [JsonPropertyName("imei")]
    public string? Imei { get; set; }
    [JsonPropertyName("incremental")]
    public uint Incremental { get; set; }
}

public class FullDevice : ShortDevice
{
    [JsonPropertyName("fingerprint")]
    public string? Fingerprint { get; set; }
    [JsonPropertyName("baseBand")]
    public string? BaseBand { get; set; }
    [JsonPropertyName("sim")]
    public string? Sim { get; set; }
    [JsonPropertyName("osType")]
    public string? OsType { get; set; }
    [JsonPropertyName("apn")]
    public string? Apn { get; set; }
    [JsonPropertyName("version")]
    public DeviceVersion? Version { get; set; }
    [JsonPropertyName("imsi")]
    public byte[]? Imsi { get; set; }
    [JsonPropertyName("guid")]
    public byte[]? Guid { get; set; }
    [JsonIgnore]
    public new uint Incremental { get; set; }
}

public class DeviceVersion
{
    [JsonPropertyName("incremental")]
    public uint Incremental { get; set; }
    [JsonPropertyName("release")]
    public string? Release { get; set; }
    [JsonPropertyName("codeName")]
    public string? CodeName { get; set; }
    [JsonPropertyName("sdk")]
    public int Sdk { get; set; }
}
