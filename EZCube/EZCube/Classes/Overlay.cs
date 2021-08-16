using EZCube.Classes.Variables;
using EZCube.Forms;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace EZCube.Classes
{
    class Overlay
    {
        private OverlayFrm OverlayForm = new OverlayFrm();
        private IntPtr LockWindowHandle = IntPtr.Zero;
        private bool AttachToClient = false;
        public bool IsRunning = false;

        public IntPtr Handle
        {
            get
            {
                return OverlayForm.Handle;
            }
        }
        public int X
        {
            get
            {
                return OverlayForm.Left;
            }
            set
            {
                OverlayForm.Left = value;
            }
        }
        public int Y
        {
            get
            {
                return OverlayForm.Top;
            }
            set
            {
                OverlayForm.Top = value;
            }
        }
        public int Width
        {
            get
            {
                return OverlayForm.Size.Width;
            }
            set
            {
                OverlayForm.Size = new System.Drawing.Size(value, OverlayForm.Size.Height);
            }
        }
        public int Height
        {
            get
            {
                return OverlayForm.Size.Height;
            }
            set
            {
                OverlayForm.Size = new System.Drawing.Size(OverlayForm.Size.Width, value);
            }
        }
        public bool Visible
        {
            get
            {
               return OverlayForm.Visible;
            }
            set
            {
                OverlayForm.Visible = value;
            }
        }
        public double Opacity
        {
            get
            {
                return OverlayForm.Opacity;
            }
            set
            {
                OverlayForm.Opacity = value;
            }
        }
        public int CenterX
        {
            get
            {
                return Width / 2;
            }
        }
        public int CenterY
        {
            get
            {
                return Height / 2;
            }
        }

        public void Resize(int x, int y, int width, int height)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }
        public void FitTo(IntPtr windowHandle, bool attachToClientArea = false)
        {
            bool result = attachToClientArea ? Utils.GetWindowClientBounds(windowHandle, out NativeRect rect) : Utils.GetWindowBounds(windowHandle, out rect);

            if (result)
            {
                int x = rect.Left;
                int y = rect.Top;
                int width = rect.Right - rect.Left;
                int height = rect.Bottom - rect.Top;

                if (X != x
                    || Y != y
                    || Width != width
                    || Height != height)
                {
                    Resize(x, y, width, height);
                }
            }
        }
        public void FitTo(Process window, bool attachToClientArea = false)
        {
            FitTo(window.MainWindowHandle, attachToClientArea);
        }
        public void FitTo(string windowText, bool attachToClientArea = false)
        {
            if (WinAPI.FindWindowByCaption(IntPtr.Zero, windowText) != null) return;
            FitTo(WinAPI.FindWindowByCaption(IntPtr.Zero, windowText), attachToClientArea);
        }
        public void LockWindow(IntPtr lockWindow, bool attachToClient = false)
        {
            LockWindowHandle = lockWindow;
            AttachToClient = attachToClient;
        }
        public void LockWindow(Process process, bool attachToClient = false)
        {
            LockWindow(process.MainWindowHandle, attachToClient);
        }
        public void LockWindow(string windowText, bool attachToClient = false)
        {
            if (WinAPI.FindWindowByCaption(IntPtr.Zero, windowText) != null) return;
            LockWindow(WinAPI.FindWindowByCaption(IntPtr.Zero, windowText), attachToClient);
        }
        public void UnlockWindow()
        {
            LockWindowHandle = IntPtr.Zero;
            Visible = true;
        }

        public Overlay(Rectangle rect, bool topMost)
        {
            Run();
            OverlayForm.TopMost = topMost;
            Resize(rect.X, rect.Y, rect.Width, rect.Height);
        }
        public Overlay(Rectangle rect)
        {
            Run();
            Resize(rect.X, rect.Y, rect.Width, rect.Height);
        }
        public Overlay(bool topMost)
        {
            Run();
            OverlayForm.TopMost = topMost;
        }
        public Overlay() { }

        public void Run()
        {
            if (IsRunning) return;
            OverlayForm.SetStyleEx(ControlStyles.SupportsTransparentBackColor, true);
            OverlayForm.FormBorderStyle = FormBorderStyle.None;
            OverlayForm.BackColor = Color.FromArgb(1, 1, 1);
            OverlayForm.TransparencyKey = Color.FromArgb(1, 1, 1);
            OverlayForm.TopMost = true;
            OverlayForm.ShowIcon = false;
            OverlayForm.ShowInTaskbar = false;
            OverlayForm.SetStyleEx(ControlStyles.OptimizedDoubleBuffer, true);
            OverlayForm.DoubleBufferedEx(true);

            int initialStyle = WinAPI.GetWindowLong(OverlayForm.Handle, -20);
            WinAPI.SetWindowLong(OverlayForm.Handle, -20, initialStyle | 0x80000 | 0x20);

            System.Windows.Forms.Timer updateDraw = new System.Windows.Forms.Timer();
            updateDraw.Tick += new EventHandler(UpdateDraw);
            updateDraw.Interval = 1;
            updateDraw.Start();

            System.Windows.Forms.Timer lockWindow = new System.Windows.Forms.Timer();
            lockWindow.Tick += new EventHandler(LockToWindow);
            lockWindow.Interval = 1;
            lockWindow.Start();

            OverlayForm.Show();
        }

        public enum EventInsertionType
        {
            ADD,
            REMOVE
        }

        public void Draw(PaintEventHandler drawEvent, EventInsertionType eventResult)
        {
            switch(eventResult)
            {
                case EventInsertionType.ADD:
                    OverlayForm.Paint += drawEvent;
                    break;

                case EventInsertionType.REMOVE:
                    OverlayForm.Paint -= drawEvent;
                    break;
            }
        }

        private void LockToWindow(object sender, EventArgs e)
        {
            if (LockWindowHandle == IntPtr.Zero) return;
            if(WinAPI.GetForegroundWindow() == LockWindowHandle)
            {
                Visible = true;
                FitTo(LockWindowHandle, AttachToClient);
            }
            else
            {
                Visible = false;
            }
        }
        private void UpdateDraw(object sender, EventArgs e)
        {
            try
            {
                OverlayForm.Refresh();
            } catch { }
        }
        public partial class OverlayFrm : Form
        {
            protected override void WndProc(ref System.Windows.Forms.Message m)
            {
                switch (m.Msg)
                {
                    case 0x000F:
                        this.Refresh();
                        break;
                }
                base.WndProc(ref m);
            }
        }
    }
}
