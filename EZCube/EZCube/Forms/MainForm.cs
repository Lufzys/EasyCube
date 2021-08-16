using EZCube.Classes;
using EZCube.Classes.SDK.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Globals;

namespace EZCube.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            plPage.ChangePage(Tabs.Tabs.Visuals);
            this.ChangeTheme(new Classes.Variables.Structs.AccentPolicy { AccentState = Classes.Variables.Enums.AccentState.ACCENT_ENABLE_HOSTBACKDROP }, true);
            new Utils.DragObj(this, this);
            new Utils.DragObj(this, lblProgram);
            new Utils.DragObj(this, plPage);
            new Utils.DragObj(this, plMenu);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if(Process.GetProcessesByName("ac_client").Length != 0)
            {
                Globals.mem.Initialize();
                Globals.overlay.LockWindow(Process.GetProcessesByName("ac_client").FirstOrDefault(), true);
                Globals.overlay.Draw(new PaintEventHandler(DrawOverlay), Overlay.EventInsertionType.ADD);
                Globals.overlay.Run();
            }
            else
            {
                MessageBox.Show("Please first open assault cube!", "EasyCube", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Environment.Exit(0);
            }
        }

        private void btnVisuals_Click(object sender, EventArgs e)
        {
            plPage.ChangePage(Tabs.Tabs.Visuals);
        }
        private void btnAiming_Click(object sender, EventArgs e)
        {
            plPage.ChangePage(Tabs.Tabs.Aiming);
        }

        private void btnMiscs_Click(object sender, EventArgs e)
        {
            plPage.ChangePage(Tabs.Tabs.Miscs);
        }

        List<Player> Players = new List<Player>();
        bool IsDead = false;
        private void DrawOverlay(object sender, PaintEventArgs e)
        {
            try
            {
                if (Process.GetProcessesByName("ac_client").Length == 0)
                    Environment.Exit(0);

                 e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                Players.Clear();
                Player ClosestPlayer = default(Player);
                Vector2 Crosshair = new Vector2(overlay.CenterX, overlay.CenterY);
                float Dist = 99999f;

                Player LocalPlayer = new Player(mem.Read<int>(Offsets.Client + Offsets.LocalPlayer));
                int EntityList = mem.Read<int>(Offsets.Client + Offsets.EntityList);
                int NumPlayers = mem.Read<int>(Offsets.Client + Offsets.PlayersCount);
                for (int i = 0; i < NumPlayers; i++)
                {
                    Player Entity = new Player(mem.Read<int>(EntityList + (i * 0x04)));
                    if (Entity == LocalPlayer) continue;
                    if (Entity.Health < 1) continue;
                    Players.Add(Entity);
                    float[] Viewmatrix = mem.ReadMatrix<float>(Offsets.Viewmatrix, 16);
                    if (WorldToScreen(Entity.FootPosition, out Vector2 footPos, Viewmatrix, overlay.Width, overlay.Height) && WorldToScreen(Entity.HeadPosition, out Vector2 headPos, Viewmatrix, overlay.Width, overlay.Height))
                    {
                        float height = Math.Abs(headPos.Y - footPos.Y);
                        float width = height / 2;
                        int offset = 20;
                        if (width == 0) continue;
                        SizeF textSize = e.Graphics.MeasureString(Entity.Name, new Font("Consolas", width / 6));
                        int distance = (int)Vector3.Distance(LocalPlayer.FootPosition, Entity.FootPosition);
                        SizeF DistTextSize = e.Graphics.MeasureString(distance.ToString(), new Font("Consolas", width / 6));

                        if (Settings.Snaplines)
                        {
                            if (Settings.Snaplines_Outline)
                            {
                                e.Graphics.DrawLine(new Pen(Color.Black, 3f), overlay.CenterX, overlay.Height, footPos.X, footPos.Y);
                            }
                            e.Graphics.DrawLine(Entity.Team == Classes.SDK.Variables.Enums.Team.CLA ? Pens.Red : Pens.Blue, overlay.CenterX, overlay.Height, footPos.X, footPos.Y);
                        }
                        if (Settings.Distance)
                        {
                            e.Graphics.DrawString(distance.ToString(), new Font("Consolas", width / 6), Brushes.White, footPos.X - DistTextSize.Width / 2, footPos.Y);
                        }
                        if (Settings.ESP_Name)
                        {
                            e.Graphics.DrawString(Entity.Name, new Font("Consolas", width / 6), Brushes.White/*Entity.Team == Classes.SDK.Variables.Enums.Team.CLA ? Brushes.Red : Brushes.Blue*/, footPos.X - textSize.Width / 2, headPos.Y - (offset + 5) - textSize.Height);
                        }
                        if (Settings.ESP)
                        {
                            if (Settings.ESP_Outline)
                            {
                                e.Graphics.DrawRectangle(new Pen(Color.Black, 3f), headPos.X - width / 2, headPos.Y - offset, width, height + offset);
                            }
                            e.Graphics.DrawRectangle(Entity.Team == Classes.SDK.Variables.Enums.Team.CLA ? Pens.Red : Pens.Blue, headPos.X - width / 2, headPos.Y - offset, width, height + offset);
                        }
                        if (Settings.ESP_Health)
                        {
                            if (Settings.ESP_Health_Outline)
                            {
                                e.Graphics.DrawRectangle(Pens.Black, headPos.X - width / 2 - width / 4, headPos.Y - offset, width / 6, (height + offset));
                            }
                            e.Graphics.FillRectangle(Brushes.Green, headPos.X - width / 2 - width / 4, headPos.Y - offset, width / 6, (height + offset) / 100 * Entity.Health);
                        }
                        if (Settings.ESP_Armor)
                        {
                            if (Entity.Armor != 0)
                            {
                                if (Settings.ESP_Armor_Outline)
                                {
                                    e.Graphics.DrawRectangle(Pens.Black, headPos.X - width / 2 + width / 8 + width, headPos.Y - offset, width / 6, (height + offset));
                                }
                                e.Graphics.FillRectangle(Brushes.Gray, headPos.X - width / 2 + width / 8 + width, headPos.Y - offset, width / 6, (height + offset) / 100 * Entity.Armor);
                            }
                        }

                        if (Settings.Aimbot)
                        {
                            if (Entity.Team != LocalPlayer.Team)
                            {
                                float EntDist = Vector2.Distance(Crosshair, headPos);
                                if (EntDist > -Settings.Aimbot_FOV / 2 && EntDist < Settings.Aimbot_FOV / 2)
                                {
                                    if (EntDist < Dist)
                                    {
                                        ClosestPlayer = Entity;
                                        Dist = EntDist;
                                    }
                                }
                            }
                        }
                    }
                }

                if (Settings.TriggerBot)
                {
                    bool shoot = true;
                    string onCrosshairTarget = mem.ReadStringASCII(Offsets.CrosshairTarget, 17).Trim();
                    if (onCrosshairTarget != string.Empty)
                    {
                        foreach (Player plr in Players)
                        {
                            if (plr.Team != LocalPlayer.Team) continue;
                            if (plr.Name.Trim() == onCrosshairTarget)
                            {
                                shoot = false;
                            }
                        }

                        if (shoot)
                            mem.Write<int>(LocalPlayer.Address + Offsets.ForceAttack, 1);
                    }
                    else
                    {
                        mem.Write<int>(LocalPlayer.Address + Offsets.ForceAttack, 0);
                    }
                    mem.Write<int>(Offsets.CrosshairTarget, 0); // Reset Target On Crosshair Name
                }
                if (Settings.RapidFire)
                {
                    if (LocalPlayer.CurrentWeapon().DelayTime != 0)
                    {
                        LocalPlayer.CurrentWeapon().DelayTime = 0;
                    }
                }
                if (Settings.InfiniteAmmo)
                {
                    if (LocalPlayer.CurrentWeapon().Ammo < 1)
                    {
                        LocalPlayer.CurrentWeapon().Ammo = 30;
                    }
                }
                if (Settings.Watermark)
                {
                    e.Graphics.DrawString(Settings.Watermark_Text, new Font("Consolas", 12f), Brushes.White, 10, 10);
                }
                if (Settings.Aimbot_FOV_Draw)
                {
                    e.Graphics.DrawEllipse(Pens.White, overlay.CenterX - Settings.Aimbot_FOV / 2, overlay.CenterY - Settings.Aimbot_FOV / 2, Settings.Aimbot_FOV, Settings.Aimbot_FOV);
                }
                if (Settings.Aimbot)
                {
                    if (ClosestPlayer != null && Utils.IsKeyPushedDown(Keys.RButton))
                    {
                        float dx = ClosestPlayer.HeadPosition.X - LocalPlayer.HeadPosition.X;
                        float dy = ClosestPlayer.HeadPosition.Y - LocalPlayer.HeadPosition.Y;
                        double angleYaw = Math.Atan2(dy, dx) * 180 / Math.PI;

                        //calculate verticle angle between enemy and player (pitch)
                        double distance = Math.Sqrt(dx * dx + dy * dy);
                        float dz = 0f;
                        if (Settings.Aimbot_Hitbox == Classes.SDK.Variables.Enums.Hitbox.Head)
                        {
                            dz = ClosestPlayer.HeadPosition.Z - LocalPlayer.HeadPosition.Z;
                        }
                        else if (Settings.Aimbot_Hitbox == Classes.SDK.Variables.Enums.Hitbox.Body)
                        {
                            dz = ClosestPlayer.HeadPosition.Z - LocalPlayer.HeadPosition.Z - mem.Read<float>(ClosestPlayer.Address + Offsets.Height) / 2 + 1.3f;
                        }
                        else if (Settings.Aimbot_Hitbox == Classes.SDK.Variables.Enums.Hitbox.Foot)
                        {
                            dz = ClosestPlayer.HeadPosition.Z - LocalPlayer.HeadPosition.Z - mem.Read<float>(ClosestPlayer.Address + Offsets.Height);
                        }
                        double anglePitch = Math.Atan2(dz, distance) * 180 / Math.PI;

                        //set self angles to calculated angles
                        LocalPlayer.Yaw = (float)angleYaw + 90;
                        LocalPlayer.Pitch = (float)anglePitch;
                    }
                }
                if (Settings.Crosshair)
                {
                    mem.Write<int>(0x50F20C, 0f);
                    e.Graphics.DrawLine(Pens.Red, overlay.CenterX - 10, overlay.CenterY, overlay.CenterX - 5, overlay.CenterY);
                    e.Graphics.DrawLine(Pens.Red, overlay.CenterX + 10, overlay.CenterY, overlay.CenterX + 5, overlay.CenterY);
                    e.Graphics.DrawLine(Pens.Red, overlay.CenterX, overlay.CenterY - 10, overlay.CenterX, overlay.CenterY - 5);
                    e.Graphics.DrawLine(Pens.Red, overlay.CenterX, overlay.CenterY + 10, overlay.CenterX, overlay.CenterY + 5);
                }
                else
                {
                    mem.Write<int>(0x50F20C, 15);
                }

                if (Settings.InfiniteHealth)
                {
                    LocalPlayer.Health = 1337;
                }
                if (Settings.InfiniteArmor)
                {
                    LocalPlayer.Armor = 1337;
                }
                //if(Settings.Speed)
                //{
                //    if (Utils.IsKeyPushedDown(Keys.W))
                //    {
                //        mem.Write<int>(LocalPlayer.Address + Offsets.ForceMovement, 2);
                //    }
                //    //Console.WriteLine(LocalPlayer.Health); // RESPAWN WHERE DIED + INSTANT REVIVE
                //    //if(mem.Read<int>(LocalPlayer.Address + 0x0338) != 0) // https://guidedhacking.com/threads/assault-cube-find-if-entity-is-dead.12843/
                //    //{
                //    //    mem.Write<int>(LocalPlayer.Address + 0x0338, 0);
                //    //    mem.Write<int>(LocalPlayer.Address + Offsets.ForceMovement, 2);
                //    //    mem.Write<int>(LocalPlayer.Address + Offsets.ForceMovement, 0);
                //    //}
                //}

                if (Settings.Telekill || Settings.TeleportEnemies)
                {
                    Vector3 oldFootPos = LocalPlayer.FootPosition;
                    foreach (Player plr in Players)
                    {
                        if (plr.Team == LocalPlayer.Team) continue;
                        if (Settings.Telekill)
                        {
                            LocalPlayer.FootPosition = plr.FootPosition;
                        }
                        else if (Settings.TeleportEnemies)
                        {
                            plr.FootPosition = LocalPlayer.FootPosition;
                        }
                    }
                }

                if (Utils.IsKeyPushedDown(Keys.Space))
                {
                    if (Settings.Fly)
                    {
                        mem.Write<int>(LocalPlayer.Address + 0x69, -1);
                    }
                    else if (Settings.BunnyHop)
                    {
                        mem.Write<int>(LocalPlayer.Address + 0x69, 65536);
                    }
                }
            } catch { }
        }

        public static bool WorldToScreen(Vector3 position, out Vector2 screen, float[] matrix, int windowWidth, int windowHeight)
        {
            screen = new Vector2(-1, -1);

            Vector4 clipCoords;
            clipCoords.X = position.X * matrix[0] + position.Y * matrix[4] + position.Z * matrix[8] + matrix[12];
            clipCoords.Y = position.X * matrix[1] + position.Y * matrix[5] + position.Z * matrix[9] + matrix[13];
            clipCoords.Z = position.X * matrix[2] + position.Y * matrix[6] + position.Z * matrix[10] +  matrix[14];
            clipCoords.W = position.X * matrix[3] + position.Y * matrix[7] + position.Z * matrix[11] +  matrix[15];

            if (clipCoords.W < 0.1f) return false;

            Vector3 NDC;
            NDC.X = clipCoords.X / clipCoords.W;
            NDC.Y = clipCoords.Y / clipCoords.W;
            NDC.Z = clipCoords.Z / clipCoords.W;

            screen.X = (windowWidth / 2 * NDC.X) + (NDC.X + windowWidth / 2);
            screen.Y = -(windowHeight / 2 * NDC.Y) + (NDC.Y + windowHeight / 2);
            return true;
        }
    }
}
