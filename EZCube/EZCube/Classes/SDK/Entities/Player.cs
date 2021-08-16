using EZCube.Classes.SDK.Variables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static Globals;

namespace EZCube.Classes.SDK.Entities
{
    class Player
    {
        public int Address;
        public Player(int address)
        {
            Address = address;
        }

        public int Health
        {
            get
            {
                return mem.Read<int>(Address + Offsets.Health);
            }
            set
            {
                mem.Write<int>(Address + Offsets.Health, value);
            }
        }
        public int Armor
        {
            get
            {
                return mem.Read<int>(Address + Offsets.Armor);
            }
            set
            {
                mem.Write<int>(Address + Offsets.Armor, value);
            }
        }

        public string Name
        {
            get
            {
                return mem.ReadStringASCII(Address + Offsets.Name, 17);
            }
        }

        public Enums.Team Team
        {
            get
            {
                return (Enums.Team)mem.Read<int>(Address + Offsets.Team);
            }
            set
            {
                mem.Write<int>(Address + Offsets.Health, value);
            }
        }

        public float Yaw
        {
            get
            {
                return mem.Read<float>(Address + Offsets.Yaw);
            }
            set
            {
                mem.Write<float>(Address + Offsets.Yaw, value);
            }
        }

        public float Pitch
        {
            get
            {
                return mem.Read<float>(Address + Offsets.Pitch);
            }
            set
            {
                mem.Write<float>(Address + Offsets.Pitch, value);
            }
        }

        public Vector3 HeadPosition
        {
            get
            {
                return mem.Read<Vector3>(Address + Offsets.HeadPosition);
            }
            set
            {
                mem.Write<Vector3>(Address + Offsets.HeadPosition, value);
            }
        }

        public Vector3 FootPosition
        {
            get
            {
                return mem.Read<Vector3>(Address + Offsets.FootPosition);
            }
            set
            {
                mem.Write<Vector3>(Address + Offsets.FootPosition, value);
            }
        }

        public Weapon CurrentWeapon()
        {
            int currentWeaponBase = mem.Read<int>(Address + Offsets.ptrCurrentWeapon);
            int currentWeapon = mem.Read<int>(currentWeaponBase + Offsets.ptrWeapon);
            return new Weapon(currentWeapon);
        }
    }
}
