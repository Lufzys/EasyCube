using EZCube.Classes.Variables;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EZCube.Classes
{
    class Utils
    {
		public static bool GetWindowClientInternal(IntPtr hwnd, out NativeRect rect)
		{
			// calculates the window bounds based on the difference of the client and the window rect

			if (!WinAPI.GetWindowRect(hwnd, out rect)) return false;
			if (!WinAPI.GetClientRect(hwnd, out var clientRect)) return true;

			int clientWidth = clientRect.Right - clientRect.Left;
			int clientHeight = clientRect.Bottom - clientRect.Top;

			int windowWidth = rect.Right - rect.Left;
			int windowHeight = rect.Bottom - rect.Top;

			if (clientWidth == windowWidth && clientHeight == windowHeight) return true;

			if (clientWidth != windowWidth)
			{
				int difX = clientWidth > windowWidth ? clientWidth - windowWidth : windowWidth - clientWidth;
				difX /= 2;

				rect.Right -= difX;
				rect.Left += difX;

				if (clientHeight != windowHeight)
				{
					int difY = clientHeight > windowHeight ? clientHeight - windowHeight : windowHeight - clientHeight;

					rect.Top += difY - difX;
					rect.Bottom -= difX;
				}
			}
			else if (clientHeight != windowHeight)
			{
				int difY = clientHeight > windowHeight ? clientHeight - windowHeight : windowHeight - clientHeight;
				difY /= 2;

				rect.Bottom -= difY;
				rect.Top += difY;
			}

			return true;
		}

		public static bool GetWindowBounds(IntPtr hwnd, out NativeRect bounds)
		{
			if (WinAPI.GetWindowRect(hwnd, out var rect))
			{
				bounds = new NativeRect()
				{
					Left = rect.Left,
					Top = rect.Top,
					Right = rect.Right,
					Bottom = rect.Bottom
				};

				return true;
			}
			else
			{
				bounds = default;

				return false;
			}
		}

		public static bool GetWindowClientBounds(IntPtr hwnd, out NativeRect bounds)
		{
			if (GetWindowClientInternal(hwnd, out var rect))
			{
				bounds = new NativeRect()
				{
					Left = rect.Left,
					Top = rect.Top,
					Right = rect.Right,
					Bottom = rect.Bottom
				};

				return true;
			}
			else
			{
				bounds = default;

				return false;
			}
		}

		public static bool IsKeyPushedDown(System.Windows.Forms.Keys vKey)
		{
			return 0 != (WinAPI.GetAsyncKeyState(vKey) & 0x8000);
		}

		public class DragObj
		{
			#region DragForm
			private Form frm;
			private Control cntrl;

			public DragObj() { }

			public DragObj(Form _frm, Control _cntrl)
			{
				frm = _frm;
				cntrl = _cntrl;

				AddDrag();
			}

			public void AddDrag()
			{
				cntrl.MouseDown += new MouseEventHandler(Drag_MouseDown);
				cntrl.MouseMove += new MouseEventHandler(Drag_MouseMove);
				cntrl.MouseUp += new MouseEventHandler(Drag_MouseUp);
			}

			public bool MouseDown;
			private Point lastLocation;

			private void Drag_MouseDown(object sender, MouseEventArgs e)
			{
				MouseDown = true;
				lastLocation = e.Location;
				Control cntrl = (Control)sender;
				//Aero.ChangeAccent(Handle, new Enums.AccentPolicy { GradientColor = 0xFD70000, AccentState = Enums.AccentState.ACCENT_DISABLED });
				//this.Opacity = 0.85;
				cntrl.Cursor = Cursors.Hand;
			}

			private void Drag_MouseMove(object sender, MouseEventArgs e)
			{
				if (MouseDown)
				{
					frm.Location = new Point(
						(frm.Location.X - lastLocation.X) + e.X, (frm.Location.Y - lastLocation.Y) + e.Y);

					frm.Update();
				}
			}

			private void Drag_MouseUp(object sender, MouseEventArgs e)
			{
				MouseDown = false;
				Control cntrl = (Control)sender;
				//Aero.ChangeAccent(Handle, new Enums.AccentPolicy { GradientColor = 0xFD70000, AccentState = FormAccent });
				//this.Opacity = 1;
				cntrl.Cursor = Cursors.Default;
			}
			#endregion
		}
	}
}
