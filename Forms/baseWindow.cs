using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using R6Schulprojekt.Models;
using R6Schulprojekt.Utils;

namespace R6Schulprojekt
{
    public partial class BaseWindow : Form
    {
        //Move Variablen
        private const int INPUT_MOUSE = 0;
        private const int MOUSEEVENTF_MOVE = 0x0001;

        private readonly List<Operator> operators = new List<Operator>
        {
            new Operator("Sledge", new List<Weapon>
            {
                new Weapon("L85A2", 10),
                new Weapon("M590A1", 12)
            }),
            new Operator("Thatcher", new List<Weapon>
            {
                new Weapon("L85A2", 34),
                new Weapon("AR33", 28),
                new Weapon("M590A1", 16)
            }),
            new Operator("Ash", new List<Weapon>
            {
                new Weapon("R4-C", 53),
                new Weapon("G36C", 45)
            }),
            new Operator("Thermite", new List<Weapon>
            {
                new Weapon("556xi", 22)
            }),
            new Operator("Twitch", new List<Weapon>
            {
                new Weapon("F2", 75),
                new Weapon("417", 30)
            }),
            new Operator("Montagne", new List<Weapon>
            {
                new Weapon("Le Roc Shield", 0)
            }),
            new Operator("Glaz", new List<Weapon>
            {
                new Weapon("OTs-03", 36)
            }),
            new Operator("Fuze", new List<Weapon>
            {
                new Weapon("6P41", 41),
                new Weapon("AK-12", 21),
                new Weapon("Ballistic Shield", 10)
            }),
            new Operator("Kapkan", new List<Weapon>
            {
                new Weapon("9x19VSN", 21),
                new Weapon("SASG-12", 18)
            }),
            new Operator("IQ", new List<Weapon>
            {
                new Weapon("AUG A2", 53),
                new Weapon("552 Commando", 21),
                new Weapon("G8A1", 18)
            }),
            new Operator("Blitz", new List<Weapon>
            {
                new Weapon("G52 Tactical Shield", 0)
            }),
            new Operator("Bandit", new List<Weapon>
            {
                new Weapon("MP7", 19),
                new Weapon("M870", 14)
            }),
            new Operator("Jäger", new List<Weapon>
            {
                new Weapon("416-C Carbine", 23)
            }),
            new Operator("Buck", new List<Weapon>
            {
                new Weapon("C8-SFW", 50),
                new Weapon("CAMRS", 38)
            }),
            new Operator("Frost", new List<Weapon>
            {
                new Weapon("Super 90", 30),
                new Weapon("9mm C1", 18)
            }),
            new Operator("Blackbeard", new List<Weapon>
            {
                new Weapon("Mk17 CQB", 10),
                new Weapon("SR-25", 38)
            }),
            new Operator("Valkyrie", new List<Weapon>
            {
                new Weapon("MPX", 19),
                new Weapon("SPAS-12", 14)
            }),
            new Operator("Capitao", new List<Weapon>
            {
                new Weapon("PARA-308", 38),
                new Weapon("M249", 15)
            }),
            new Operator("Caveira", new List<Weapon>
            {
                new Weapon("M12", 25),
                new Weapon("SPAS-15", 22)
            }),
            new Operator("Hibana", new List<Weapon>
            {
                new Weapon("Type-89", 38),
                new Weapon("SuperNova", 25)
            }),
            new Operator("Echo", new List<Weapon>
            {
                new Weapon("MP5SD", 21),
                new Weapon("SuperNova", 25)
            }),
            new Operator("Jackal", new List<Weapon>
            {
                new Weapon("C7E", 40),
                new Weapon("PDW9", 35),
                new Weapon("ITA12L", 15)
            }),
            new Operator("Mira", new List<Weapon>
            {
                new Weapon("Vector .45 ACP", 33),
                new Weapon("ITA12L", 22)
            }),
            new Operator("Lesion", new List<Weapon>
            {
                new Weapon("T-5 SMG", 30),
                new Weapon("Six12 SD", 18)
            }),
            new Operator("Zofia", new List<Weapon>
            {
                new Weapon("LMG-E", 36),
                new Weapon("M762", 33)
            }),
            new Operator("Dokkaebi", new List<Weapon>
            {
                new Weapon("Mk 14 EBR", 42),
                new Weapon("BOSG.12.2", 25)
            }),
            new Operator("Vigil", new List<Weapon>
            {
                new Weapon("K1A", 29),
                new Weapon("BOSG.12.2", 25)
            }),
            new Operator("Lion", new List<Weapon>
            {
                new Weapon("V308", 35),
                new Weapon("417", 35),
                new Weapon("SG-CQB", 16)
            }),
            new Operator("Finka", new List<Weapon>
            {
                new Weapon("Spear .308", 30),
                new Weapon("6P41", 18)
            }),
            new Operator("Maestro", new List<Weapon>
            {
                new Weapon("ALDA 5.56", 23),
                new Weapon("ACS12", 17)
            }),
            new Operator("Alibi", new List<Weapon>
            {
                new Weapon("Mx4 Storm", 27),
                new Weapon("ACS12", 20)
            }),
            new Operator("Clash", new List<Weapon>
            {
                new Weapon("CCE Shield", 0)
            }),
            new Operator("Maverick", new List<Weapon>
            {
                new Weapon("M4", 38),
                new Weapon("AR-15.50", 38)
            }),
            new Operator("Nomad", new List<Weapon>
            {
                new Weapon("AK-74M", 30),
                new Weapon("ARX200", 25)
            }),
            new Operator("Kaid", new List<Weapon>
            {
                new Weapon("TCSG12", 33),
                new Weapon("AUG A3", 33)
            }),
            new Operator("Mozzie", new List<Weapon>
            {
                new Weapon("Commando 9", 28),
                new Weapon("P10 RONI", 22)
            }),
            new Operator("Gridlock", new List<Weapon>
            {
                new Weapon("F90", 35),
                new Weapon("M249 SAW", 22)
            }),
            new Operator("Warden", new List<Weapon>
            {
                new Weapon("MPX", 19),
                new Weapon("M590A1", 22)
            }),
            new Operator("Nøkk", new List<Weapon>
            {
                new Weapon("FMG-9", 25),
                new Weapon("Six12 SD", 20)
            }),
            new Operator("Amaru", new List<Weapon>
            {
                new Weapon("G8A1", 30),
                new Weapon("SuperNova", 20)
            }),
            new Operator("Goyo", new List<Weapon>
            {
                new Weapon("Vector .45 ACP", 33),
                new Weapon("TCSG12", 25)
            }),
            new Operator("Iana", new List<Weapon>
            {
                new Weapon("ARX200", 27),
                new Weapon("G36C", 22)
            }),
            new Operator("Oryx", new List<Weapon>
            {
                new Weapon("T-5 SMG", 22),
                new Weapon("SPAS-12", 18)
            }),
            new Operator("Ace", new List<Weapon>
            {
                new Weapon("AK-12", 30)
            }),
            new Operator("Melusi", new List<Weapon>
            {
                new Weapon("MP5", 28)
            }),
            new Operator("Aruni", new List<Weapon>
            {
                new Weapon("P10 RONI", 22),
                new Weapon("Mk 14 EBR", 35)
            }),
            new Operator("Azami", new List<Weapon>
            {
                new Weapon("ACS12", 33),
                new Weapon("9x19VSN", 22)
            })
        };


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