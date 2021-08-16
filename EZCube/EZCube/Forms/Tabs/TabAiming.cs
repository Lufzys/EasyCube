using EZCube.Classes.SDK.Variables;
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
    public partial class TabAiming : UserControl
    {
        public TabAiming()
        {
            InitializeComponent();
        }

        private void cbAimbot_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Aimbot = cbAimbot.Checked;
        }

        private void tbAimbotFOV_ValueChanged(object sender, EventArgs e)
        {
            Settings.Aimbot_FOV = tbAimbotFOV.Value * 10;
            lblAimbotFOVValue.Text = tbAimbotFOV.Value.ToString();
        }

        private void cbAimbotDrawFOV_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Aimbot_FOV_Draw = cbAimbotDrawFOV.Checked;
        }

        private void cbHitboxSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            Settings.Aimbot_Hitbox = (Enums.Hitbox)Enum.Parse(typeof(Enums.Hitbox), cbHitboxSelection.SelectedItem.ToString());
        }

        private void cbTriggerBot_CheckedChanged(object sender, EventArgs e)
        {
            Settings.TriggerBot = cbTriggerBot.Checked;
        }

        private void cbInfAmmo_CheckedChanged(object sender, EventArgs e)
        {
            Settings.InfiniteAmmo = cbInfAmmo.Checked;
        }

        private void cbRapidFire_CheckedChanged(object sender, EventArgs e)
        {
            Settings.RapidFire = cbRapidFire.Checked;
        }
    }
}
