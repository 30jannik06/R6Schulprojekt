using R6Schulprojekt.Data;
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
        // DLLImport for Key States
        [DllImport("user32.dll")]
        private static extern short GetAsyncKeyState(Keys vKey);

        // DLLImport for Mouse Move
        [DllImport("user32.dll")]
        private static extern uint SendInput(uint nInputs, INPUT[] pInputs, int cbSize);

        [DllImport("dwmapi.dll")]
        private static extern int DwmEnableBlurBehindWindow(IntPtr hWnd, ref DWM_BLURBEHIND pBlurBehind);

        [StructLayout(LayoutKind.Sequential)]
        public struct DWM_BLURBEHIND
        {
            public uint dwFlags;
            [MarshalAs(UnmanagedType.Bool)]
            public bool fEnable;
            public IntPtr hRgnBlur;
            [MarshalAs(UnmanagedType.Bool)]
            public bool fTransitionOnMaximized;
        }

        // Flags für dwFlags
        public enum DWM_BB : uint
        {
            Enable = 0x00000001,
            BlurRegion = 0x00000002,
            TransitionOnMaximized = 0x00000004
        }

        // Mouse Move Variables
        private const int INPUT_MOUSE = 0;
        private const int MOUSEEVENTF_MOVE = 0x0001;

        // Loads Operators from Data/WeaponDatabse.cs
        List<Operator> operators = OperatorDatabase.Operators;

        private bool keepRecoilActive;

        // Recoil Info Variables
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
            EnableGlass();

            this.BackColor = Color.FromArgb(30, 30, 40);  // kein Alpha, aber dunkel
            this.ForeColor = Color.Gainsboro;
            this.DoubleBuffered = true;
        }

        private void baseWindow_Load(object sender, EventArgs e)
        {
            FadeInAnimation.Start(this);
        }

        // Blur aktivieren
        void EnableGlass()
        {
            var blur = new DWM_BLURBEHIND
            {
                dwFlags = 1,
                fEnable = true,
                hRgnBlur = IntPtr.Zero
            };
            DwmEnableBlurBehindWindow(this.Handle, ref blur);
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

        #region Searchbar
        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            var searchQuery = searchTextBox.Text.ToLower();

            var filteredOperators = operators
                .Where(op => op.Name.ToLower().Contains(searchQuery))
                .ToList();

            operatorListBox.DataSource = filteredOperators;
            operatorListBox.DisplayMember = "Name";
        }
        #endregion

        #region Recoil Control
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
    }
}