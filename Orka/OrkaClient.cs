using System.Text.Json;
using Microsoft.Extensions.Logging;

namespace Orka
{
    public class OrkaClient
    {
        private OrkaClientConfiguration _config;
        private Uin _uin;
        private string _dir;
        private byte[]? _password;
        private Logger<OrkaClient> _logger;//TODO Add a way to add a logger.

        public async Task<ShortDevice> InitShortDevice()
        {
            if (File.Exists(Path.Combine(_config.DataDirectory!, "devices", $"{_uin}.json")))
            {
                var file = await File.ReadAllTextAsync("");
                return JsonSerializer.Deserialize(file, ShortDeviceContext.Default.ShortDevice) ?? throw new FormatException();
            }

            var shortDevice = new ShortDevice();
            var fs = File.OpenWrite(Path.Combine(_config.DataDirectory!, "devices", $"{_uin}.json"));
            var writer = new Utf8JsonWriter(fs);
            ShortDeviceContext.Default.ShortDevice.SerializeHandler?.Invoke(writer, shortDevice);
            await writer.FlushAsync();
            return shortDevice;
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