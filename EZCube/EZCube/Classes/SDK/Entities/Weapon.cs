using static Globals;

namespace EZCube.Classes.SDK.Entities
{
    class Weapon
    {
        public int Address;
        public Weapon(int address)
        {
            Address = address;
        }

        public int Ammo
        {
            get
            {
                return mem.Read<int>(Address + Offsets.ammo);
            }
            set
            {
                mem.Write<int>(Address + Offsets.ammo, value);
            }
        }

        public int Clip
        {
            get
            {
                return mem.Read<int>(Address + Offsets.ammoClip);
            }
            set
            {
                mem.Write<int>(Address + Offsets.ammoClip, value);
            }
        }

        public int DelayTime
        {
            get
            {
                return mem.Read<int>(Address + Offsets.delayTime);
            }
            set
            {
                mem.Write<int>(Address + Offsets.delayTime, value);
            }
        }
    }
}
