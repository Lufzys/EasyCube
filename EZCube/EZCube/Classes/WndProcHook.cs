using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EZCube.Classes
{
    public class WndProcHook
    {
        #region Imports
        [DllImport("user32.dll")]
        public static extern IntPtr CallWindowProc(IntPtr lpPrevWndFunc, IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll")]
        private static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        private enum GWL
        {
            GWL_WNDPROC = (-4),
            GWL_HINSTANCE = (-6),
            GWL_HWNDPARENT = (-8),
            GWL_STYLE = (-16),
            GWL_EXSTYLE = (-20),
            GWL_USERDATA = (-21),
            GWL_ID = (-12)
        }
        #endregion

        public delegate IntPtr WndProcDelegate(IntPtr hWnd, uint msg, IntPtr wParam, IntPtr lParam);
        public IntPtr WindowHandle;
        public IntPtr OriginalWndProc;

        public WndProcHook(IntPtr hwnd, WndProcDelegate wndProcDelegate)
        {
            WindowHandle = hwnd;
            OriginalWndProc = (IntPtr)GetWindowLong(WindowHandle, (int)GWL.GWL_WNDPROC);
            SetWindowLong(WindowHandle, (int)GWL.GWL_WNDPROC, Marshal.GetFunctionPointerForDelegate(wndProcDelegate).ToInt32());
        }

        public WndProcHook(IntPtr hwnd, IntPtr wndProcDelegate)
        {
            WindowHandle = hwnd;
            OriginalWndProc = (IntPtr)GetWindowLong(WindowHandle, (int)WinAPI.GWL.GWL_WNDPROC);
            SetWindowLong(WindowHandle, (int)GWL.GWL_WNDPROC, (int)wndProcDelegate);
        }

        public void Restore()
        {
            SetWindowLong(WindowHandle, (int)GWL.GWL_WNDPROC, (int)OriginalWndProc);
        }
    }
}
