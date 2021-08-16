
namespace EZCube.Forms.Tabs
{
    partial class TabAiming
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAimbot = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cbAimbot = new Siticone.UI.WinForms.SiticoneOSToggleSwith();
            this.lblAimbotFOV = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblAimbotFOVValue = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tbAimbotFOV = new Siticone.UI.WinForms.SiticoneMetroTrackBar();
            this.lblAimbotDrawFOV = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cbAimbotDrawFOV = new Siticone.UI.WinForms.SiticoneOSToggleSwith();
            this.lblHitboxSelection = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cbHitboxSelection = new Siticone.UI.WinForms.SiticoneComboBox();
            this.lblTriggerBot = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cbTriggerBot = new Siticone.UI.WinForms.SiticoneOSToggleSwith();
            this.lblInfAmmo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cbInfAmmo = new Siticone.UI.WinForms.SiticoneOSToggleSwith();
            this.lblRapidFire = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cbRapidFire = new Siticone.UI.WinForms.SiticoneOSToggleSwith();
            this.SuspendLayout();
            // 
            // lblAimbot
            // 
            this.lblAimbot.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lblAimbot.ForeColor = System.Drawing.Color.White;
            this.lblAimbot.Location = new System.Drawing.Point(13, 7);
            this.lblAimbot.Name = "lblAimbot";
            this.lblAimbot.Size = new System.Drawing.Size(378, 22);
            this.lblAimbot.TabIndex = 3;
            this.lblAimbot.Text = "Aimbot";
            this.lblAimbot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbAimbot
            // 
            this.cbAimbot.Location = new System.Drawing.Point(397, 7);
            this.cbAimbot.Name = "cbAimbot";
            this.cbAimbot.Size = new System.Drawing.Size(38, 22);
            this.cbAimbot.TabIndex = 2;
            this.cbAimbot.CheckedChanged += new System.EventHandler(this.cbAimbot_CheckedChanged);
            // 
            // lblAimbotFOV
            // 
            this.lblAimbotFOV.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lblAimbotFOV.ForeColor = System.Drawing.Color.White;
            this.lblAimbotFOV.Location = new System.Drawing.Point(29, 35);
            this.lblAimbotFOV.Name = "lblAimbotFOV";
            this.lblAimbotFOV.Size = new System.Drawing.Size(362, 22);
            this.lblAimbotFOV.TabIndex = 5;
            this.lblAimbotFOV.Text = "FOV";
            this.lblAimbotFOV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAimbotFOVValue
            // 
            this.lblAimbotFOVValue.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lblAimbotFOVValue.ForeColor = System.Drawing.Color.White;
            this.lblAimbotFOVValue.Location = new System.Drawing.Point(397, 35);
            this.lblAimbotFOVValue.Name = "lblAimbotFOVValue";
            this.lblAimbotFOVValue.Size = new System.Drawing.Size(38, 22);
            this.lblAimbotFOVValue.TabIndex = 6;
            this.lblAimbotFOVValue.Text = "9";
            this.lblAimbotFOVValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbAimbotFOV
            // 
            this.tbAimbotFOV.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbAimbotFOV.HoveredState.Parent = this.tbAimbotFOV;
            this.tbAimbotFOV.Location = new System.Drawing.Point(63, 35);
            this.tbAimbotFOV.Maximum = 300;
            this.tbAimbotFOV.Minimum = 1;
            this.tbAimbotFOV.Name = "tbAimbotFOV";
            this.tbAimbotFOV.Size = new System.Drawing.Size(328, 22);
            this.tbAimbotFOV.TabIndex = 7;
            this.tbAimbotFOV.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.tbAimbotFOV.Value = 9;
            this.tbAimbotFOV.ValueChanged += new System.EventHandler(this.tbAimbotFOV_ValueChanged);
            // 
            // lblAimbotDrawFOV
            // 
            this.lblAimbotDrawFOV.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lblAimbotDrawFOV.ForeColor = System.Drawing.Color.White;
            this.lblAimbotDrawFOV.Location = new System.Drawing.Point(29, 60);
            this.lblAimbotDrawFOV.Name = "lblAimbotDrawFOV";
            this.lblAimbotDrawFOV.Size = new System.Drawing.Size(362, 22);
            this.lblAimbotDrawFOV.TabIndex = 11;
            this.lblAimbotDrawFOV.Text = "Draw FOV";
            this.lblAimbotDrawFOV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbAimbotDrawFOV
            // 
            this.cbAimbotDrawFOV.Location = new System.Drawing.Point(397, 60);
            this.cbAimbotDrawFOV.Name = "cbAimbotDrawFOV";
            this.cbAimbotDrawFOV.Size = new System.Drawing.Size(38, 22);
            this.cbAimbotDrawFOV.TabIndex = 10;
            this.cbAimbotDrawFOV.CheckedChanged += new System.EventHandler(this.cbAimbotDrawFOV_CheckedChanged);
            // 
            // lblHitboxSelection
            // 
            this.lblHitboxSelection.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lblHitboxSelection.ForeColor = System.Drawing.Color.White;
            this.lblHitboxSelection.Location = new System.Drawing.Point(29, 88);
            this.lblHitboxSelection.Name = "lblHitboxSelection";
            this.lblHitboxSelection.Size = new System.Drawing.Size(406, 36);
            this.lblHitboxSelection.TabIndex = 13;
            this.lblHitboxSelection.Text = "Hitbox Selection";
            this.lblHitboxSelection.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbHitboxSelection
            // 
            this.cbHitboxSelection.BackColor = System.Drawing.Color.Transparent;
            this.cbHitboxSelection.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cbHitboxSelection.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbHitboxSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHitboxSelection.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.cbHitboxSelection.FocusedColor = System.Drawing.Color.White;
            this.cbHitboxSelection.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbHitboxSelection.ForeColor = System.Drawing.Color.White;
            this.cbHitboxSelection.FormattingEnabled = true;
            this.cbHitboxSelection.HoveredState.Parent = this.cbHitboxSelection;
            this.cbHitboxSelection.ItemHeight = 30;
            this.cbHitboxSelection.Items.AddRange(new object[] {
            "Head",
            "Body",
            "Foot"});
            this.cbHitboxSelection.ItemsAppearance.Parent = this.cbHitboxSelection;
            this.cbHitboxSelection.Location = new System.Drawing.Point(134, 88);
            this.cbHitboxSelection.Name = "cbHitboxSelection";
            this.cbHitboxSelection.ShadowDecoration.Parent = this.cbHitboxSelection;
            this.cbHitboxSelection.Size = new System.Drawing.Size(301, 36);
            this.cbHitboxSelection.StartIndex = 0;
            this.cbHitboxSelection.TabIndex = 14;
            this.cbHitboxSelection.SelectedIndexChanged += new System.EventHandler(this.cbHitboxSelection_SelectedIndexChanged);
            // 
            // lblTriggerBot
            // 
            this.lblTriggerBot.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lblTriggerBot.ForeColor = System.Drawing.Color.White;
            this.lblTriggerBot.Location = new System.Drawing.Point(13, 166);
            this.lblTriggerBot.Name = "lblTriggerBot";
            this.lblTriggerBot.Size = new System.Drawing.Size(378, 22);
            this.lblTriggerBot.TabIndex = 16;
            this.lblTriggerBot.Text = "Trigger Bot";
            this.lblTriggerBot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbTriggerBot
            // 
            this.cbTriggerBot.Location = new System.Drawing.Point(397, 166);
            this.cbTriggerBot.Name = "cbTriggerBot";
            this.cbTriggerBot.Size = new System.Drawing.Size(38, 22);
            this.cbTriggerBot.TabIndex = 15;
            this.cbTriggerBot.CheckedChanged += new System.EventHandler(this.cbTriggerBot_CheckedChanged);
            // 
            // lblInfAmmo
            // 
            this.lblInfAmmo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lblInfAmmo.ForeColor = System.Drawing.Color.White;
            this.lblInfAmmo.Location = new System.Drawing.Point(13, 194);
            this.lblInfAmmo.Name = "lblInfAmmo";
            this.lblInfAmmo.Size = new System.Drawing.Size(378, 22);
            this.lblInfAmmo.TabIndex = 18;
            this.lblInfAmmo.Text = "Infinite Ammo";
            this.lblInfAmmo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbInfAmmo
            // 
            this.cbInfAmmo.Location = new System.Drawing.Point(397, 194);
            this.cbInfAmmo.Name = "cbInfAmmo";
            this.cbInfAmmo.Size = new System.Drawing.Size(38, 22);
            this.cbInfAmmo.TabIndex = 17;
            this.cbInfAmmo.CheckedChanged += new System.EventHandler(this.cbInfAmmo_CheckedChanged);
            // 
            // lblRapidFire
            // 
            this.lblRapidFire.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lblRapidFire.ForeColor = System.Drawing.Color.White;
            this.lblRapidFire.Location = new System.Drawing.Point(13, 222);
            this.lblRapidFire.Name = "lblRapidFire";
            this.lblRapidFire.Size = new System.Drawing.Size(378, 22);
            this.lblRapidFire.TabIndex = 20;
            this.lblRapidFire.Text = "Rapid Fire";
            this.lblRapidFire.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbRapidFire
            // 
            this.cbRapidFire.Location = new System.Drawing.Point(397, 222);
            this.cbRapidFire.Name = "cbRapidFire";
            this.cbRapidFire.Size = new System.Drawing.Size(38, 22);
            this.cbRapidFire.TabIndex = 19;
            this.cbRapidFire.CheckedChanged += new System.EventHandler(this.cbRapidFire_CheckedChanged);
            // 
            // TabAiming
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Controls.Add(this.lblRapidFire);
            this.Controls.Add(this.cbRapidFire);
            this.Controls.Add(this.lblInfAmmo);
            this.Controls.Add(this.cbInfAmmo);
            this.Controls.Add(this.lblTriggerBot);
            this.Controls.Add(this.cbTriggerBot);
            this.Controls.Add(this.cbHitboxSelection);
            this.Controls.Add(this.lblHitboxSelection);
            this.Controls.Add(this.lblAimbotDrawFOV);
            this.Controls.Add(this.cbAimbotDrawFOV);
            this.Controls.Add(this.tbAimbotFOV);
            this.Controls.Add(this.lblAimbotFOVValue);
            this.Controls.Add(this.lblAimbotFOV);
            this.Controls.Add(this.lblAimbot);
            this.Controls.Add(this.cbAimbot);
            this.Name = "TabAiming";
            this.Size = new System.Drawing.Size(450, 371);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel lblAimbot;
        private Siticone.UI.WinForms.SiticoneOSToggleSwith cbAimbot;
        private Bunifu.Framework.UI.BunifuCustomLabel lblAimbotFOV;
        private Bunifu.Framework.UI.BunifuCustomLabel lblAimbotFOVValue;
        private Siticone.UI.WinForms.SiticoneMetroTrackBar tbAimbotFOV;
        private Bunifu.Framework.UI.BunifuCustomLabel lblAimbotDrawFOV;
        private Siticone.UI.WinForms.SiticoneOSToggleSwith cbAimbotDrawFOV;
        private Bunifu.Framework.UI.BunifuCustomLabel lblHitboxSelection;
        private Siticone.UI.WinForms.SiticoneComboBox cbHitboxSelection;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTriggerBot;
        private Siticone.UI.WinForms.SiticoneOSToggleSwith cbTriggerBot;
        private Bunifu.Framework.UI.BunifuCustomLabel lblInfAmmo;
        private Siticone.UI.WinForms.SiticoneOSToggleSwith cbInfAmmo;
        private Bunifu.Framework.UI.BunifuCustomLabel lblRapidFire;
        private Siticone.UI.WinForms.SiticoneOSToggleSwith cbRapidFire;
    }
}
