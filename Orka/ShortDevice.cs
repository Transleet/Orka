using System.Text.Json.Serialization;

namespace Orka;

public class ShortDevice
{
    public string Product { get; set; }
    public string Device { get; set; }
    public string Board { get; set; }
    public string Brand { get; set; }
    public string Model { get; set; }
    public string WifiSsid { get; set; }
    public string BootLoader { get; set; }
    public string AndroidId { get; set; }
    public string BootId { get; set; }
    public string ProcVersion { get; set; }
    public string MacAddress { get; set; }
    public string IpAddress { get; set; }
    public string Imei { get; set; }
    public uint Incremental { get; set; }
}

[JsonSourceGenerationOptions(PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
    WriteIndented = true)]
[JsonSerializable(typeof(ShortDevice))]
internal partial class ShortDeviceContext : JsonSerializerContext
{
}