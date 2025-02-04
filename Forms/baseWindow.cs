using R6Schulprojekt.Models;
using R6Schulprojekt.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace R6Schulprojekt
{
    public partial class BaseWindow : Form
    {
        //Move Variablen
        private const int INPUT_MOUSE = 0;
        private const int MOUSEEVENTF_MOVE = 0x0001;

        #region Operator-list
        public static class WeaponDatabase
        {
            public static readonly Weapon MP5 = new Weapon("MP5", 28);
            public static readonly Weapon MP5K = new Weapon("MP5K", 32);
            public static readonly Weapon L85A2 = new Weapon("L85A2", 10);
            public static readonly Weapon M590A1 = new Weapon("M590A1", 12);
            public static readonly Weapon AR33 = new Weapon("AR33", 28);
            public static readonly Weapon R4C = new Weapon("R4-C", 53);
            public static readonly Weapon G36C = new Weapon("G36-C", 45);
            public static readonly Weapon x556XI = new Weapon("556xi", 22);
            public static readonly Weapon F2 = new Weapon("F2", 22);
            public static readonly Weapon x417 = new Weapon("417", 30);
            public static readonly Weapon P9 = new Weapon("P9", 30);
            public static readonly Weapon P12 = new Weapon("P12", 30);
            public static readonly Weapon OTS03 = new Weapon("OTs-03", 36);
            public static readonly Weapon x6P41 = new Weapon("6P41", 41);
            public static readonly Weapon AK12 = new Weapon("AK-12", 21);
            public static readonly Weapon AUGA2 = new Weapon("AUG A2", 53);
            public static readonly Weapon x552COMMANDO = new Weapon("552 Commando", 51);
            public static readonly Weapon G8A1 = new Weapon("G8A1", 18);
            public static readonly Weapon C8SFW = new Weapon("C8-SFW", 50);
            public static readonly Weapon CAMRS = new Weapon("CAMRS", 38);
            public static readonly Weapon MK17CQB = new Weapon("MK17 CQB", 10);
            public static readonly Weapon SR25 = new Weapon("SR-25", 38);
            public static readonly Weapon PARA308 = new Weapon("Para-308", 38);
            public static readonly Weapon M249 = new Weapon("M249", 15);
            public static readonly Weapon C7E = new Weapon("C7E", 40);
            public static readonly Weapon PDW9 = new Weapon("PDW9", 35);
            public static readonly Weapon ITA12L = new Weapon("ITA12L", 15);
            public static readonly Weapon LMGE = new Weapon("LMG-E", 36);
            public static readonly Weapon M762 = new Weapon("M762", 33);
            public static readonly Weapon MK14EBR = new Weapon("Mk 14 EBR", 42);
            public static readonly Weapon BOSG122 = new Weapon("BOSG.12.2", 25);
            public static readonly Weapon V308 = new Weapon("V308", 35);
            public static readonly Weapon SGCQB = new Weapon("SG-CQB", 16);
            public static readonly Weapon SPEAR308 = new Weapon("Spear .308", 30);
            public static readonly Weapon M4 = new Weapon("M4", 38);
            public static readonly Weapon AR1550 = new Weapon("AR-15.50", 38);
            public static readonly Weapon AK74M = new Weapon("AK-74M", 30);
            public static readonly Weapon ARX200 = new Weapon("ARX200", 25);
            public static readonly Weapon F90 = new Weapon("F90", 35);
            public static readonly Weapon M249SAW = new Weapon("M249 SAW", 22);
            public static readonly Weapon FMG9 = new Weapon("FMG-9", 25);
            public static readonly Weapon SIX12 = new Weapon("Six12", 20);
            public static readonly Weapon SIX12SD = new Weapon("Six12 SD", 20);
            public static readonly Weapon Supernova = new Weapon("Supernova", 20);
            public static readonly Weapon POF9 = new Weapon("POF9", 38);
            public static readonly Weapon SC3000K = new Weapon("SC3000K", 27);
            public static readonly Weapon MP7 = new Weapon("MP7", 17);
            public static readonly Weapon SPSMG9 = new Weapon("SPSMG9", 34);
            public static readonly Weapon C75AUTO = new Weapon("C75 Auto", 17);
            public static readonly Weapon T95LSW = new Weapon("T-95 LSW", 33);
            public static readonly Weapon x9X19VSN = new Weapon("9x19VSN", 21);
            public static readonly Weapon SASG12 = new Weapon("SASG-12", 18);
            public static readonly Weapon M870 = new Weapon("M870", 14);
            public static readonly Weapon x416CCarbine = new Weapon("416-C Carbine", 23);
            public static readonly Weapon SUPER90 = new Weapon("Super 90", 30);
            public static readonly Weapon x9MMC1 = new Weapon("9mm C1", 18);
            public static readonly Weapon MPX = new Weapon("MPX", 19);
            public static readonly Weapon SPAS12 = new Weapon("SPAS-12", 14);
            public static readonly Weapon SPAS15 = new Weapon("SPAS-15", 22);
            public static readonly Weapon M12 = new Weapon("M12", 25);
            public static readonly Weapon TYPE89 = new Weapon("Type-89", 38);
            public static readonly Weapon MP5SD = new Weapon("MP5SD", 21);
            public static readonly Weapon Vector45ACP = new Weapon("Vector .45 ACP", 33);
            public static readonly Weapon T5SMG = new Weapon("T-5 SMG", 30);
            public static readonly Weapon MX4STORM = new Weapon("Mx4 Storm", 27);
            public static readonly Weapon K1A = new Weapon("K1A", 29);
            public static readonly Weapon ACS12 = new Weapon("ACS12", 20);
            public static readonly Weapon SUPERSHORTY = new Weapon("Super Shorty", 33);
            public static readonly Weapon P10C = new Weapon("P-10C", 22);
            public static readonly Weapon TCSG12 = new Weapon("TCSG12", 33);
            public static readonly Weapon ALDA556 = new Weapon("ALDA 5.56", 23);
            public static readonly Weapon COMMANDO9 = new Weapon("Commando 9", 28);
            public static readonly Weapon P10RONI = new Weapon("P10 RONI", 22);
            public static readonly Weapon AUGA3 = new Weapon("AUG A3", 33);
            public static readonly Weapon PCX33 = new Weapon("PCX-33", 30);
            public static readonly Weapon M850 = new Weapon("M850", 33);
            public static readonly Weapon P90 = new Weapon("P90", 33);
            public static readonly Weapon SMG11 = new Weapon("SMG-11", 33);
            public static readonly Weapon UZK50GI = new Weapon("UZK50GI", 31);
            public static readonly Weapon SCROPIONEVO = new Weapon("Scorpion Evo", 34);
            public static readonly Weapon FO12 = new Weapon("FO-12", 33);
            public static readonly Weapon UMP45 = new Weapon("UMP45", 35);
            public static readonly Weapon M1014 = new Weapon("M1014", 34);
            public static readonly Weapon DP27 = new Weapon("DP27", 49);
            public static readonly Weapon x9X18VSN = new Weapon("9x18VSN", 22);
        }

        #region Operators
        private readonly List<Operator> operators = new List<Operator>
        {
            #region Attacker
            new Operator("Sledge", new List<Weapon>
            {
                WeaponDatabase.L85A2,
                WeaponDatabase.M590A1
            }),
            new Operator("Thatcher", new List<Weapon>
            {
                WeaponDatabase.L85A2,
                WeaponDatabase.AR33,
                WeaponDatabase.M590A1
            }),
            new Operator("Ash", new List<Weapon>
            {
                WeaponDatabase.R4C,
                WeaponDatabase.G36C
            }),
            new Operator("Thermite", new List<Weapon>
            {
                WeaponDatabase.x556XI
            }),
            new Operator("Twitch", new List<Weapon>
            {
                WeaponDatabase.F2,
                WeaponDatabase.x417
            }),
            new Operator("Montagne", new List<Weapon>
            {
                new Weapon("Le Roc Shield", 0),
                WeaponDatabase.P9
            }),
            new Operator("Glaz", new List<Weapon>
            {
                WeaponDatabase.OTS03
            }),
            new Operator("Fuze", new List<Weapon>
            {
                WeaponDatabase.x6P41,
                WeaponDatabase.AK12
            }),
            new Operator("IQ", new List<Weapon>
            {
                WeaponDatabase.AUGA2,
                WeaponDatabase.x552COMMANDO,
                WeaponDatabase.G8A1
            }),
            new Operator("Blitz", new List<Weapon>
            {
                WeaponDatabase.P12
            }),
            new Operator("Buck", new List<Weapon>
            {
                WeaponDatabase.C8SFW,
                WeaponDatabase.CAMRS
            }),
            new Operator("Blackbeard", new List<Weapon>
            {
                WeaponDatabase.MK17CQB,
                WeaponDatabase.SR25
            }),
            new Operator("Capitao", new List<Weapon>
            {
                WeaponDatabase.PARA308,
                WeaponDatabase.M249
            }),
            new Operator("Jackal", new List<Weapon>
            {
                WeaponDatabase.C7E,
                WeaponDatabase.PDW9,
                WeaponDatabase.ITA12L
            }),
            new Operator("Zofia", new List<Weapon>
            {
                WeaponDatabase.LMGE,
                WeaponDatabase.M762
            }),
            new Operator("Dokkaebi", new List<Weapon>
            {
                WeaponDatabase.MK14EBR,
                WeaponDatabase.BOSG122
            }),
            new Operator("Lion", new List<Weapon>
            {
                WeaponDatabase.V308,
                WeaponDatabase.x417,
                WeaponDatabase.SGCQB
            }),
            new Operator("Finka", new List<Weapon>
            {
                WeaponDatabase.SPEAR308,
                WeaponDatabase.x6P41
            }),
            new Operator("Maverick", new List<Weapon>
            {
                WeaponDatabase.M4,
                WeaponDatabase.AR1550
            }),
            new Operator("Nomad", new List<Weapon>
            {
                WeaponDatabase.AK74M,
                WeaponDatabase.ARX200
            }),
            new Operator("Gridlock", new List<Weapon>
            {
                WeaponDatabase.F90,
                WeaponDatabase.M249SAW
            }),
            new Operator("Nøkk", new List<Weapon>
            {
                WeaponDatabase.FMG9,
                WeaponDatabase.SIX12SD
            }),
            new Operator("Amaru", new List<Weapon>
            {
                WeaponDatabase.G8A1,
                WeaponDatabase.Supernova
            }),
            new Operator("Iana", new List<Weapon>
            {
                WeaponDatabase.ARX200,
                WeaponDatabase.G36C
            }),
            new Operator("Ace", new List<Weapon>
            {
                WeaponDatabase.AK12
            }),
            new Operator("Striker", new List<Weapon>
            {
                WeaponDatabase.M4,
                WeaponDatabase.M249
            }),
            new Operator("Deimos", new List<Weapon>
            {
                WeaponDatabase.AK74M,
                WeaponDatabase.M590A1
            }),
            new Operator("Ram", new List<Weapon>
            {
                WeaponDatabase.R4C,
                WeaponDatabase.LMGE
            }),
            new Operator("Brava", new List<Weapon>
            {
                WeaponDatabase.PARA308,
                WeaponDatabase.CAMRS
            }),
            new Operator("Grim", new List<Weapon>
            {
                WeaponDatabase.x552COMMANDO,
                WeaponDatabase.SGCQB
            }),
            new Operator("Sens", new List<Weapon>
            {
                WeaponDatabase.x417,
                WeaponDatabase.POF9
            }),
            new Operator("OSA", new List<Weapon>
            {
                WeaponDatabase.x556XI,
                WeaponDatabase.PDW9
            }),
            new Operator("Flores", new List<Weapon>
            {
                WeaponDatabase.AR33,
                WeaponDatabase.SR25
            }),
            new Operator("Zero", new List<Weapon>
            {
                WeaponDatabase.SC3000K,
                WeaponDatabase.MP7
            }),
            new Operator("Kali", new List<Weapon>
            {
                WeaponDatabase.SPSMG9,
                WeaponDatabase.C75AUTO
            }),
            new Operator("Nokk", new List<Weapon>
            {
                WeaponDatabase.FMG9,
                WeaponDatabase.SIX12SD
            }),
            new Operator("Ying", new List<Weapon>
            {
                WeaponDatabase.T95LSW,
                WeaponDatabase.SIX12
            }),
            #endregion

            #region Defender
            new Operator("Kapkan", new List<Weapon>
            {
                WeaponDatabase.x9X19VSN,
                WeaponDatabase.SASG12
            }),
            new Operator("Bandit", new List<Weapon>
            {
                WeaponDatabase.MP7,
                WeaponDatabase.M870
            }),
            new Operator("Jäger", new List<Weapon>
            {
                WeaponDatabase.x416CCarbine,
                WeaponDatabase.M870
            }),
            new Operator("Frost", new List<Weapon>
            {
                WeaponDatabase.SUPER90,
                WeaponDatabase.x9MMC1
            }),
            new Operator("Valkyrie", new List<Weapon>
            {
                WeaponDatabase.MPX,
                WeaponDatabase.SPAS12
            }),
            new Operator("Caveira", new List<Weapon>
            {
                WeaponDatabase.M12,
                WeaponDatabase.SPAS15
            }),
            new Operator("Hibana", new List<Weapon>
            {
                WeaponDatabase.TYPE89,
                WeaponDatabase.Supernova
            }),
            new Operator("Echo", new List<Weapon>
            {
                WeaponDatabase.MP5SD,
                WeaponDatabase.Supernova
            }),
            new Operator("Mira", new List<Weapon>
            {
                WeaponDatabase.Vector45ACP,
                WeaponDatabase.ITA12L
            }),
            new Operator("Lesion", new List<Weapon>
            {
                WeaponDatabase.T5SMG,
                WeaponDatabase.SIX12SD
            }),
            new Operator("Vigil", new List<Weapon>
            {
                WeaponDatabase.K1A,
                WeaponDatabase.BOSG122
            }),
            new Operator("Alibi", new List<Weapon>
            {
                WeaponDatabase.MX4STORM,
                WeaponDatabase.ACS12
            }),
            new Operator("Clash", new List<Weapon>
            {
                WeaponDatabase.SPSMG9,
                WeaponDatabase.SUPERSHORTY,
                WeaponDatabase.P10C
            }),
            new Operator("Kaid", new List<Weapon>
            {
                WeaponDatabase.TCSG12,
                WeaponDatabase.AUGA3
            }),
            new Operator("Mozzie", new List<Weapon>
            {
                WeaponDatabase.COMMANDO9,
                WeaponDatabase.P10RONI
            }),
            new Operator("Warden", new List<Weapon>
            {
                WeaponDatabase.MPX,
                WeaponDatabase.M590A1
            }),
            new Operator("Maestro", new List<Weapon>
            {
                WeaponDatabase.ALDA556,
                WeaponDatabase.ACS12
            }),
            new Operator("Goyo", new List<Weapon>
            {
                WeaponDatabase.Vector45ACP,
                WeaponDatabase.TCSG12
            }),
            new Operator("Oryx", new List<Weapon>
            {
                WeaponDatabase.T5SMG,
                WeaponDatabase.SPAS12
            }),
            new Operator("Melusi", new List<Weapon>
            {
                WeaponDatabase.MP5,
                WeaponDatabase.SUPER90
            }),
            new Operator("Aruni", new List<Weapon>
            {
                WeaponDatabase.P10RONI,
                WeaponDatabase.MK14EBR
            }),
            new Operator("Azami", new List<Weapon>
            {
                WeaponDatabase.ACS12,
                WeaponDatabase.x9X19VSN
            }),
            new Operator("Skopos", new List<Weapon>
            {
                WeaponDatabase.PCX33
            }),
            new Operator("Sentry", new List<Weapon>
            {
                WeaponDatabase.COMMANDO9,
                WeaponDatabase.M850
                
            }),
            new Operator("Tubarao", new List<Weapon>
            {
                WeaponDatabase.MPX,
                WeaponDatabase.AR1550
            }),
            new Operator("Fenrir", new List<Weapon>
            {
                WeaponDatabase.MP7,
                WeaponDatabase.SASG12
            }),
            new Operator("Solis", new List<Weapon>
            {
                WeaponDatabase.ITA12L,
                WeaponDatabase.P90,
                WeaponDatabase.SMG11
            }),
            new Operator("Thorn", new List<Weapon>
            {
                WeaponDatabase.UZK50GI,
                WeaponDatabase.M870
            }),
            new Operator("Thunderbird", new List<Weapon>
            {
                WeaponDatabase.SPEAR308,
                WeaponDatabase.SPAS15
            }),
            new Operator("Wamai", new List<Weapon>
            {
                WeaponDatabase.AUGA2,
                WeaponDatabase.MP5K
            }),
            new Operator("Ela", new List<Weapon>
            {
                WeaponDatabase.SCROPIONEVO,
                WeaponDatabase.FO12
            }),
            new Operator("Mute", new List<Weapon>
            {
                WeaponDatabase.MP5K,
                WeaponDatabase.M590A1
            }),
            new Operator("Smoke", new List<Weapon>
            {
                WeaponDatabase.SMG11,
                WeaponDatabase.M590A1,
                WeaponDatabase.FMG9
            }),
            new Operator("Castle", new List<Weapon>
            {
                WeaponDatabase.UMP45,
                WeaponDatabase.M1014
            }),
            new Operator("Pulse", new List<Weapon>
            {
                WeaponDatabase.UMP45,
                WeaponDatabase.M1014
            }),
            new Operator("DOC", new List<Weapon>
            {
                WeaponDatabase.MP5,
                WeaponDatabase.P90,
                WeaponDatabase.SGCQB
            }),
            new Operator("Rook", new List<Weapon>
            {
                WeaponDatabase.MP5,
                WeaponDatabase.P90,
                WeaponDatabase.SGCQB
            }),
            new Operator("Tachanka", new List<Weapon>
            {
                WeaponDatabase.DP27,
                WeaponDatabase.x9X18VSN
            })
            #endregion
        };
        #endregion
        #endregion


        private bool keepRecoilActive;


        //Variablen
        private int pullDownRate = 3;
        private Thread recoilThread;


        public BaseWindow()
        {
            InitializeComponent();
            Load += baseWindow_Load;
            RoundedCorners.SetRoundedCorners(this, 20);

            recoilSlider.Enabled = false;


            operatorListBox.DataSource = operators;
            operatorListBox.DisplayMember = "Name";
        }

        [DllImport("user32.dll")]
        private static extern short GetAsyncKeyState(Keys vKey);

        [DllImport("user32.dll")]
        private static extern uint SendInput(uint nInputs, INPUT[] pInputs, int cbSize);

        protected override void OnPaint(PaintEventArgs e)
        {
            //ApplyBackground.ApplyGradient(this, e);
        }

        private void baseWindow_Load(object sender, EventArgs e)
        {
            FadeInAnimation.Start(this);
        }

        private void toggleCHKBX_CheckedChanged(object sender, EventArgs e)
        {
            if (toggleCHKBX.Checked)
            {
                keepRecoilActive = true;
                recoilThread = new Thread(RecoilControl);
                recoilThread.IsBackground = true;
                recoilThread.Start();
            }
            else
            {
                keepRecoilActive = false;
                recoilThread?.Join();
            }
        }

        #region Hide Button

        private void hideBTN_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        #endregion

        #region Close Button

        private void closeBTN_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        private void operatorListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (operatorListBox.SelectedItem is Operator selectedOperator)
            {
                weaponsListBox.DataSource = selectedOperator.Weapons;
                weaponsListBox.DisplayMember = "Name";
            }
        }

        private void weaponsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (weaponsListBox.SelectedItem is Weapon selectedWeapon)
            {
                pullDownRate = selectedWeapon.Recoil;
                recoilSlider.Value = pullDownRate;
                customRecoilLabel.Text = $"Recoil: {pullDownRate}";
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            var searchQuery = searchTextBox.Text.ToLower();

            var filteredOperators = operators
                .Where(op => op.Name.ToLower().Contains(searchQuery))
                .ToList();

            operatorListBox.DataSource = filteredOperators;
            operatorListBox.DisplayMember = "Name";
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct INPUT
        {
            public int type;
            public MOUSEINPUT mi;
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct MOUSEINPUT
        {
            public int dx;
            public int dy;
            public int mouseData;
            public int dwFlags;
            public int time;
            public IntPtr dwExtraInfo;
        }

        #region Recoil Control

        private void RecoilControl()
        {
            while (keepRecoilActive)
            {
                if ((GetAsyncKeyState(Keys.LButton) & 0x8000) != 0 && toggleCHKBX.Checked)
                    if ((GetAsyncKeyState(Keys.RButton) & 0x8000) != 0 || !reqAdsCHKBX.Checked)
                    {
                        var inputs = new INPUT[1];
                        inputs[0].type = INPUT_MOUSE;
                        inputs[0].mi.dx = 0;
                        inputs[0].mi.dy = pullDownRate;
                        inputs[0].mi.dwFlags = MOUSEEVENTF_MOVE;

                        SendInput(1, inputs, Marshal.SizeOf(typeof(INPUT)));
                        Thread.Sleep(10);
                    }

                Thread.Sleep(5);
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            keepRecoilActive = false;
            recoilThread?.Join();
            base.OnFormClosed(e);
        }

        #endregion

        #region TopBar Dragging

        private bool isDragging;
        private Point lastCursorPosition;

        private void topBarPNL_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                lastCursorPosition = e.Location;
            }
        }

        private void topBarPNL_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                var deltaX = e.X - lastCursorPosition.X;
                var deltaY = e.Y - lastCursorPosition.Y;
                Location = new Point(Left + deltaX, Top + deltaY);
            }
        }

        private void topBarPNL_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        #endregion

        #region Custom Recoil Slider

        private void customRecoilCHKBX_CheckedChanged(object sender, EventArgs e)
        {
            recoilSlider.Enabled = customRecoilCHKBX.Checked;
        }

        private void recoilSlider_Scroll(object sender, EventArgs e)
        {
            if (customRecoilCHKBX.Checked)
            {
                pullDownRate = recoilSlider.Value;
                customRecoilLabel.Text = $"Custom Recoil: {recoilSlider.Value}";
            }
        }

        #endregion
    }
}