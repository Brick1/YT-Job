using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using YoutubeDownloader.Youtube.Interfaces;
using System.Text.Json;

namespace YoutubeDownloader
{
    internal class Filemanager
    {
        private Dictionary<string, Tuple<IYoutubeVideoInfo, string>> savedVideoInfos = new Dictionary<string, Tuple<IYoutubeVideoInfo, string>>();

        public Filemanager(string programFolderName)
        {
            Settings.Instance.ProgramFolderName = programFolderName;
        }

        public void CheckFolder(string path)
        {
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
        }

        public void LoadSettings()
        {
            CheckFolder(Path.Combine(Settings.Instance.AppFolder, Settings.MAIN_FOLDER_NAME));

            string filePath = Path.Combine(Settings.Instance.AppFolder, Settings.MAIN_FOLDER_NAME, "appsettings.json");
            var settings = JsonSerializer.Deserialize<Settings>(File.ReadAllText(filePath));
        }

        public async Task SaveSettingsAsync()
        {
            CheckFolder(Path.Combine(Settings.Instance.AppFolder, Settings.MAIN_FOLDER_NAME));

            string filePath = Path.Combine(Settings.Instance.AppFolder, Settings.MAIN_FOLDER_NAME, "appsettings.json");
            using FileStream createStream = File.Create(filePath);
            await JsonSerializer.SerializeAsync(createStream, new { Settings.Instance.VideoFolderPath, Settings.Instance.AudioFolderPath });
            await createStream.DisposeAsync();
        }
    }
}
