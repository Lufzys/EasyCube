using EZCube.Classes.SDK.Variables;
using EZCube.Classes.Variables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EZCube.Classes
{
    public static class Extensions
    {
		public static bool SetStyleEx(this Control c, ControlStyles Style, bool value)
		{
			bool retval = false;
			Type typeTB = typeof(Control);
			System.Reflection.MethodInfo misSetStyle = typeTB.GetMethod("SetStyle", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
			if (misSetStyle != null && c != null) { misSetStyle.Invoke(c, new object[] { Style, value }); retval = true; }
			return retval;
		}

		public static void DoubleBufferedEx(this System.Windows.Forms.Control c, bool value)
		{
			//Taxes: Remote Desktop Connection and painting
			//http://blogs.msdn.com/oldnewthing/archive/2006/01/03/508694.aspx
			if (System.Windows.Forms.SystemInformation.TerminalServerSession)
				return;

			System.Reflection.PropertyInfo aProp =
				  typeof(System.Windows.Forms.Control).GetProperty(
						"DoubleBuffered",
						System.Reflection.BindingFlags.NonPublic |
						System.Reflection.BindingFlags.Instance);

			aProp.SetValue(c, value, null);
		}

		public static void ChangeTheme(this Form form, Structs.AccentPolicy accent, bool hasFrame = true)
		{
			if (Environment.OSVersion.Version.Major >= 6)
			{
				if (hasFrame)
					accent.AccentFlags = 0x20 | 0x40 | 0x80 | 0x100;

				int accentStructSize = Marshal.SizeOf(accent);

				IntPtr accentPtr = Marshal.AllocHGlobal(accentStructSize);
				Marshal.StructureToPtr(accent, accentPtr, false);

				Structs.WindowCompositionAttributeData data = new Structs.WindowCompositionAttributeData();
				data.Attribute = Variables.Enums.WindowCompositionAttribute.WCA_ACCENT_POLICY;
				data.SizeOfData = accentStructSize;
				data.Data = accentPtr;

				WinAPI.SetWindowCompositionAttribute(form.Handle, ref data);

				Marshal.FreeHGlobal(accentPtr);
			}
		}

		public static void ChangePage(this Panel pnl, Control pageContent)
        {
			pnl.Controls.Clear();
			pnl.Controls.Add(pageContent);
        }

		[System.Runtime.InteropServices.DllImport("user32.dll")]
		public static extern bool LockWindowUpdate(IntPtr hWndLock);

		public static void Suspend(this Control control)
		{
			LockWindowUpdate(control.Handle);
		}

		public static void Resume(this Control control)
		{
			LockWindowUpdate(IntPtr.Zero);
		}

		[System.Runtime.InteropServices.DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, Int32 wMsg, bool wParam, Int32 lParam);

		private const int WM_SETREDRAW = 11;

		public static void SuspendDrawing(this Control parent)
		{
			SendMessage(parent.Handle, WM_SETREDRAW, false, 0);
		}

		public static void ResumeDrawing(this Control parent)
		{
			SendMessage(parent.Handle, WM_SETREDRAW, true, 0);
			parent.Refresh();
		}
	}
}
