namespace R6Schulprojekt
{
    partial class BaseWindow
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseWindow));
            this.closeBTN = new System.Windows.Forms.Button();
            this.toggleCHKBX = new System.Windows.Forms.CheckBox();
            this.reqAdsCHKBX = new System.Windows.Forms.CheckBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.topBarPNL = new System.Windows.Forms.Panel();
            this.hideBTN = new System.Windows.Forms.Button();
            this.mainSettingsPNL = new System.Windows.Forms.Panel();
            this.recoilSlider = new System.Windows.Forms.TrackBar();
            this.customRecoilPNL = new System.Windows.Forms.Panel();
            this.customRecoilLabel = new System.Windows.Forms.Label();
            this.customRecoilCHKBX = new System.Windows.Forms.CheckBox();
            this.comboBoxesPanel = new System.Windows.Forms.Panel();
            this.operatorPicBox = new System.Windows.Forms.PictureBox();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.weaponsListBox = new System.Windows.Forms.ListBox();
            this.weaponCombLabel = new System.Windows.Forms.Label();
            this.operatorListBox = new System.Windows.Forms.ListBox();
            this.operatorCombLabel = new System.Windows.Forms.Label();
            this.topBarPNL.SuspendLayout();
            this.mainSettingsPNL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recoilSlider)).BeginInit();
            this.customRecoilPNL.SuspendLayout();
            this.comboBoxesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.operatorPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // closeBTN
            // 
            this.closeBTN.BackColor = System.Drawing.Color.Transparent;
            this.closeBTN.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeBTN.FlatAppearance.BorderSize = 0;
            this.closeBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.closeBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBTN.Font = new System.Drawing.Font("JetBrains Mono", 9F, System.Drawing.FontStyle.Bold);
            this.closeBTN.ForeColor = System.Drawing.Color.White;
            this.closeBTN.Location = new System.Drawing.Point(303, 0);
            this.closeBTN.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.closeBTN.Name = "closeBTN";
            this.closeBTN.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.closeBTN.Size = new System.Drawing.Size(20, 32);
            this.closeBTN.TabIndex = 1;
            this.closeBTN.Text = "x";
            this.closeBTN.UseVisualStyleBackColor = false;
            this.closeBTN.Click += new System.EventHandler(this.closeBTN_Click);
            // 
            // toggleCHKBX
            // 
            this.toggleCHKBX.AutoSize = true;
            this.toggleCHKBX.Dock = System.Windows.Forms.DockStyle.Top;
            this.toggleCHKBX.Font = new System.Drawing.Font("JetBrains Mono", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toggleCHKBX.ForeColor = System.Drawing.Color.White;
            this.toggleCHKBX.Location = new System.Drawing.Point(0, 0);
            this.toggleCHKBX.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.toggleCHKBX.Name = "toggleCHKBX";
            this.toggleCHKBX.Padding = new System.Windows.Forms.Padding(10, 15, 0, 0);
            this.toggleCHKBX.Size = new System.Drawing.Size(323, 35);
            this.toggleCHKBX.TabIndex = 2;
            this.toggleCHKBX.Text = "Toggle Recoil Script";
            this.toggleCHKBX.UseVisualStyleBackColor = true;
            this.toggleCHKBX.CheckedChanged += new System.EventHandler(this.toggleCHKBX_CheckedChanged);
            // 
            // reqAdsCHKBX
            // 
            this.reqAdsCHKBX.AutoSize = true;
            this.reqAdsCHKBX.Checked = true;
            this.reqAdsCHKBX.CheckState = System.Windows.Forms.CheckState.Checked;
            this.reqAdsCHKBX.Dock = System.Windows.Forms.DockStyle.Top;
            this.reqAdsCHKBX.Font = new System.Drawing.Font("JetBrains Mono", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reqAdsCHKBX.ForeColor = System.Drawing.Color.White;
            this.reqAdsCHKBX.Location = new System.Drawing.Point(0, 35);
            this.reqAdsCHKBX.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.reqAdsCHKBX.Name = "reqAdsCHKBX";
            this.reqAdsCHKBX.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.reqAdsCHKBX.Size = new System.Drawing.Size(323, 20);
            this.reqAdsCHKBX.TabIndex = 3;
            this.reqAdsCHKBX.Text = "REQUIRE ADS";
            this.reqAdsCHKBX.UseVisualStyleBackColor = true;
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleLabel.AutoSize = true;
            this.titleLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.titleLabel.Font = new System.Drawing.Font("JetBrains Mono", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(116, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(96, 18);
            this.titleLabel.TabIndex = 4;
            this.titleLabel.Text = "Geilon Tool";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // topBarPNL
            // 
            this.topBarPNL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.topBarPNL.Controls.Add(this.titleLabel);
            this.topBarPNL.Controls.Add(this.hideBTN);
            this.topBarPNL.Controls.Add(this.closeBTN);
            this.topBarPNL.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBarPNL.Location = new System.Drawing.Point(0, 0);
            this.topBarPNL.Name = "topBarPNL";
            this.topBarPNL.Size = new System.Drawing.Size(323, 32);
            this.topBarPNL.TabIndex = 5;
            this.topBarPNL.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topBarPNL_MouseDown);
            this.topBarPNL.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topBarPNL_MouseMove);
            this.topBarPNL.MouseUp += new System.Windows.Forms.MouseEventHandler(this.topBarPNL_MouseUp);
            // 
            // hideBTN
            // 
            this.hideBTN.BackColor = System.Drawing.Color.Transparent;
            this.hideBTN.Dock = System.Windows.Forms.DockStyle.Right;
            this.hideBTN.FlatAppearance.BorderSize = 0;
            this.hideBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.hideBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hideBTN.Font = new System.Drawing.Font("JetBrains Mono", 9F, System.Drawing.FontStyle.Bold);
            this.hideBTN.ForeColor = System.Drawing.Color.White;
            this.hideBTN.Location = new System.Drawing.Point(283, 0);
            this.hideBTN.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.hideBTN.Name = "hideBTN";
            this.hideBTN.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.hideBTN.Size = new System.Drawing.Size(20, 32);
            this.hideBTN.TabIndex = 1;
            this.hideBTN.Text = "-";
            this.hideBTN.UseVisualStyleBackColor = false;
            this.hideBTN.Click += new System.EventHandler(this.hideBTN_Click);
            // 
            // mainSettingsPNL
            // 
            this.mainSettingsPNL.BackColor = System.Drawing.Color.Transparent;
            this.mainSettingsPNL.Controls.Add(this.reqAdsCHKBX);
            this.mainSettingsPNL.Controls.Add(this.toggleCHKBX);
            this.mainSettingsPNL.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainSettingsPNL.Location = new System.Drawing.Point(0, 32);
            this.mainSettingsPNL.Name = "mainSettingsPNL";
            this.mainSettingsPNL.Size = new System.Drawing.Size(323, 70);
            this.mainSettingsPNL.TabIndex = 7;
            // 
            // recoilSlider
            // 
            this.recoilSlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.recoilSlider.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.recoilSlider.LargeChange = 1;
            this.recoilSlider.Location = new System.Drawing.Point(0, 55);
            this.recoilSlider.Maximum = 100;
            this.recoilSlider.Name = "recoilSlider";
            this.recoilSlider.Size = new System.Drawing.Size(323, 45);
            this.recoilSlider.TabIndex = 7;
            this.recoilSlider.TickStyle = System.Windows.Forms.TickStyle.None;
            this.recoilSlider.Scroll += new System.EventHandler(this.recoilSlider_Scroll);
            // 
            // customRecoilPNL
            // 
            this.customRecoilPNL.BackColor = System.Drawing.Color.Transparent;
            this.customRecoilPNL.Controls.Add(this.customRecoilLabel);
            this.customRecoilPNL.Controls.Add(this.customRecoilCHKBX);
            this.customRecoilPNL.Controls.Add(this.recoilSlider);
            this.customRecoilPNL.Dock = System.Windows.Forms.DockStyle.Top;
            this.customRecoilPNL.Location = new System.Drawing.Point(0, 102);
            this.customRecoilPNL.Name = "customRecoilPNL";
            this.customRecoilPNL.Size = new System.Drawing.Size(323, 100);
            this.customRecoilPNL.TabIndex = 9;
            // 
            // customRecoilLabel
            // 
            this.customRecoilLabel.AutoSize = true;
            this.customRecoilLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.customRecoilLabel.Font = new System.Drawing.Font("JetBrains Mono", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customRecoilLabel.ForeColor = System.Drawing.Color.White;
            this.customRecoilLabel.Location = new System.Drawing.Point(0, 30);
            this.customRecoilLabel.Name = "customRecoilLabel";
            this.customRecoilLabel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.customRecoilLabel.Size = new System.Drawing.Size(129, 16);
            this.customRecoilLabel.TabIndex = 8;
            this.customRecoilLabel.Text = "Custom Recoil: 0";
            // 
            // customRecoilCHKBX
            // 
            this.customRecoilCHKBX.AutoSize = true;
            this.customRecoilCHKBX.Dock = System.Windows.Forms.DockStyle.Top;
            this.customRecoilCHKBX.Font = new System.Drawing.Font("JetBrains Mono", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customRecoilCHKBX.ForeColor = System.Drawing.Color.White;
            this.customRecoilCHKBX.Location = new System.Drawing.Point(0, 0);
            this.customRecoilCHKBX.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.customRecoilCHKBX.Name = "customRecoilCHKBX";
            this.customRecoilCHKBX.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.customRecoilCHKBX.Size = new System.Drawing.Size(323, 30);
            this.customRecoilCHKBX.TabIndex = 9;
            this.customRecoilCHKBX.Text = "Toggle Custom Recoil";
            this.customRecoilCHKBX.UseVisualStyleBackColor = true;
            this.customRecoilCHKBX.CheckedChanged += new System.EventHandler(this.customRecoilCHKBX_CheckedChanged);
            // 
            // comboBoxesPanel
            // 
            this.comboBoxesPanel.Controls.Add(this.operatorPicBox);
            this.comboBoxesPanel.Controls.Add(this.searchTextBox);
            this.comboBoxesPanel.Controls.Add(this.weaponsListBox);
            this.comboBoxesPanel.Controls.Add(this.weaponCombLabel);
            this.comboBoxesPanel.Controls.Add(this.operatorListBox);
            this.comboBoxesPanel.Controls.Add(this.operatorCombLabel);
            this.comboBoxesPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBoxesPanel.Location = new System.Drawing.Point(0, 202);
            this.comboBoxesPanel.Name = "comboBoxesPanel";
            this.comboBoxesPanel.Size = new System.Drawing.Size(323, 320);
            this.comboBoxesPanel.TabIndex = 11;
            // 
            // operatorPicBox
            // 
            this.operatorPicBox.Location = new System.Drawing.Point(170, 192);
            this.operatorPicBox.Name = "operatorPicBox";
            this.operatorPicBox.Size = new System.Drawing.Size(153, 118);
            this.operatorPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.operatorPicBox.TabIndex = 15;
            this.operatorPicBox.TabStop = false;
            // 
            // searchTextBox
            // 
            this.searchTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.searchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchTextBox.Font = new System.Drawing.Font("JetBrains Mono", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.ForeColor = System.Drawing.Color.White;
            this.searchTextBox.Location = new System.Drawing.Point(0, 28);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(153, 22);
            this.searchTextBox.TabIndex = 14;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // weaponsListBox
            // 
            this.weaponsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.weaponsListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.weaponsListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.weaponsListBox.Font = new System.Drawing.Font("JetBrains Mono", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weaponsListBox.ForeColor = System.Drawing.Color.White;
            this.weaponsListBox.FormattingEnabled = true;
            this.weaponsListBox.ItemHeight = 14;
            this.weaponsListBox.Location = new System.Drawing.Point(170, 56);
            this.weaponsListBox.Name = "weaponsListBox";
            this.weaponsListBox.Size = new System.Drawing.Size(153, 128);
            this.weaponsListBox.TabIndex = 13;
            this.weaponsListBox.SelectedIndexChanged += new System.EventHandler(this.weaponsListBox_SelectedIndexChanged);
            // 
            // weaponCombLabel
            // 
            this.weaponCombLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.weaponCombLabel.AutoSize = true;
            this.weaponCombLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.weaponCombLabel.Font = new System.Drawing.Font("JetBrains Mono", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weaponCombLabel.ForeColor = System.Drawing.Color.White;
            this.weaponCombLabel.Location = new System.Drawing.Point(260, 3);
            this.weaponCombLabel.Name = "weaponCombLabel";
            this.weaponCombLabel.Size = new System.Drawing.Size(63, 16);
            this.weaponCombLabel.TabIndex = 9;
            this.weaponCombLabel.Text = "Weapons:";
            this.weaponCombLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // operatorListBox
            // 
            this.operatorListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.operatorListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.operatorListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.operatorListBox.Font = new System.Drawing.Font("JetBrains Mono", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operatorListBox.ForeColor = System.Drawing.Color.White;
            this.operatorListBox.FormattingEnabled = true;
            this.operatorListBox.ItemHeight = 14;
            this.operatorListBox.Location = new System.Drawing.Point(0, 56);
            this.operatorListBox.Name = "operatorListBox";
            this.operatorListBox.Size = new System.Drawing.Size(153, 254);
            this.operatorListBox.TabIndex = 12;
            this.operatorListBox.SelectedIndexChanged += new System.EventHandler(this.operatorListBox_SelectedIndexChanged);
            // 
            // operatorCombLabel
            // 
            this.operatorCombLabel.AutoSize = true;
            this.operatorCombLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.operatorCombLabel.Font = new System.Drawing.Font("JetBrains Mono", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operatorCombLabel.ForeColor = System.Drawing.Color.White;
            this.operatorCombLabel.Location = new System.Drawing.Point(0, 3);
            this.operatorCombLabel.Name = "operatorCombLabel";
            this.operatorCombLabel.Size = new System.Drawing.Size(77, 16);
            this.operatorCombLabel.TabIndex = 8;
            this.operatorCombLabel.Text = "Operators:";
            this.operatorCombLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BaseWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(323, 534);
            this.Controls.Add(this.comboBoxesPanel);
            this.Controls.Add(this.customRecoilPNL);
            this.Controls.Add(this.mainSettingsPNL);
            this.Controls.Add(this.topBarPNL);
            this.Font = new System.Drawing.Font("JetBrains Mono", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "BaseWindow";
            this.Opacity = 0.8D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "R6 Schulprojekt";
            this.Load += new System.EventHandler(this.baseWindow_Load);
            this.topBarPNL.ResumeLayout(false);
            this.topBarPNL.PerformLayout();
            this.mainSettingsPNL.ResumeLayout(false);
            this.mainSettingsPNL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recoilSlider)).EndInit();
            this.customRecoilPNL.ResumeLayout(false);
            this.customRecoilPNL.PerformLayout();
            this.comboBoxesPanel.ResumeLayout(false);
            this.comboBoxesPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.operatorPicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button closeBTN;
        private System.Windows.Forms.CheckBox toggleCHKBX;
        private System.Windows.Forms.CheckBox reqAdsCHKBX;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel topBarPNL;
        private System.Windows.Forms.Panel mainSettingsPNL;
        private System.Windows.Forms.TrackBar recoilSlider;
        private System.Windows.Forms.Panel customRecoilPNL;
        private System.Windows.Forms.CheckBox customRecoilCHKBX;
        private System.Windows.Forms.Label customRecoilLabel;
        private System.Windows.Forms.Button hideBTN;
        private System.Windows.Forms.Panel comboBoxesPanel;
        private System.Windows.Forms.Label weaponCombLabel;
        private System.Windows.Forms.Label operatorCombLabel;
        private System.Windows.Forms.ListBox operatorListBox;
        private System.Windows.Forms.ListBox weaponsListBox;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.PictureBox operatorPicBox;
    }
}