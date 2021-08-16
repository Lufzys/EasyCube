
namespace EZCube.Forms.Tabs
{
    partial class TabMiscs
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
            this.lblFly = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cbFly = new Siticone.UI.WinForms.SiticoneOSToggleSwith();
            this.lblBunnyHop = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cbBunnyHop = new Siticone.UI.WinForms.SiticoneOSToggleSwith();
            this.lblStreamproof = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cbStreamproof = new Siticone.UI.WinForms.SiticoneOSToggleSwith();
            this.lblInfHealth = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cbInfHealth = new Siticone.UI.WinForms.SiticoneOSToggleSwith();
            this.lblInfArmor = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cbInfArmor = new Siticone.UI.WinForms.SiticoneOSToggleSwith();
            this.lblTelekill = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cbTelekill = new Siticone.UI.WinForms.SiticoneOSToggleSwith();
            this.lblTeleportEnemiesOnFrontOf = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cbTeleportEnemies = new Siticone.UI.WinForms.SiticoneOSToggleSwith();
            this.SuspendLayout();
            // 
            // lblFly
            // 
            this.lblFly.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lblFly.ForeColor = System.Drawing.Color.White;
            this.lblFly.Location = new System.Drawing.Point(13, 91);
            this.lblFly.Name = "lblFly";
            this.lblFly.Size = new System.Drawing.Size(378, 22);
            this.lblFly.TabIndex = 3;
            this.lblFly.Text = "Fly";
            this.lblFly.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbFly
            // 
            this.cbFly.Location = new System.Drawing.Point(397, 91);
            this.cbFly.Name = "cbFly";
            this.cbFly.Size = new System.Drawing.Size(38, 22);
            this.cbFly.TabIndex = 2;
            this.cbFly.CheckedChanged += new System.EventHandler(this.cbFly_CheckedChanged);
            // 
            // lblBunnyHop
            // 
            this.lblBunnyHop.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lblBunnyHop.ForeColor = System.Drawing.Color.White;
            this.lblBunnyHop.Location = new System.Drawing.Point(13, 63);
            this.lblBunnyHop.Name = "lblBunnyHop";
            this.lblBunnyHop.Size = new System.Drawing.Size(378, 22);
            this.lblBunnyHop.TabIndex = 5;
            this.lblBunnyHop.Text = "Bunny Hop";
            this.lblBunnyHop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbBunnyHop
            // 
            this.cbBunnyHop.Location = new System.Drawing.Point(397, 63);
            this.cbBunnyHop.Name = "cbBunnyHop";
            this.cbBunnyHop.Size = new System.Drawing.Size(38, 22);
            this.cbBunnyHop.TabIndex = 4;
            this.cbBunnyHop.CheckedChanged += new System.EventHandler(this.cbBunnyHop_CheckedChanged);
            // 
            // lblStreamproof
            // 
            this.lblStreamproof.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lblStreamproof.ForeColor = System.Drawing.Color.White;
            this.lblStreamproof.Location = new System.Drawing.Point(13, 339);
            this.lblStreamproof.Name = "lblStreamproof";
            this.lblStreamproof.Size = new System.Drawing.Size(378, 22);
            this.lblStreamproof.TabIndex = 7;
            this.lblStreamproof.Text = "Stream proof";
            this.lblStreamproof.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbStreamproof
            // 
            this.cbStreamproof.Location = new System.Drawing.Point(397, 339);
            this.cbStreamproof.Name = "cbStreamproof";
            this.cbStreamproof.Size = new System.Drawing.Size(38, 22);
            this.cbStreamproof.TabIndex = 6;
            this.cbStreamproof.CheckedChanged += new System.EventHandler(this.cbStreamproof_CheckedChanged);
            // 
            // lblInfHealth
            // 
            this.lblInfHealth.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lblInfHealth.ForeColor = System.Drawing.Color.White;
            this.lblInfHealth.Location = new System.Drawing.Point(13, 7);
            this.lblInfHealth.Name = "lblInfHealth";
            this.lblInfHealth.Size = new System.Drawing.Size(378, 22);
            this.lblInfHealth.TabIndex = 9;
            this.lblInfHealth.Text = "Infinite Health";
            this.lblInfHealth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbInfHealth
            // 
            this.cbInfHealth.Location = new System.Drawing.Point(397, 7);
            this.cbInfHealth.Name = "cbInfHealth";
            this.cbInfHealth.Size = new System.Drawing.Size(38, 22);
            this.cbInfHealth.TabIndex = 8;
            this.cbInfHealth.CheckedChanged += new System.EventHandler(this.cbInfHealth_CheckedChanged);
            // 
            // lblInfArmor
            // 
            this.lblInfArmor.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lblInfArmor.ForeColor = System.Drawing.Color.White;
            this.lblInfArmor.Location = new System.Drawing.Point(13, 35);
            this.lblInfArmor.Name = "lblInfArmor";
            this.lblInfArmor.Size = new System.Drawing.Size(378, 22);
            this.lblInfArmor.TabIndex = 11;
            this.lblInfArmor.Text = "Infinite Armor";
            this.lblInfArmor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbInfArmor
            // 
            this.cbInfArmor.Location = new System.Drawing.Point(397, 35);
            this.cbInfArmor.Name = "cbInfArmor";
            this.cbInfArmor.Size = new System.Drawing.Size(38, 22);
            this.cbInfArmor.TabIndex = 10;
            this.cbInfArmor.CheckedChanged += new System.EventHandler(this.cbInfArmor_CheckedChanged);
            // 
            // lblTelekill
            // 
            this.lblTelekill.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lblTelekill.ForeColor = System.Drawing.Color.White;
            this.lblTelekill.Location = new System.Drawing.Point(13, 119);
            this.lblTelekill.Name = "lblTelekill";
            this.lblTelekill.Size = new System.Drawing.Size(378, 22);
            this.lblTelekill.TabIndex = 15;
            this.lblTelekill.Text = "Telekill";
            this.lblTelekill.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbTelekill
            // 
            this.cbTelekill.Location = new System.Drawing.Point(397, 119);
            this.cbTelekill.Name = "cbTelekill";
            this.cbTelekill.Size = new System.Drawing.Size(38, 22);
            this.cbTelekill.TabIndex = 14;
            this.cbTelekill.CheckedChanged += new System.EventHandler(this.cbTelekill_CheckedChanged);
            // 
            // lblTeleportEnemiesOnFrontOf
            // 
            this.lblTeleportEnemiesOnFrontOf.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lblTeleportEnemiesOnFrontOf.ForeColor = System.Drawing.Color.White;
            this.lblTeleportEnemiesOnFrontOf.Location = new System.Drawing.Point(13, 147);
            this.lblTeleportEnemiesOnFrontOf.Name = "lblTeleportEnemiesOnFrontOf";
            this.lblTeleportEnemiesOnFrontOf.Size = new System.Drawing.Size(378, 22);
            this.lblTeleportEnemiesOnFrontOf.TabIndex = 13;
            this.lblTeleportEnemiesOnFrontOf.Text = "Teleport Enemies On Front Of";
            this.lblTeleportEnemiesOnFrontOf.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbTeleportEnemies
            // 
            this.cbTeleportEnemies.Location = new System.Drawing.Point(397, 147);
            this.cbTeleportEnemies.Name = "cbTeleportEnemies";
            this.cbTeleportEnemies.Size = new System.Drawing.Size(38, 22);
            this.cbTeleportEnemies.TabIndex = 12;
            this.cbTeleportEnemies.CheckedChanged += new System.EventHandler(this.cbTeleportEnemies_CheckedChanged);
            // 
            // TabMiscs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Controls.Add(this.lblTelekill);
            this.Controls.Add(this.cbTelekill);
            this.Controls.Add(this.lblTeleportEnemiesOnFrontOf);
            this.Controls.Add(this.cbTeleportEnemies);
            this.Controls.Add(this.lblInfArmor);
            this.Controls.Add(this.cbInfArmor);
            this.Controls.Add(this.lblInfHealth);
            this.Controls.Add(this.cbInfHealth);
            this.Controls.Add(this.lblStreamproof);
            this.Controls.Add(this.cbStreamproof);
            this.Controls.Add(this.lblBunnyHop);
            this.Controls.Add(this.cbBunnyHop);
            this.Controls.Add(this.lblFly);
            this.Controls.Add(this.cbFly);
            this.Name = "TabMiscs";
            this.Size = new System.Drawing.Size(450, 371);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel lblFly;
        private Siticone.UI.WinForms.SiticoneOSToggleSwith cbFly;
        private Bunifu.Framework.UI.BunifuCustomLabel lblBunnyHop;
        private Siticone.UI.WinForms.SiticoneOSToggleSwith cbBunnyHop;
        private Bunifu.Framework.UI.BunifuCustomLabel lblStreamproof;
        private Siticone.UI.WinForms.SiticoneOSToggleSwith cbStreamproof;
        private Bunifu.Framework.UI.BunifuCustomLabel lblInfHealth;
        private Siticone.UI.WinForms.SiticoneOSToggleSwith cbInfHealth;
        private Bunifu.Framework.UI.BunifuCustomLabel lblInfArmor;
        private Siticone.UI.WinForms.SiticoneOSToggleSwith cbInfArmor;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTelekill;
        private Siticone.UI.WinForms.SiticoneOSToggleSwith cbTelekill;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTeleportEnemiesOnFrontOf;
        private Siticone.UI.WinForms.SiticoneOSToggleSwith cbTeleportEnemies;
    }
}
