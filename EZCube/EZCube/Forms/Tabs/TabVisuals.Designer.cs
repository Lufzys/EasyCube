
namespace EZCube.Forms.Tabs
{
    partial class TabVisuals
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
            this.cbESP = new Siticone.UI.WinForms.SiticoneOSToggleSwith();
            this.lblESP = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblESPOutline = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cbESPOutline = new Siticone.UI.WinForms.SiticoneOSToggleSwith();
            this.lblESPHealthBar = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cbESPHealthBar = new Siticone.UI.WinForms.SiticoneOSToggleSwith();
            this.lblESPArmorBar = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cbESPArmorBar = new Siticone.UI.WinForms.SiticoneOSToggleSwith();
            this.lblESPName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cbESPName = new Siticone.UI.WinForms.SiticoneOSToggleSwith();
            this.lblESPHealthBarOutline = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cbESPHealthBarOutline = new Siticone.UI.WinForms.SiticoneOSToggleSwith();
            this.lblESPArmorBarOutline = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cbESPArmorBarOutline = new Siticone.UI.WinForms.SiticoneOSToggleSwith();
            this.lblESPDistance = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cbESPDistance = new Siticone.UI.WinForms.SiticoneOSToggleSwith();
            this.lblSnaplinesOutline = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cbSnaplinesOutline = new Siticone.UI.WinForms.SiticoneOSToggleSwith();
            this.lblSnaplines = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cbSnaplines = new Siticone.UI.WinForms.SiticoneOSToggleSwith();
            this.lblCrosshair = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cbCrosshair = new Siticone.UI.WinForms.SiticoneOSToggleSwith();
            this.lblWatermark = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cbWatermark = new Siticone.UI.WinForms.SiticoneOSToggleSwith();
            this.SuspendLayout();
            // 
            // cbESP
            // 
            this.cbESP.Location = new System.Drawing.Point(397, 7);
            this.cbESP.Name = "cbESP";
            this.cbESP.Size = new System.Drawing.Size(38, 22);
            this.cbESP.TabIndex = 0;
            this.cbESP.CheckedChanged += new System.EventHandler(this.cbESP_CheckedChanged);
            // 
            // lblESP
            // 
            this.lblESP.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lblESP.ForeColor = System.Drawing.Color.White;
            this.lblESP.Location = new System.Drawing.Point(13, 7);
            this.lblESP.Name = "lblESP";
            this.lblESP.Size = new System.Drawing.Size(378, 22);
            this.lblESP.TabIndex = 1;
            this.lblESP.Text = "ESP";
            this.lblESP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblESPOutline
            // 
            this.lblESPOutline.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lblESPOutline.ForeColor = System.Drawing.Color.White;
            this.lblESPOutline.Location = new System.Drawing.Point(29, 35);
            this.lblESPOutline.Name = "lblESPOutline";
            this.lblESPOutline.Size = new System.Drawing.Size(362, 22);
            this.lblESPOutline.TabIndex = 3;
            this.lblESPOutline.Text = "Outline";
            this.lblESPOutline.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbESPOutline
            // 
            this.cbESPOutline.Location = new System.Drawing.Point(397, 35);
            this.cbESPOutline.Name = "cbESPOutline";
            this.cbESPOutline.Size = new System.Drawing.Size(38, 22);
            this.cbESPOutline.TabIndex = 2;
            this.cbESPOutline.CheckedChanged += new System.EventHandler(this.cbESPOutline_CheckedChanged);
            // 
            // lblESPHealthBar
            // 
            this.lblESPHealthBar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lblESPHealthBar.ForeColor = System.Drawing.Color.White;
            this.lblESPHealthBar.Location = new System.Drawing.Point(26, 94);
            this.lblESPHealthBar.Name = "lblESPHealthBar";
            this.lblESPHealthBar.Size = new System.Drawing.Size(365, 22);
            this.lblESPHealthBar.TabIndex = 5;
            this.lblESPHealthBar.Text = "Health bar";
            this.lblESPHealthBar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbESPHealthBar
            // 
            this.cbESPHealthBar.Location = new System.Drawing.Point(397, 94);
            this.cbESPHealthBar.Name = "cbESPHealthBar";
            this.cbESPHealthBar.Size = new System.Drawing.Size(38, 22);
            this.cbESPHealthBar.TabIndex = 4;
            this.cbESPHealthBar.CheckedChanged += new System.EventHandler(this.cbESPHealthBar_CheckedChanged);
            // 
            // lblESPArmorBar
            // 
            this.lblESPArmorBar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lblESPArmorBar.ForeColor = System.Drawing.Color.White;
            this.lblESPArmorBar.Location = new System.Drawing.Point(26, 150);
            this.lblESPArmorBar.Name = "lblESPArmorBar";
            this.lblESPArmorBar.Size = new System.Drawing.Size(365, 22);
            this.lblESPArmorBar.TabIndex = 7;
            this.lblESPArmorBar.Text = "Armor Bar";
            this.lblESPArmorBar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbESPArmorBar
            // 
            this.cbESPArmorBar.Location = new System.Drawing.Point(397, 150);
            this.cbESPArmorBar.Name = "cbESPArmorBar";
            this.cbESPArmorBar.Size = new System.Drawing.Size(38, 22);
            this.cbESPArmorBar.TabIndex = 6;
            this.cbESPArmorBar.CheckedChanged += new System.EventHandler(this.cbESPArmorBar_CheckedChanged);
            // 
            // lblESPName
            // 
            this.lblESPName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lblESPName.ForeColor = System.Drawing.Color.White;
            this.lblESPName.Location = new System.Drawing.Point(26, 66);
            this.lblESPName.Name = "lblESPName";
            this.lblESPName.Size = new System.Drawing.Size(365, 22);
            this.lblESPName.TabIndex = 9;
            this.lblESPName.Text = "Name";
            this.lblESPName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbESPName
            // 
            this.cbESPName.Location = new System.Drawing.Point(397, 66);
            this.cbESPName.Name = "cbESPName";
            this.cbESPName.Size = new System.Drawing.Size(38, 22);
            this.cbESPName.TabIndex = 8;
            this.cbESPName.CheckedChanged += new System.EventHandler(this.cbESPName_CheckedChanged);
            // 
            // lblESPHealthBarOutline
            // 
            this.lblESPHealthBarOutline.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lblESPHealthBarOutline.ForeColor = System.Drawing.Color.White;
            this.lblESPHealthBarOutline.Location = new System.Drawing.Point(41, 122);
            this.lblESPHealthBarOutline.Name = "lblESPHealthBarOutline";
            this.lblESPHealthBarOutline.Size = new System.Drawing.Size(350, 22);
            this.lblESPHealthBarOutline.TabIndex = 11;
            this.lblESPHealthBarOutline.Text = "Outline";
            this.lblESPHealthBarOutline.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbESPHealthBarOutline
            // 
            this.cbESPHealthBarOutline.Location = new System.Drawing.Point(397, 122);
            this.cbESPHealthBarOutline.Name = "cbESPHealthBarOutline";
            this.cbESPHealthBarOutline.Size = new System.Drawing.Size(38, 22);
            this.cbESPHealthBarOutline.TabIndex = 10;
            this.cbESPHealthBarOutline.CheckedChanged += new System.EventHandler(this.cbESPHealthBarOutline_CheckedChanged);
            // 
            // lblESPArmorBarOutline
            // 
            this.lblESPArmorBarOutline.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lblESPArmorBarOutline.ForeColor = System.Drawing.Color.White;
            this.lblESPArmorBarOutline.Location = new System.Drawing.Point(41, 178);
            this.lblESPArmorBarOutline.Name = "lblESPArmorBarOutline";
            this.lblESPArmorBarOutline.Size = new System.Drawing.Size(350, 22);
            this.lblESPArmorBarOutline.TabIndex = 13;
            this.lblESPArmorBarOutline.Text = "Outline";
            this.lblESPArmorBarOutline.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbESPArmorBarOutline
            // 
            this.cbESPArmorBarOutline.Location = new System.Drawing.Point(397, 178);
            this.cbESPArmorBarOutline.Name = "cbESPArmorBarOutline";
            this.cbESPArmorBarOutline.Size = new System.Drawing.Size(38, 22);
            this.cbESPArmorBarOutline.TabIndex = 12;
            this.cbESPArmorBarOutline.CheckedChanged += new System.EventHandler(this.cbESPArmorBarOutline_CheckedChanged);
            // 
            // lblESPDistance
            // 
            this.lblESPDistance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lblESPDistance.ForeColor = System.Drawing.Color.White;
            this.lblESPDistance.Location = new System.Drawing.Point(26, 262);
            this.lblESPDistance.Name = "lblESPDistance";
            this.lblESPDistance.Size = new System.Drawing.Size(365, 22);
            this.lblESPDistance.TabIndex = 15;
            this.lblESPDistance.Text = "Distance";
            this.lblESPDistance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbESPDistance
            // 
            this.cbESPDistance.Location = new System.Drawing.Point(397, 262);
            this.cbESPDistance.Name = "cbESPDistance";
            this.cbESPDistance.Size = new System.Drawing.Size(38, 22);
            this.cbESPDistance.TabIndex = 14;
            this.cbESPDistance.CheckedChanged += new System.EventHandler(this.cbESPDistance_CheckedChanged);
            // 
            // lblSnaplinesOutline
            // 
            this.lblSnaplinesOutline.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lblSnaplinesOutline.ForeColor = System.Drawing.Color.White;
            this.lblSnaplinesOutline.Location = new System.Drawing.Point(41, 234);
            this.lblSnaplinesOutline.Name = "lblSnaplinesOutline";
            this.lblSnaplinesOutline.Size = new System.Drawing.Size(350, 22);
            this.lblSnaplinesOutline.TabIndex = 21;
            this.lblSnaplinesOutline.Text = "Outline";
            this.lblSnaplinesOutline.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbSnaplinesOutline
            // 
            this.cbSnaplinesOutline.Location = new System.Drawing.Point(397, 234);
            this.cbSnaplinesOutline.Name = "cbSnaplinesOutline";
            this.cbSnaplinesOutline.Size = new System.Drawing.Size(38, 22);
            this.cbSnaplinesOutline.TabIndex = 20;
            this.cbSnaplinesOutline.CheckedChanged += new System.EventHandler(this.cbSnaplinesOutline_CheckedChanged);
            // 
            // lblSnaplines
            // 
            this.lblSnaplines.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lblSnaplines.ForeColor = System.Drawing.Color.White;
            this.lblSnaplines.Location = new System.Drawing.Point(26, 206);
            this.lblSnaplines.Name = "lblSnaplines";
            this.lblSnaplines.Size = new System.Drawing.Size(365, 22);
            this.lblSnaplines.TabIndex = 19;
            this.lblSnaplines.Text = "Snaplines";
            this.lblSnaplines.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbSnaplines
            // 
            this.cbSnaplines.Location = new System.Drawing.Point(397, 206);
            this.cbSnaplines.Name = "cbSnaplines";
            this.cbSnaplines.Size = new System.Drawing.Size(38, 22);
            this.cbSnaplines.TabIndex = 18;
            this.cbSnaplines.CheckedChanged += new System.EventHandler(this.cbSnaplines_CheckedChanged);
            // 
            // lblCrosshair
            // 
            this.lblCrosshair.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lblCrosshair.ForeColor = System.Drawing.Color.White;
            this.lblCrosshair.Location = new System.Drawing.Point(13, 339);
            this.lblCrosshair.Name = "lblCrosshair";
            this.lblCrosshair.Size = new System.Drawing.Size(378, 22);
            this.lblCrosshair.TabIndex = 23;
            this.lblCrosshair.Text = "Crosshair";
            this.lblCrosshair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbCrosshair
            // 
            this.cbCrosshair.Location = new System.Drawing.Point(397, 339);
            this.cbCrosshair.Name = "cbCrosshair";
            this.cbCrosshair.Size = new System.Drawing.Size(38, 22);
            this.cbCrosshair.TabIndex = 22;
            this.cbCrosshair.CheckedChanged += new System.EventHandler(this.cbCrosshair_CheckedChanged);
            // 
            // lblWatermark
            // 
            this.lblWatermark.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lblWatermark.ForeColor = System.Drawing.Color.White;
            this.lblWatermark.Location = new System.Drawing.Point(13, 311);
            this.lblWatermark.Name = "lblWatermark";
            this.lblWatermark.Size = new System.Drawing.Size(378, 22);
            this.lblWatermark.TabIndex = 25;
            this.lblWatermark.Text = "Watermark";
            this.lblWatermark.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbWatermark
            // 
            this.cbWatermark.Checked = true;
            this.cbWatermark.Location = new System.Drawing.Point(397, 311);
            this.cbWatermark.Name = "cbWatermark";
            this.cbWatermark.Size = new System.Drawing.Size(38, 22);
            this.cbWatermark.TabIndex = 24;
            this.cbWatermark.CheckedChanged += new System.EventHandler(this.cbWatermark_CheckedChanged);
            // 
            // TabVisuals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Controls.Add(this.lblWatermark);
            this.Controls.Add(this.cbWatermark);
            this.Controls.Add(this.lblCrosshair);
            this.Controls.Add(this.cbCrosshair);
            this.Controls.Add(this.lblSnaplinesOutline);
            this.Controls.Add(this.cbSnaplinesOutline);
            this.Controls.Add(this.lblSnaplines);
            this.Controls.Add(this.cbSnaplines);
            this.Controls.Add(this.lblESPDistance);
            this.Controls.Add(this.cbESPDistance);
            this.Controls.Add(this.lblESPArmorBarOutline);
            this.Controls.Add(this.cbESPArmorBarOutline);
            this.Controls.Add(this.lblESPHealthBarOutline);
            this.Controls.Add(this.cbESPHealthBarOutline);
            this.Controls.Add(this.lblESPName);
            this.Controls.Add(this.cbESPName);
            this.Controls.Add(this.lblESPArmorBar);
            this.Controls.Add(this.cbESPArmorBar);
            this.Controls.Add(this.lblESPHealthBar);
            this.Controls.Add(this.cbESPHealthBar);
            this.Controls.Add(this.lblESPOutline);
            this.Controls.Add(this.cbESPOutline);
            this.Controls.Add(this.lblESP);
            this.Controls.Add(this.cbESP);
            this.Name = "TabVisuals";
            this.Size = new System.Drawing.Size(450, 371);
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.UI.WinForms.SiticoneOSToggleSwith cbESP;
        private Bunifu.Framework.UI.BunifuCustomLabel lblESP;
        private Bunifu.Framework.UI.BunifuCustomLabel lblESPOutline;
        private Siticone.UI.WinForms.SiticoneOSToggleSwith cbESPOutline;
        private Bunifu.Framework.UI.BunifuCustomLabel lblESPHealthBar;
        private Siticone.UI.WinForms.SiticoneOSToggleSwith cbESPHealthBar;
        private Bunifu.Framework.UI.BunifuCustomLabel lblESPArmorBar;
        private Siticone.UI.WinForms.SiticoneOSToggleSwith cbESPArmorBar;
        private Bunifu.Framework.UI.BunifuCustomLabel lblESPName;
        private Siticone.UI.WinForms.SiticoneOSToggleSwith cbESPName;
        private Bunifu.Framework.UI.BunifuCustomLabel lblESPHealthBarOutline;
        private Siticone.UI.WinForms.SiticoneOSToggleSwith cbESPHealthBarOutline;
        private Bunifu.Framework.UI.BunifuCustomLabel lblESPArmorBarOutline;
        private Siticone.UI.WinForms.SiticoneOSToggleSwith cbESPArmorBarOutline;
        private Bunifu.Framework.UI.BunifuCustomLabel lblESPDistance;
        private Siticone.UI.WinForms.SiticoneOSToggleSwith cbESPDistance;
        private Bunifu.Framework.UI.BunifuCustomLabel lblSnaplinesOutline;
        private Siticone.UI.WinForms.SiticoneOSToggleSwith cbSnaplinesOutline;
        private Bunifu.Framework.UI.BunifuCustomLabel lblSnaplines;
        private Siticone.UI.WinForms.SiticoneOSToggleSwith cbSnaplines;
        private Bunifu.Framework.UI.BunifuCustomLabel lblCrosshair;
        private Siticone.UI.WinForms.SiticoneOSToggleSwith cbCrosshair;
        private Bunifu.Framework.UI.BunifuCustomLabel lblWatermark;
        private Siticone.UI.WinForms.SiticoneOSToggleSwith cbWatermark;
    }
}
