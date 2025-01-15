namespace R6Schulprojekt
{
    partial class baseWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(baseWindow));
            this.closeBTN = new System.Windows.Forms.Button();
            this.toggleCHKBX = new System.Windows.Forms.CheckBox();
            this.reqAdsCHKBX = new System.Windows.Forms.CheckBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.topBarPNL = new System.Windows.Forms.Panel();
            this.operatorCOMBX = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.recoilSlider = new System.Windows.Forms.TrackBar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.customRecoilCHKBX = new System.Windows.Forms.CheckBox();
            this.customRecoilLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.topBarPNL.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recoilSlider)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // closeBTN
            // 
            this.closeBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.closeBTN.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.closeBTN.FlatAppearance.BorderSize = 0;
            this.closeBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.closeBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBTN.ForeColor = System.Drawing.Color.White;
            this.closeBTN.Location = new System.Drawing.Point(0, 500);
            this.closeBTN.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.closeBTN.Name = "closeBTN";
            this.closeBTN.Size = new System.Drawing.Size(323, 34);
            this.closeBTN.TabIndex = 1;
            this.closeBTN.Text = "Close Tool";
            this.closeBTN.UseVisualStyleBackColor = false;
            this.closeBTN.Click += new System.EventHandler(this.closeBTN_Click);
            // 
            // toggleCHKBX
            // 
            this.toggleCHKBX.AutoSize = true;
            this.toggleCHKBX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toggleCHKBX.ForeColor = System.Drawing.Color.White;
            this.toggleCHKBX.Location = new System.Drawing.Point(13, 25);
            this.toggleCHKBX.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.toggleCHKBX.Name = "toggleCHKBX";
            this.toggleCHKBX.Size = new System.Drawing.Size(136, 19);
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
            this.reqAdsCHKBX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reqAdsCHKBX.ForeColor = System.Drawing.Color.White;
            this.reqAdsCHKBX.Location = new System.Drawing.Point(13, 49);
            this.reqAdsCHKBX.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.reqAdsCHKBX.Name = "reqAdsCHKBX";
            this.reqAdsCHKBX.Size = new System.Drawing.Size(108, 19);
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
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(116, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(81, 15);
            this.titleLabel.TabIndex = 4;
            this.titleLabel.Text = "Geilon Tool";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // topBarPNL
            // 
            this.topBarPNL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.topBarPNL.Controls.Add(this.titleLabel);
            this.topBarPNL.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBarPNL.Location = new System.Drawing.Point(0, 0);
            this.topBarPNL.Name = "topBarPNL";
            this.topBarPNL.Size = new System.Drawing.Size(323, 32);
            this.topBarPNL.TabIndex = 5;
            this.topBarPNL.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topBarPNL_MouseDown);
            this.topBarPNL.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topBarPNL_MouseMove);
            this.topBarPNL.MouseUp += new System.Windows.Forms.MouseEventHandler(this.topBarPNL_MouseUp);
            // 
            // operatorCOMBX
            // 
            this.operatorCOMBX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.operatorCOMBX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.operatorCOMBX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.operatorCOMBX.ForeColor = System.Drawing.Color.White;
            this.operatorCOMBX.FormattingEnabled = true;
            this.operatorCOMBX.ItemHeight = 13;
            this.operatorCOMBX.Items.AddRange(new object[] {
            "ASH",
            "THERMITE",
            "JACKAL"});
            this.operatorCOMBX.Location = new System.Drawing.Point(0, 0);
            this.operatorCOMBX.Name = "operatorCOMBX";
            this.operatorCOMBX.Size = new System.Drawing.Size(323, 21);
            this.operatorCOMBX.TabIndex = 6;
            this.operatorCOMBX.SelectedIndexChanged += new System.EventHandler(this.operatorCOMBX_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.toggleCHKBX);
            this.panel1.Controls.Add(this.reqAdsCHKBX);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(323, 90);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.operatorCOMBX);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 122);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(323, 30);
            this.panel2.TabIndex = 8;
            // 
            // recoilSlider
            // 
            this.recoilSlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.customRecoilCHKBX);
            this.panel3.Controls.Add(this.customRecoilLabel);
            this.panel3.Controls.Add(this.recoilSlider);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 152);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(323, 100);
            this.panel3.TabIndex = 9;
            // 
            // customRecoilCHKBX
            // 
            this.customRecoilCHKBX.AutoSize = true;
            this.customRecoilCHKBX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customRecoilCHKBX.ForeColor = System.Drawing.Color.White;
            this.customRecoilCHKBX.Location = new System.Drawing.Point(13, 10);
            this.customRecoilCHKBX.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.customRecoilCHKBX.Name = "customRecoilCHKBX";
            this.customRecoilCHKBX.Size = new System.Drawing.Size(147, 19);
            this.customRecoilCHKBX.TabIndex = 9;
            this.customRecoilCHKBX.Text = "Toggle Custom Recoil";
            this.customRecoilCHKBX.UseVisualStyleBackColor = true;
            this.customRecoilCHKBX.CheckedChanged += new System.EventHandler(this.customRecoilCHKBX_CheckedChanged);
            // 
            // customRecoilLabel
            // 
            this.customRecoilLabel.AutoSize = true;
            this.customRecoilLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customRecoilLabel.ForeColor = System.Drawing.Color.White;
            this.customRecoilLabel.Location = new System.Drawing.Point(12, 33);
            this.customRecoilLabel.Name = "customRecoilLabel";
            this.customRecoilLabel.Size = new System.Drawing.Size(100, 15);
            this.customRecoilLabel.TabIndex = 8;
            this.customRecoilLabel.Text = "Custom Recoil: 0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::R6Schulprojekt.Properties.Resources.Logo1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 252);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(323, 248);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // baseWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(323, 534);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.topBarPNL);
            this.Controls.Add(this.closeBTN);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "baseWindow";
            this.Opacity = 0.8D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "R6 Schulprojekt";
            this.Load += new System.EventHandler(this.baseWindow_Load);
            this.topBarPNL.ResumeLayout(false);
            this.topBarPNL.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.recoilSlider)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button closeBTN;
        private System.Windows.Forms.CheckBox toggleCHKBX;
        private System.Windows.Forms.CheckBox reqAdsCHKBX;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel topBarPNL;
        private System.Windows.Forms.ComboBox operatorCOMBX;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TrackBar recoilSlider;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox customRecoilCHKBX;
        private System.Windows.Forms.Label customRecoilLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}