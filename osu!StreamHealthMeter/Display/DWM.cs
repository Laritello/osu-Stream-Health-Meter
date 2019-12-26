using System;
using System.Runtime.InteropServices;
using SFML.System;
using SFML.Graphics;

namespace OsuStreamHealthMeter.Display
{
    class DWM
    {
        // Make Window Background Transparent
        [DllImport("dwmapi.dll")]
        public static extern void DwmEnableBlurBehindWindow(IntPtr hwnd, ref DWM_BLURBEHIND blurBehind);

        [DllImport("gdi32.dll")]
        public static extern IntPtr CreateRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect);
    }

    [Flags]
    enum DWM_BB
    {
        Enable = 1,
        BlurRegion = 2,
        TransitionOnMaximized = 4
    }

    [StructLayout(LayoutKind.Sequential)]
    struct DWM_BLURBEHIND
    {
        public DWM_BB dwFlags;
        public bool fEnable;
        public IntPtr hRgnBlur;
        public bool fTransitionOnMaximized;
    }
}
