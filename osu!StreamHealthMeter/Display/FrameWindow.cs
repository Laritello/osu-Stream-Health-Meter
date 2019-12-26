using System;

using SFML.Graphics;
using SFML.Window;

using System.Collections.Generic;

namespace OsuStreamHealthMeter.Display
{
    public class FrameWindow : IDisposable
    {
        public RenderWindow Window { get; private set; }

        #region Properties
        private SFML.System.Vector2u _windowSize;
        public SFML.System.Vector2u WindowSize
        {
            get
            {
                return _windowSize;
            }
            set
            {
                _windowSize = value;
                Window.Size = _windowSize;
            }
        }

        private uint _frameRate;
        public int FrameRate
        {
            get
            {
                return (int)_frameRate;
            }
            set
            {
                if (value < 1)
                    throw new Exception("Frame rate value can't be lower than 1");

                _frameRate = (uint)value;

                Window.SetFramerateLimit(_frameRate);
            }
        }

        private IList<Sprite> _sprites;
        public IList<Sprite> Sprites
        {
            get
            {
                return _sprites;
            }
            set
            {
                _imageFrameIndex = 0;
                _sprites = value;
            }
        }
        #endregion

        private int _imageFrameIndex = 0;

        public void Run()
        {
            // Start the game loop
            while (Window.IsOpen)
            {
                // Process events
                Window.DispatchEvents();
                Window.Clear(Color.Transparent);

                Sprite _imageSprite = NextSprite();

                if (_imageSprite != null)
                    Window.Draw(_imageSprite);

                Window.Display();
            }
        }

        #region Window Events
        private void Window_Closed(object sender, EventArgs e)
        {
            Window.Close();
        }
        #endregion

        private Sprite NextSprite()
        {
            if (_sprites == null || _sprites.Count == 0)
                return null;

            _imageFrameIndex = (_imageFrameIndex + 1 >= _sprites.Count) ? 0 : _imageFrameIndex + 1;

            return _sprites[_imageFrameIndex];
        }

        private RenderWindow InitializeWindow()
        {
            VideoMode mode = new VideoMode(_windowSize.Y, _windowSize.X);
            RenderWindow window = new RenderWindow(mode, "osu! Stream Health Monitor", Styles.Titlebar | Styles.Close);
            window.SetFramerateLimit(_frameRate);

            // Make Window Transparent (can only tell if image being viewed has transparency)
            DWM_BLURBEHIND bb = new DWM_BLURBEHIND
            {
                dwFlags = DWM_BB.Enable | DWM_BB.BlurRegion,
                fEnable = true,
                hRgnBlur = DWM.CreateRectRgn(0, 0, -1, -1)
            };

            DWM.DwmEnableBlurBehindWindow(window.SystemHandle, ref bb);

            window.Closed += Window_Closed;

            return window;
        }

        public FrameWindow(int _width, int _height, int _frameRate)
        {
            _sprites = new List<Sprite>();
            _windowSize.Y = (uint)_width;
            _windowSize.X = (uint)_height;
            this._frameRate = (uint)_frameRate;

            Window = InitializeWindow();
        }


        public void Dispose()
        {
            if (Window.IsOpen)
                Window.Close();

            Window.Dispose();
        }
    }
}
