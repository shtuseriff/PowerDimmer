using System;
using System.Windows;
using System.Windows.Interop;
using System.Windows.Media;

namespace PowerDimmer
{
    public partial class DimWindow : Window
    {
        public IntPtr Handle;
        private System.Drawing.Rectangle _screenBounds;

        public DimWindow(ISettings settings, System.Drawing.Rectangle screenBounds)
        {
            _screenBounds = screenBounds;
            ShowInTaskbar = false;
            AllowsTransparency = true;
            Background = Brushes.Black;
            WindowStyle = WindowStyle.None;
            ResizeMode = ResizeMode.NoResize;
            Width = 1; Height = 1;
        }

        protected override void OnSourceInitialized(EventArgs e)
        {
            Handle = new WindowInteropHelper(this).EnsureHandle();

            var style = Win32.GetWindowLong(Handle, Win32.GWL_EXSTYLE);
            Win32.SetWindowLong(Handle, Win32.GWL_EXSTYLE, style | Win32.WS_EX_LAYERED | Win32.WS_EX_TRANSPARENT | Win32.WS_EX_NOACTIVATE);

            // Position using Win32 pixel coordinates directly to avoid
            // DPI mismatch between WinForms Screen.Bounds and WPF Left/Top.
            Win32.SetWindowPos(Handle, IntPtr.Zero,
                _screenBounds.Left, _screenBounds.Top,
                _screenBounds.Width, _screenBounds.Height,
                Win32.SWP_NOZORDER | Win32.SWP_NOACTIVATE);

            base.OnSourceInitialized(e);
        }
    }
}