using R6Schulprojekt.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace R6Schulprojekt
{
    public partial class baseWindow : Form
    {
        // P/Invoke Deklarationen
        [DllImport("user32.dll")]
        private static extern short GetAsyncKeyState(Keys vKey);

        [DllImport("user32.dll")]
        private static extern bool SetCursorPos(int X, int Y);

        [DllImport("user32.dll")]
        private static extern bool GetCursorPos(out POINT lpPoint);

        // Variablen
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

        public baseWindow()
        {
            InitializeComponent();
            this.Load += baseWindow_Load;
            RoundedCorners.SetRoundedCorners(this, 20);

            recoilSlider.Enabled = false;

            // Liste der Operatoren
            var operators = new List<Operator>
            {
                new Operator(1, "Ash", 2),
                new Operator(2, "Thermite", 2),
                new Operator(3, "Twitch", 1),
                new Operator(4, "Sledge", 3),
                new Operator(5, "Montagne", 0),
                new Operator(6, "Rook", 0),
                new Operator(7, "Doc", 1),
                new Operator(8, "Jäger", 1),
                new Operator(9, "Bandit", 1),
                new Operator(10, "Castle", 1),
                new Operator(11, "Mira", 1),
                new Operator(12, "Valkyrie", 1),
                new Operator(13, "IQ", 2),
                new Operator(14, "Fuze", 2),
                new Operator(15, "Blitz", 0),
                new Operator(16, "Pulse", 2),
                new Operator(17, "Tachanka", 1),
                new Operator(18, "Capitão", 2),
                new Operator(19, "Kapkan", 1),
                new Operator(20, "Smoke", 1),
                new Operator(21, "Caveira", 0),
                new Operator(22, "Echo", 2),
                new Operator(23, "Lesion", 1),
                new Operator(24, "Ela", 2),
                new Operator(25, "Zofia", 2),
                new Operator(26, "Dokkaebi", 1),
                new Operator(27, "Lion", 1),
                new Operator(28, "Finka", 1),
                new Operator(29, "Maverick", 2),
                new Operator(30, "Clash", 0),
                new Operator(31, "Nomad", 1),
                new Operator(32, "Gridlock", 1),
                new Operator(33, "Warden", 0),
                new Operator(34, "Goyo", 2),
                new Operator(35, "Amaru", 2),
                new Operator(36, "Kali", 2),
                new Operator(37, "Oryx", 0),
                new Operator(38, "Iana", 2),
                new Operator(39, "Ace", 1),
                new Operator(40, "Zero", 1),
                new Operator(41, "Thunderbird", 1),
                new Operator(42, "Sens", 2),
                new Operator(43, "Solis", 2),
                new Operator(44, "Alibi", 1),
                new Operator(45, "Aruni", 1),
                new Operator(46, "Kaid", 1),
                new Operator(47, "Mozzie", 1),
                new Operator(48, "Wamai", 1),
                new Operator(49, "Ying", 0),
                new Operator(50, "Sledge", 3),
                new Operator(51, "Twitch", 1),
                new Operator(52, "Rook", 0),
                new Operator(53, "Capitao", 2),
                new Operator(54, "Tachanka", 1),
                new Operator(55, "Lion", 1),
                new Operator(56, "Finka", 1),
                new Operator(57, "Dokkaebi", 1),
                new Operator(58, "Solis", 2),
                new Operator(59, "Warden", 0),
                new Operator(60, "Goyo", 2),
                new Operator(61, "Iana", 2),
                new Operator(62, "Ace", 1)
            };

            operatorCOMBX.DataSource = operators;
            operatorCOMBX.DisplayMember = "Name";
            operatorCOMBX.ValueMember = "Id";
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            ApplyBackground.ApplyGradient(this, e);
        }

        private void baseWindow_Load(object sender, EventArgs e)
        {
            FadeInAnimation.Start(this);
        }


        private void operatorCOMBX_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (operatorCOMBX.SelectedItem is Operator selectedOperator)
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

        private void RecoilControl()
        {
            while (keepRecoilActive)
            {
                if ((GetAsyncKeyState(Keys.LButton) & 0x8000) != 0 && toggleCHKBX.Checked)
                    if ((GetAsyncKeyState(Keys.RButton) & 0x8000) != 0 || !reqAdsCHKBX.Checked)
                    {
                        POINT currentPos;
                        GetCursorPos(out currentPos);
                        SetCursorPos(currentPos.X, currentPos.Y + pullDownRate);
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

        private void closeBTN_Click(object sender, EventArgs e)
        {
            Close();
        }

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

        private void recoilSlider_Scroll(object sender, EventArgs e)
        {
            if (customRecoilCHKBX.Checked)
            {
                customRecoilLabel.Text = $"Custom Recoil: {recoilSlider.Value}";
                pullDownRate = recoilSlider.Value;
            }
        }

        private void customRecoilCHKBX_CheckedChanged(object sender, EventArgs e)
        {
            recoilSlider.Enabled = customRecoilCHKBX.Checked;
        }
    }
}
