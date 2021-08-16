using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static EZCube.Classes.Variables.Enums;

namespace EZCube.Classes.Variables
{
    public class Structs
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct WindowCompositionAttributeData
        {
            public WindowCompositionAttribute Attribute;
            public IntPtr Data;
            public int SizeOfData;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct AccentPolicy
        {
            public AccentState AccentState;
            public int AccentFlags;
            public int GradientColor;
            public int AnimationId;
        }
    }
}
