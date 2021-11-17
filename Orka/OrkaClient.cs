using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;

using Microsoft.Extensions.Logging;

using ProtoBuf;

namespace Orka;

public partial class OrkaClient
{
    private OrkaClientConfiguration _config;
    private string _dir;
    private Logger<OrkaClient> _logger; //TODO Add a way to add a logger.
    private Ecdh _ecdh = new();
    private byte[]? _password;
    private Sig _sig;
    private Uin _uin;

#pragma warning disable CS8618
    private OrkaClient()
#pragma warning restore CS8618
    {
    }

    public static OrkaClient Create(Uin uin, OrkaClientConfiguration? configuration = null)
    {
        OrkaClient client = new();
        OrkaClientConfiguration config = configuration ?? OrkaClientConfiguration.Default;
        var sig = new Sig
        {
            Seq = Number.ToUInt32(Random.Shared.GetRandomBytes(4)) & 0xfff,
            Session = Random.Shared.GetRandomBytes(4),
            RandomKey = Random.Shared.GetRandomBytes(16),
            Tgtgt = Random.Shared.GetRandomBytes(16),
            Tgt = Array.Empty<byte>(),
            SKey = Array.Empty<byte>(),
            D2 = Array.Empty<byte>(),
            D2Key = Array.Empty<byte>(),
            T104 = Array.Empty<byte>(),
            T174 = Array.Empty<byte>(),
            QrSig = Array.Empty<byte>(),
            BigData = new BigData()
            {
                IPEndPoint = new IPEndPoint(IPAddress.Any, 0),
                SigSession = Array.Empty<byte>(),
                SessionKey = Array.Empty<byte>()
            },
            EmpTime = 0
        };
        client._dir = InitializeDirectories(config.DataDirectory, uin);
        client._config = config;
        client._uin = uin;
        client._sig = sig;
        return client;
    }

    /// <summary>
    /// Login with stored token.
    /// </summary>
    /// <returns></returns>
    public async Task LoginAsync()
    {
        byte[] token = await File.ReadAllBytesAsync(Path.Combine(_dir, "token"));
        BinaryStream stream = new BinaryStream();
        stream.WriteUInt16(11)
            .WriteUInt16(16)
            ;
        //TODO add tlv
        //TODO token login
    }

    public async Task LoginAsync(byte[] passwordMd5)
    {
        //check agument null of add a overload
        _password = passwordMd5;
        if (_password is not null)
        {
        }
    }

    private static string InitializeDirectories(string? dataDirectory, Uin uin)
    {
        if (dataDirectory == null)
        {
            throw new ArgumentNullException(nameof(dataDirectory));
        }

        if (!Directory.Exists(dataDirectory))
        {
            Directory.CreateDirectory(dataDirectory);
        }

        if (!Directory.Exists(Path.Combine(dataDirectory, "devices")))
        {
            Directory.CreateDirectory(Path.Combine(dataDirectory, "devices"));
        }

        string uinPath = Path.Combine(dataDirectory, uin.ToString());
        if (!Directory.Exists(Path.Combine(dataDirectory, uin.ToString())))
        {
            Directory.CreateDirectory(uinPath);
        }

        return uinPath;
    }

    public async Task<ShortDevice> InitShortDevice()
    {
        if (File.Exists(Path.Combine(_config.DataDirectory!, "devices", $"{_uin}.json")))
        {
            string file = await File.ReadAllTextAsync("");
            return JsonSerializer.Deserialize(file, ShortDeviceContext.Default.ShortDevice) ??
                   throw new FormatException();
        }

        ShortDevice shortDevice = new ShortDevice();
        FileStream fs = File.OpenWrite(Path.Combine(_config.DataDirectory!, "devices", $"{_uin}.json"));
        Utf8JsonWriter writer = new Utf8JsonWriter(fs);
        ShortDeviceContext.Default.ShortDevice.SerializeHandler?.Invoke(writer, shortDevice);
        await writer.FlushAsync();
        return shortDevice;
    }

    public static FullDevice GenerateFullDevice(Uin uin) => GenerateFullDevice(GenerateShortDevice(uin));

    public static FullDevice GenerateFullDevice(ShortDevice sd)
    {
        if (sd is null)
        {
            throw new NullReferenceException();
        }

        FullDevice f = (sd as FullDevice)!;
        f.Fingerprint = $"{f.Brand}/{f.Product}/{f.Device}:10/{f.AndroidId}/{f.Incremental}:user/release-keys";
        f.BaseBand = "";
        f.Sim = "T-Mobile";
        f.OsType = "android";
        f.Apn = "wifi";
        f.Version = new DeviceVersion { Incremental = f.Incremental, Release = "10", CodeName = "REL", Sdk = 29 };

        return f;
    }

    public static ShortDevice GenerateShortDevice(Uin uin)
    {
        byte[] md5 = MD5.HashData(Encoding.UTF8.GetBytes(uin.ToString()));
        string hex = string.Concat(md5.Select(v => v.ToString("X2")));

        string GenerateImei(Uin uin)
        {
            string imei = uin % 2 == 1 ? "86" : "35";
            byte[] buf = Number.FromUInt32(uin);

            string CalcSP(string imei)
            {
                int sum = 0;
                for (int i = 0; i < imei.Length; i++)
                {
                    if (i % 2 == 1)
                    {
                        int j = int.Parse(imei[i].ToString()) * 2;
                        sum += j % 10 + j / 10;
                    }

                    sum += int.Parse(imei[i].ToString());
                }

                return ((100 - sum) % 10).ToString();
            }

            ushort a = Number.ToUInt16(buf);
            uint b = Number.ToUInt32(new byte[1].Concat(buf[1..]).ToArray());
            string? c = null, d = null;

            if (a > 9999)
            {
                a = (ushort)Math.Truncate((decimal)a / 10);
            }

            if (a < 1000)
            {
                c = uin.ToString()[..4];
            }


            while (b > 9999999)
            {
                b >>= 1;
            }


            if (b < 1000000)
            {
                d = uin.ToString()[..4] + uin.ToString()[..3];
            }

            imei += c ?? a + "0" + d;

            return imei + CalcSP(imei);
        }

        return new ShortDevice
        {
            Product = "MRS4S",
            Device = "HIM188MOE",
            Board = "MIRAI-YYDS",
            Brand = "ORKAX",
            Model = "Konata 2020",
            WifiSsid = $"TP-LINK {uin}",
            BootLoader = "U-boot",
            AndroidId = $"ORKAX.{Number.ToUInt16(md5)}.{md5[2]}{uin.ToString()[0]}",
            BootId =
                hex.Take(8) + "-" + hex.Skip(8).Take(4) + "-" + hex.Skip(12).Take(4) + "-" + hex.Skip(16).Take(4) +
                "-" +
                hex.Skip(20).ToArray(),
            MacAddress = $"00:50:{md5[6]:X2}:{md5[7]:X2}:{md5[8]:X2}:{md5[9]:X2}:",
            IpAddress = $"10.0.{md5[10]}.{md5[11]}",
            Imei = GenerateImei(uin),
            Incremental = Number.ToUInt32(md5[12..])
        };
    }
}
