using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZCube.Classes
{
    class Offsets
    {
        public const int Client = 0x0050F4E8;
        public const int Viewmatrix = 0x00501AE8;
        public const int LocalPlayer = 0x0C;
        public const int EntityList = 0x10;
        public const int PlayersCount = 0x18;
        public const int CrosshairTarget = 0x501C38;

        public const int Health = 0xF8;
        public const int Armor = 0xFC;
        public const int Name = 0x225;
        public const int Team = 0x032C;
        public const int HeadPosition = 0x04;
        public const int FootPosition = 0x34;
        public const int Velocity = 0x10;
        public const int Yaw = 0x40;
        public const int Pitch = 0x44;
        public const int Height = 0x5C;
        public const int ForceAttack = 0x224;
        public const int ForceJump = 0x5C;
        public const int ForceMovement = 0x80;

        //weapon pointers
        //ptrPlayerEntity -> ptrCurrentWeapon -> ptrWeapon -> variableOffset
        public const int ptrCurrentWeapon = 0x0378;
        public const int ptrWeapon = 0x10;
        //weapon variables
        public const int ammo = 0x28;
        public const int ammoClip = 0x00;
        public const int delayTime = 0x50;
    }
}
