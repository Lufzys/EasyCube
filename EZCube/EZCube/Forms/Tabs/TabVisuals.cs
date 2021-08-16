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
    public partial class TabVisuals : UserControl
    {
        public TabVisuals()
        {
            InitializeComponent();
        }

        private void cbESP_CheckedChanged(object sender, EventArgs e)
        {
            Settings.ESP = cbESP.Checked;
        }

        private void cbESPOutline_CheckedChanged(object sender, EventArgs e)
        {
            Settings.ESP_Outline = cbESPOutline.Checked;
        }

        private void cbESPName_CheckedChanged(object sender, EventArgs e)
        {
            Settings.ESP_Name = cbESPName.Checked;
        }

        private void cbESPHealthBar_CheckedChanged(object sender, EventArgs e)
        {
            Settings.ESP_Health = cbESPHealthBar.Checked;
        }

        private void cbESPHealthBarOutline_CheckedChanged(object sender, EventArgs e)
        {
            Settings.ESP_Health_Outline = cbESPHealthBarOutline.Checked;
        }

        private void cbESPArmorBar_CheckedChanged(object sender, EventArgs e)
        {
            Settings.ESP_Armor = cbESPArmorBar.Checked;
        }

        private void cbESPArmorBarOutline_CheckedChanged(object sender, EventArgs e)
        {
            Settings.ESP_Armor_Outline = cbESPArmorBarOutline.Checked;
        }

        private void cbSnaplines_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Snaplines = cbSnaplines.Checked;
        }

        private void cbSnaplinesOutline_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Snaplines_Outline = cbSnaplinesOutline.Checked;
        }

        private void cbESPDistance_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Distance = cbESPDistance.Checked;
        }

        private void cbWatermark_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Watermark = cbWatermark.Checked;
        }

        private void cbCrosshair_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Crosshair = cbCrosshair.Checked;
        }
    }
}
