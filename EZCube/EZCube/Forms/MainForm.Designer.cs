
namespace EZCube.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnClose = new Siticone.UI.WinForms.SiticoneControlBox();
            this.btnMinimaze = new Siticone.UI.WinForms.SiticoneControlBox();
            this.plMenu = new System.Windows.Forms.Panel();
            this.btnEasyCube = new Siticone.UI.WinForms.SiticoneButton();
            this.btnMiscs = new Siticone.UI.WinForms.SiticoneButton();
            this.btnAiming = new Siticone.UI.WinForms.SiticoneButton();
            this.btnVisuals = new Siticone.UI.WinForms.SiticoneButton();
            this.siticoneSeparator1 = new Siticone.UI.WinForms.SiticoneSeparator();
            this.plPage = new System.Windows.Forms.Panel();
            this.lblProgram = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.siticoneSeparator2 = new Siticone.UI.WinForms.SiticoneSeparator();
            this.plMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnClose.HoveredState.Parent = this.btnClose;
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(460, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(45, 29);
            this.btnClose.TabIndex = 0;
            // 
            // btnMinimaze
            // 
            this.btnMinimaze.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimaze.ControlBoxType = Siticone.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.btnMinimaze.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnMinimaze.HoveredState.Parent = this.btnMinimaze;
            this.btnMinimaze.IconColor = System.Drawing.Color.White;
            this.btnMinimaze.Location = new System.Drawing.Point(415, 12);
            this.btnMinimaze.Name = "btnMinimaze";
            this.btnMinimaze.ShadowDecoration.Parent = this.btnMinimaze;
            this.btnMinimaze.Size = new System.Drawing.Size(45, 29);
            this.btnMinimaze.TabIndex = 1;
            // 
            // plMenu
            // 
            this.plMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.plMenu.Controls.Add(this.btnEasyCube);
            this.plMenu.Controls.Add(this.btnMiscs);
            this.plMenu.Controls.Add(this.btnAiming);
            this.plMenu.Controls.Add(this.btnVisuals);
            this.plMenu.Controls.Add(this.siticoneSeparator1);
            this.plMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.plMenu.Location = new System.Drawing.Point(0, 0);
            this.plMenu.Name = "plMenu";
            this.plMenu.Size = new System.Drawing.Size(67, 450);
            this.plMenu.TabIndex = 2;
            // 
            // btnEasyCube
            // 
            this.btnEasyCube.CheckedState.Parent = this.btnEasyCube;
            this.btnEasyCube.CustomImages.Parent = this.btnEasyCube;
            this.btnEasyCube.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.btnEasyCube.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.btnEasyCube.ForeColor = System.Drawing.Color.White;
            this.btnEasyCube.HoveredState.Parent = this.btnEasyCube;
            this.btnEasyCube.Image = ((System.Drawing.Image)(resources.GetObject("btnEasyCube.Image")));
            this.btnEasyCube.ImageSize = new System.Drawing.Size(25, 25);
            this.btnEasyCube.Location = new System.Drawing.Point(11, 12);
            this.btnEasyCube.Name = "btnEasyCube";
            this.btnEasyCube.ShadowDecoration.Parent = this.btnEasyCube;
            this.btnEasyCube.Size = new System.Drawing.Size(43, 45);
            this.btnEasyCube.TabIndex = 6;
            this.btnEasyCube.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            // 
            // btnMiscs
            // 
            this.btnMiscs.CheckedState.Parent = this.btnMiscs;
            this.btnMiscs.CustomImages.Parent = this.btnMiscs;
            this.btnMiscs.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.btnMiscs.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.btnMiscs.ForeColor = System.Drawing.Color.White;
            this.btnMiscs.HoveredState.Parent = this.btnMiscs;
            this.btnMiscs.Image = ((System.Drawing.Image)(resources.GetObject("btnMiscs.Image")));
            this.btnMiscs.ImageSize = new System.Drawing.Size(25, 25);
            this.btnMiscs.Location = new System.Drawing.Point(12, 181);
            this.btnMiscs.Name = "btnMiscs";
            this.btnMiscs.ShadowDecoration.Parent = this.btnMiscs;
            this.btnMiscs.Size = new System.Drawing.Size(43, 45);
            this.btnMiscs.TabIndex = 5;
            this.btnMiscs.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.btnMiscs.Click += new System.EventHandler(this.btnMiscs_Click);
            // 
            // btnAiming
            // 
            this.btnAiming.CheckedState.Parent = this.btnAiming;
            this.btnAiming.CustomImages.Parent = this.btnAiming;
            this.btnAiming.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.btnAiming.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.btnAiming.ForeColor = System.Drawing.Color.White;
            this.btnAiming.HoveredState.Parent = this.btnAiming;
            this.btnAiming.Image = ((System.Drawing.Image)(resources.GetObject("btnAiming.Image")));
            this.btnAiming.ImageSize = new System.Drawing.Size(25, 25);
            this.btnAiming.Location = new System.Drawing.Point(11, 130);
            this.btnAiming.Name = "btnAiming";
            this.btnAiming.ShadowDecoration.Parent = this.btnAiming;
            this.btnAiming.Size = new System.Drawing.Size(43, 45);
            this.btnAiming.TabIndex = 4;
            this.btnAiming.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.btnAiming.Click += new System.EventHandler(this.btnAiming_Click);
            // 
            // btnVisuals
            // 
            this.btnVisuals.CheckedState.Parent = this.btnVisuals;
            this.btnVisuals.CustomImages.Parent = this.btnVisuals;
            this.btnVisuals.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.btnVisuals.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.btnVisuals.ForeColor = System.Drawing.Color.White;
            this.btnVisuals.HoveredState.Parent = this.btnVisuals;
            this.btnVisuals.Image = ((System.Drawing.Image)(resources.GetObject("btnVisuals.Image")));
            this.btnVisuals.ImageSize = new System.Drawing.Size(25, 25);
            this.btnVisuals.Location = new System.Drawing.Point(11, 79);
            this.btnVisuals.Name = "btnVisuals";
            this.btnVisuals.ShadowDecoration.Parent = this.btnVisuals;
            this.btnVisuals.Size = new System.Drawing.Size(43, 45);
            this.btnVisuals.TabIndex = 3;
            this.btnVisuals.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.btnVisuals.Click += new System.EventHandler(this.btnVisuals_Click);
            // 
            // siticoneSeparator1
            // 
            this.siticoneSeparator1.Location = new System.Drawing.Point(11, 63);
            this.siticoneSeparator1.Name = "siticoneSeparator1";
            this.siticoneSeparator1.Size = new System.Drawing.Size(44, 10);
            this.siticoneSeparator1.TabIndex = 3;
            // 
            // plPage
            // 
            this.plPage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.plPage.Location = new System.Drawing.Point(67, 79);
            this.plPage.Name = "plPage";
            this.plPage.Size = new System.Drawing.Size(450, 371);
            this.plPage.TabIndex = 3;
            // 
            // lblProgram
            // 
            this.lblProgram.Font = new System.Drawing.Font("Segoe UI Semibold", 14F);
            this.lblProgram.ForeColor = System.Drawing.Color.White;
            this.lblProgram.Location = new System.Drawing.Point(73, 12);
            this.lblProgram.Name = "lblProgram";
            this.lblProgram.Size = new System.Drawing.Size(432, 45);
            this.lblProgram.TabIndex = 10;
            this.lblProgram.Text = "Easy Cube";
            this.lblProgram.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // siticoneSeparator2
            // 
            this.siticoneSeparator2.Location = new System.Drawing.Point(76, 63);
            this.siticoneSeparator2.Name = "siticoneSeparator2";
            this.siticoneSeparator2.Size = new System.Drawing.Size(429, 10);
            this.siticoneSeparator2.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(517, 450);
            this.Controls.Add(this.btnMinimaze);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.siticoneSeparator2);
            this.Controls.Add(this.lblProgram);
            this.Controls.Add(this.plPage);
            this.Controls.Add(this.plMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.plMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.UI.WinForms.SiticoneControlBox btnClose;
        private Siticone.UI.WinForms.SiticoneControlBox btnMinimaze;
        private System.Windows.Forms.Panel plMenu;
        private Siticone.UI.WinForms.SiticoneSeparator siticoneSeparator1;
        private Siticone.UI.WinForms.SiticoneButton btnEasyCube;
        private Siticone.UI.WinForms.SiticoneButton btnMiscs;
        private Siticone.UI.WinForms.SiticoneButton btnAiming;
        private Siticone.UI.WinForms.SiticoneButton btnVisuals;
        private System.Windows.Forms.Panel plPage;
        private Bunifu.Framework.UI.BunifuCustomLabel lblProgram;
        private Siticone.UI.WinForms.SiticoneSeparator siticoneSeparator2;
    }
}