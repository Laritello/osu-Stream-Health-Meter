using System;
using System.IO;
using Newtonsoft.Json;

using OsuStreamHealthMeter.Classes;

namespace OsuStreamHealthMeter.Utility
{
    public static class AppDataManager
    {
        private static readonly string _path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "osu!StreamHealthCompanion");

        private static readonly string _settingsPath = Path.Combine(_path, "settings.json");

        #region Settings
        public static ApplicationSettings LoadSettings()
        {
            Directory.CreateDirectory(_path);

            if (!File.Exists(_settingsPath))
                return new ApplicationSettings();

            try
            {
                string _json = File.ReadAllText(_settingsPath);
                ApplicationSettings result = JsonConvert.DeserializeObject<ApplicationSettings>(_json);
                return result;
            }
            catch
            {
                return new ApplicationSettings();
            }
        }

        public static void SaveSettings(ApplicationSettings settings)
        {
            Directory.CreateDirectory(_path);

            try
            {
                string _json = JsonConvert.SerializeObject(settings);

                File.WriteAllText(_settingsPath, _json);
            }
            catch(Exception ex)
            {
                throw new Exception("Cannot save setttings. " + ex.Message);
            }
        }
        #endregion
    }
}
