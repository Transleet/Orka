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