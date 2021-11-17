using System.Security.Cryptography;
using System.Text;
using System.Text.Json;

using Microsoft.Extensions.Logging;

namespace Orka
{
    public partial class OrkaClient
    {
        private OrkaClientConfiguration _config;
        private Uin _uin;
        private string _dir;
        private byte[]? _password;
        private Logger<OrkaClient> _logger; //TODO Add a way to add a logger.

        public async Task<ShortDevice> InitShortDevice()
        {
            if (File.Exists(Path.Combine(_config.DataDirectory!, "devices", $"{_uin}.json")))
            {
                var file = await File.ReadAllTextAsync("");
                return JsonSerializer.Deserialize(file, ShortDeviceContext.Default.ShortDevice) ??
                       throw new FormatException();
            }

            var shortDevice = new ShortDevice();
            var fs = File.OpenWrite(Path.Combine(_config.DataDirectory!, "devices", $"{_uin}.json"));
            var writer = new Utf8JsonWriter(fs);
            ShortDeviceContext.Default.ShortDevice.SerializeHandler?.Invoke(writer, shortDevice);
            await writer.FlushAsync();
            return shortDevice;
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
                    for (var i = 0; i < imei.Length; i++)
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
                    a = (ushort)Math.Truncate((decimal)a / 10);

                if (a < 1000)
                    c = uin.ToString()[..4];


                while (b > 9999999)
                    b >>= 1;


                if (b < 1000000)
                    d = uin.ToString()[..4] + uin.ToString()[..3];

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
                BootId = hex.Take(8) + "-" + hex.Skip(8).Take(4) + "-" + hex.Skip(12).Take(4) + "-" + hex.Skip(16).Take(4) + "-" + hex.Skip(20).ToArray(),
                MacAddress = $"00:50:{md5[6]:X2}:{md5[7]:X2}:{md5[8]:X2}:{md5[9]:X2}:",
                IpAddress = $"10.0.{md5[10]}.{md5[11]}",
                Imei = GenerateImei(uin),
                Incremental = Number.ToUInt32(md5[12..])
            };
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

#pragma warning disable CS8618
        private OrkaClient()
#pragma warning restore CS8618
        {
        }

        public static OrkaClient Create(Uin uin, OrkaClientConfiguration? configuration = null)
        {
            var client = new OrkaClient();
            var config = configuration ?? OrkaClientConfiguration.Default;
            client._dir = InitializeDirectories(config.DataDirectory, uin);
            client._config = config;
            client._uin = uin;
            return client;
        }

        public async Task LoginAsync()
        {
        }

        public async Task LoginAsync(byte[] passwordMd5)
        {
            //check agument null of add a overload
            _password = passwordMd5;
            var token = await File.ReadAllBytesAsync(Path.Combine(_dir, "token"));
            //TODO token login
            if (_password is not null)
            {
            }
        }

        private static string InitializeDirectories(string? dataDirectory, Uin uin)
        {
            if (dataDirectory == null)
                throw new ArgumentNullException(nameof(dataDirectory));
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
    }
}