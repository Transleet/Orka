using System.Security.Cryptography;
using System.Text;
using System.Text.Json;

namespace Orka
{
    public class OrkaClient
    {
        #region Props

        private OrkaClientConfiguration Config { get; set; }
        private Uin Uin { get; set; }

        #endregion

        #region DeviceData

        public async Task<ShortDevice> InitShortDevice()
        {
            if (File.Exists(Path.Combine(Config.DataDirectory!, "devices", $"{Uin}.json")))
            {
                var file = await File.ReadAllTextAsync("");
                return JsonSerializer.Deserialize(file, ShortDeviceContext.Default.ShortDevice) ?? throw new FormatException();
            }

            var shortDevice = new ShortDevice();
            var fs = File.OpenWrite(Path.Combine(Config.DataDirectory!, "devices", $"{Uin}.json"));
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

        #endregion
        public OrkaClient(Uin uin, OrkaClientConfiguration config)
        {
            Uin = uin;
            Config = config;
        }

        public static OrkaClient Create(Uin uin, OrkaClientConfiguration? configuration)
        {
            #region 内部方法

            static void InitDirectory(string dataDirectory, Uin uin)
            {
                if (!Directory.Exists(dataDirectory))
                {
                    CreateDataDirectory(dataDirectory);
                }

                if (!Directory.Exists(Path.Combine(dataDirectory, "devices")))
                {
                    CreateDeviceDirectory(dataDirectory);
                }

                if (!Directory.Exists(Path.Combine(dataDirectory, uin.ToString())))
                {
                    CreateUinDirectory(dataDirectory, uin);
                }
            }
            static void CreateDataDirectory(string dataDirectory) => Directory.CreateDirectory(dataDirectory);
            static void CreateDeviceDirectory(string dataDirectory) => Directory.CreateDirectory(Path.Combine(dataDirectory, "devices"));
            static void CreateUinDirectory(string dataDirectory, Uin uin) => Directory.CreateDirectory(Path.Combine(dataDirectory, uin.ToString()));

            #endregion
            var dataPath = configuration?.DataDirectory ?? Path.Combine(Directory.GetCurrentDirectory(), "Orka", "data");
            InitDirectory(dataPath, uin);
            var defaultConf = OrkaClientConfiguration.DefaultConfiguration;
            defaultConf.DataDirectory = dataPath;
            return new OrkaClient(uin, configuration ?? defaultConf);
        }


        public Task LoginAsync()
        {
            throw new NotImplementedException();
        }
    }
}