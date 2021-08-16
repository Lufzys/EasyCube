using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZCube.Classes.SDK.Variables
{
    class Enums
    {
        public enum Team : int
        {
            CLA,
            RVSF,
            Spectator = 4
        }

        public enum Hitbox
        {
            Head,
            Body,
            Foot
        }
    }
}
