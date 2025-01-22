using R6Schulprojekt.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace R6Schulprojekt
{
    public partial class BaseWindow : Form
    {
        [DllImport("user32.dll")]
        private static extern short GetAsyncKeyState(Keys vKey);

        [DllImport("user32.dll")]
        private static extern bool SetCursorPos(int X, int Y);

        [DllImport("user32.dll")]
        private static extern bool GetCursorPos(out POINT lpPoint);

        [DllImport("user32.dll")]
        private static extern uint SendInput(uint nInputs, INPUT[] pInputs, int cbSize);

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

        //Move Variablen
        private const int INPUT_MOUSE = 0;
        private const int MOUSEEVENTF_MOVE = 0x0001;

        //Variablen
        private int pullDownRate = 3;
        private Thread recoilThread;
        private bool keepRecoilActive = false;

        // Struktur für Mausposition
        public struct POINT
        {
            public int X;
            public int Y;
        }

        // Operator Klasse
        public class Operator
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int PullDownRate { get; set; }

            public Operator(int id, string name, int pullDownRate)
            {
                Id = id;
                Name = name;
                PullDownRate = pullDownRate;
            }

            public override string ToString() => Name;
        }

        public BaseWindow()
        {
            InitializeComponent();
            this.Load += new EventHandler(baseWindow_Load);
            RoundedCorners.SetRoundedCorners(this, 20);

            recoilSlider.Enabled = false;

            var operators = new List<Operator>
            {
                new Operator(1, "Ash", 53),
                new Operator(2, "Thermite", 22),
                new Operator(3, "Twitch", 75),
                new Operator(4, "Sledge", 10),
                new Operator(5, "Valkyrie", 19),
                new Operator(6, "Jackal", 40),
                new Operator(7, "Bandit", 19),
                new Operator(8, "Mira", 33),
                new Operator(9, "Kaid", 33),
                new Operator(10, "Maestro", 23),
                new Operator(11, "Alibi", 27),
                new Operator(12, "Doc", 43),
                new Operator(13, "Rook", 43),
                new Operator(14, "Thorn", 17),
                new Operator(15, "Thatcher", 34),
                new Operator(16, "Glaz", 36),
                new Operator(17, "Fuze LMG", 41),
                new Operator(18, "Fuze AK", 21),
                new Operator(19, "IQ AUG", 53),
                new Operator(20, "IQ COMMANDO", 21),
                new Operator(21, "IQ G8A1", 18),
                new Operator(22, "IQ G8A1", 18),
                new Operator(23, "Buck C8", 50),
                new Operator(23, "Buck Camrs", 38),
                new Operator(25, "Blackbeard Mk17", 10),
                new Operator(26, "Blackbeard SR-25", 38),
                new Operator(27, "Capitau Para", 38),
                new Operator(28, "Capitau M249", 15)
            };

            operatorComboBox.DataSource = operators;
            operatorComboBox.DisplayMember = "Name";
            operatorComboBox.ValueMember = "Id";
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            //ApplyBackground.ApplyGradient(this, e);
        }

        private void baseWindow_Load(object sender, EventArgs e)
        {
            FadeInAnimation.Start(this);
        }


        private void operatorCOMBX_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (operatorComboBox.SelectedItem is Operator selectedOperator)
            {
                pullDownRate = selectedOperator.PullDownRate;
                recoilSlider.Value = pullDownRate;
                customRecoilLabel.Text = $"Custom Recoil: {pullDownRate}";
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

        #region Recoil Control
        private void RecoilControl()
        {
            while (keepRecoilActive)
            {
                if ((GetAsyncKeyState(Keys.LButton) & 0x8000) != 0 && toggleCHKBX.Checked)
                {
                    if ((GetAsyncKeyState(Keys.RButton) & 0x8000) != 0 || !reqAdsCHKBX.Checked)
                    {
                        INPUT[] inputs = new INPUT[1];
                        inputs[0].type = INPUT_MOUSE;
                        inputs[0].mi.dx = 0;
                        inputs[0].mi.dy = pullDownRate;
                        inputs[0].mi.dwFlags = MOUSEEVENTF_MOVE;

                        SendInput(1, inputs, Marshal.SizeOf(typeof(INPUT)));
                        Thread.Sleep(10);
                    }
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
        private bool isDragging = false;
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
                this.Location = new Point(this.Left + deltaX, this.Top + deltaY);
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

        #region Hide Button
        private void hideBTN_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region Close Button
        private void closeBTN_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion
    }
}
