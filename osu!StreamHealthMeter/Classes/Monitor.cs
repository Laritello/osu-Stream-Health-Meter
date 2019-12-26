using Newtonsoft.Json;
using OsuStreamHealthMeter.Display;
using OsuStreamHealthMeter.Forms;
using OsuStreamHealthMeter.Utility;
using SFML.Window;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using WebSocketSharp;

namespace OsuStreamHealthMeter.Classes
{
    class Monitor : IDisposable
    {
        private FrameWindow _frame;
        private ApplicationSettings _settings;
        private WebSocket _socket;
        private readonly CultureInfo ci = new CultureInfo("en-US");

        private Profile _selectedProfile = null;

        private Level _currentLevel = null;
        private Level CurrentLevel
        {
            get
            {
                return _currentLevel;
            }
            set
            {
                if (_currentLevel == null)
                {
                    try
                    {
                        _frame.Sprites = value.Sprites;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    _currentLevel = value;
                }
                else
                {
                    if (_currentLevel.Name != value.Name)
                    {
                        try
                        {
                            _frame.Sprites = value.Sprites;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        _currentLevel = value;
                    }
                }
            }
        }

        private double Accuracy = 100.0f;

        private double _health = 200.0f;
        private double Health
        {
            get
            {
                return _health;
            }
            set
            {
                Level _level = _selectedProfile.Levels.Where(x => x.Minimum <= value && x.Maximum >= value).FirstOrDefault();
                CurrentLevel = _level;

                _health = value;
            }
        }

        public string SocketStatus { get; set; }
        public string PatternStatus { get; set; }

        public void Run()
        {
            _frame.Run();
        }

        public Monitor()
        {
            _settings = AppDataManager.LoadSettings();
            _selectedProfile = _settings.SelectedProfile;

            if (_selectedProfile != null)
            {
                _selectedProfile.Load();

                if (_selectedProfile.Levels.Count > 0)
                    CurrentLevel = _selectedProfile.Levels[0];
            }
                

            InitializeFrame();
            InitializeSocket();
        }

        private void InitializeFrame()
        {
            _frame = new FrameWindow(_settings.WindowWidth, _settings.WindowHeight, _settings.FrameRate);
            _frame.Window.MouseButtonPressed += Frame_MouseButtonPressed;
        }

        private void InitializeSocket()
        {
            _socket = new WebSocket($"ws://localhost:80/StreamCompanion/LiveData/Stream");
            _socket.OnOpen += (conn, e) => SocketStatus = "Connected";
            _socket.OnClose += (conn, e) => SocketStatus = "Disconnected";
            _socket.OnError += (conn, e) => SocketStatus = "Error";
            _socket.OnMessage += (conn, e) =>
            {
                try
                {
                    var dic = JsonConvert.DeserializeObject<Dictionary<string, string>>(e.Data);

                    if (dic.ContainsKey("hm"))
                    {
                        PatternStatus = "Pattern: found";

                        var values = dic["hm"].Split(',');

                        if (double.TryParse(values[0], NumberStyles.Float, ci, out double _accuracy))
                            Accuracy = _accuracy;

                        if (double.TryParse(values[1], NumberStyles.Float, ci, out double _health))
                            Health = _health;
                    }
                    else
                    {
                        PatternStatus = "Pattern: not found";
                    }
                }
                catch
                {

                }
            };

            _socket.Connect();
        }

        private void Frame_MouseButtonPressed(object sender, MouseButtonEventArgs e)
        {
            // Open settings on right click
            if (e.Button == Mouse.Button.Right)
            {
                FormSettings _formSettings = new FormSettings();
                _formSettings.ShowDialog();

                // Update window settings if user confirmed changes
                if (_formSettings.DialogResult == System.Windows.Forms.DialogResult.OK)
                {
                    _settings = _formSettings.Settings;
                    _selectedProfile = _settings.SelectedProfile;
                    _frame.FrameRate = _settings.FrameRate;
                    _frame.WindowSize = new SFML.System.Vector2u((uint)_settings.WindowWidth, (uint)_settings.WindowHeight);
                }

                _formSettings.Dispose();
            }
        }

        public void Dispose()
        {
            _frame.Dispose();
            _socket.Close();
        }
    }
}
