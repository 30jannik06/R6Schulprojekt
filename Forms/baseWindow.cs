using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
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
            new Operator("Sledge", new List<Weapon>
            {
                new Weapon("L85A2", 10),
                new Weapon("M590A1", 12)
            }),
            new Operator("Valkyrie", new List<Weapon>
            {
                new Weapon("MPX", 19),
                new Weapon("SPAS-12", 14)
            }),
            new Operator("Jackal", new List<Weapon>
            {
                new Weapon("C7E", 40),
                new Weapon("PDW9", 35),
                new Weapon("ITA12L", 15)
            }),
            new Operator("Bandit", new List<Weapon>
            {
                new Weapon("MP7", 19),
                new Weapon("M870", 14)
            }),
            new Operator("Mira", new List<Weapon>
            {
                new Weapon("Vector .45 ACP", 33),
                new Weapon("ITA12L", 22)
            }),
            new Operator("Kaid", new List<Weapon>
            {
                new Weapon("TCSG12", 33),
                new Weapon("AUG A3", 33)
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
            new Operator("Doc", new List<Weapon>
            {
                new Weapon("MP5", 43),
                new Weapon("SG-CQB", 18),
                new Weapon("P90", 25)
            }),
            new Operator("Rook", new List<Weapon>
            {
                new Weapon("MP5", 43),
                new Weapon("SG-CQB", 18),
                new Weapon("P90", 25)
            }),
            new Operator("Thorn", new List<Weapon>
            {
                new Weapon("UZK50GI", 17)
            }),
            new Operator("Thatcher", new List<Weapon>
            {
                new Weapon("L85A2", 34),
                new Weapon("AR33", 28),
                new Weapon("M590A1", 16)
            }),
            new Operator("Glaz", new List<Weapon>
            {
                new Weapon("OTs-03", 36)
            }),
            new Operator("Fuze", new List<Weapon>
            {
                new Weapon("6P41 LMG", 41),
                new Weapon("AK-12", 21),
                new Weapon("Ballistic Shield", 10)
            }),
            new Operator("IQ", new List<Weapon>
            {
                new Weapon("AUG A2", 53),
                new Weapon("552 Commando", 21),
                new Weapon("G8A1", 18)
            }),
            new Operator("Buck", new List<Weapon>
            {
                new Weapon("C8-SFW", 50),
                new Weapon("CAMRS", 38)
            }),
            new Operator("Blackbeard", new List<Weapon>
            {
                new Weapon("Mk17 CQB", 10),
                new Weapon("SR-25", 38)
            }),
            new Operator("Capitao", new List<Weapon>
            {
                new Weapon("PARA-308", 38),
                new Weapon("M249", 15)
            }),
            new Operator("OSA", new List<Weapon>
            {
                new Weapon("PDW9", 55),
                new Weapon("556xi", 19)
            }),
            new Operator("Azami", new List<Weapon>
            {
                new Weapon("ACS12", 33),
                new Weapon("9x9vsn", 22)
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


            operatorComboBox.DataSource = operators;
            operatorComboBox.DisplayMember = "Name";
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

        private void weaponCOMBX_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (weaponComboBox.SelectedItem is Weapon selectedWeapon)
            {
                pullDownRate = selectedWeapon.Recoil;
                recoilSlider.Value = pullDownRate;
                customRecoilLabel.Text = $"Recoil: {pullDownRate}";
            }
        }

        private void operatorCOMBX_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (operatorComboBox.SelectedItem is Operator selectedOperator)
            {
                weaponComboBox.DataSource = selectedOperator.Weapons;
                weaponComboBox.DisplayMember = "Name";
            }
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

        public class Weapon
        {
            public Weapon(string name, int recoil)
            {
                Name = name;
                Recoil = recoil;
            }

            public string Name { get; set; }
            public int Recoil { get; set; }
        }

        // Operator Klasse
        public class Operator
        {
            public Operator(string name, List<Weapon> weapons)
            {
                Name = name;
                Weapons = weapons;
            }

            public string Name { get; set; }
            public List<Weapon> Weapons { get; set; }
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