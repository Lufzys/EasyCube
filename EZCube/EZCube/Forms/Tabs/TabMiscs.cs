using EZCube.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EZCube.Forms.Tabs
{
    public partial class TabMiscs : UserControl
    {
        public TabMiscs()
        {
            InitializeComponent();
        }

        private void cbInfHealth_CheckedChanged(object sender, EventArgs e)
        {
            Settings.InfiniteHealth = cbInfHealth.Checked;
        }

        private void cbInfArmor_CheckedChanged(object sender, EventArgs e)
        {
            Settings.InfiniteArmor = cbInfArmor.Checked;
        }

        private void cbFly_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Fly = cbFly.Checked;
        }

        private void cbBunnyHop_CheckedChanged(object sender, EventArgs e)
        {
            Settings.BunnyHop = cbBunnyHop.Checked;
        }

        private void cbTelekill_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Telekill = cbTelekill.Checked;
        }

        private void cbTeleportEnemies_CheckedChanged(object sender, EventArgs e)
        {
            Settings.TeleportEnemies = cbTeleportEnemies.Checked;
        }

        private void cbStreamproof_CheckedChanged(object sender, EventArgs e)
        {
            WinAPI.SetWindowDisplayAffinity(Globals.overlay.Handle, cbStreamproof.Checked ? Classes.Variables.Enums.DisplayAffinity.Monitor : Classes.Variables.Enums.DisplayAffinity.None);
        }
    }
}
