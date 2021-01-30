namespace SimonSays
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.Orange = new System.Windows.Forms.Button();
            this.Blue = new System.Windows.Forms.Button();
            this.Green = new System.Windows.Forms.Button();
            this.scoreLbl = new System.Windows.Forms.Label();
            this.gamePanel = new System.Windows.Forms.TableLayoutPanel();
            this.Purple = new System.Windows.Forms.Button();
            this.Yellow = new System.Windows.Forms.Button();
            this.Red = new System.Windows.Forms.Button();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.scoreNum = new System.Windows.Forms.Label();
            this.livesIcon = new FontAwesome.Sharp.IconPictureBox();
            this.startBtn = new FontAwesome.Sharp.IconButton();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.soundMenuItm = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenuItm = new System.Windows.Forms.ToolStripMenuItem();
            this.gamePanel.SuspendLayout();
            this.controlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.livesIcon)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // Orange
            // 
            this.Orange.AutoSize = true;
            this.Orange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Orange.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Orange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Orange.Location = new System.Drawing.Point(6, 6);
            this.Orange.Margin = new System.Windows.Forms.Padding(6);
            this.Orange.Name = "Orange";
            this.Orange.Size = new System.Drawing.Size(315, 197);
            this.Orange.TabIndex = 0;
            this.Orange.UseVisualStyleBackColor = false;
            this.Orange.Click += new System.EventHandler(this.Orange_Click);
            // 
            // Blue
            // 
            this.Blue.AutoSize = true;
            this.Blue.BackColor = System.Drawing.Color.Blue;
            this.Blue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Blue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Blue.Location = new System.Drawing.Point(6, 215);
            this.Blue.Margin = new System.Windows.Forms.Padding(6);
            this.Blue.Name = "Blue";
            this.Blue.Size = new System.Drawing.Size(315, 197);
            this.Blue.TabIndex = 7;
            this.Blue.UseVisualStyleBackColor = false;
            this.Blue.Click += new System.EventHandler(this.Blue_Click);
            // 
            // Green
            // 
            this.Green.AutoSize = true;
            this.Green.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Green.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Green.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Green.Location = new System.Drawing.Point(6, 424);
            this.Green.Margin = new System.Windows.Forms.Padding(6);
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(315, 199);
            this.Green.TabIndex = 8;
            this.Green.UseVisualStyleBackColor = false;
            this.Green.Click += new System.EventHandler(this.Green_Click);
            // 
            // scoreLbl
            // 
            this.scoreLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.scoreLbl.AutoSize = true;
            this.scoreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.scoreLbl.Location = new System.Drawing.Point(179, 49);
            this.scoreLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.scoreLbl.Name = "scoreLbl";
            this.scoreLbl.Size = new System.Drawing.Size(99, 33);
            this.scoreLbl.TabIndex = 12;
            this.scoreLbl.Text = "Score:";
            // 
            // gamePanel
            // 
            this.gamePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gamePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(219)))));
            this.gamePanel.ColumnCount = 2;
            this.gamePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.gamePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.gamePanel.Controls.Add(this.Orange, 0, 0);
            this.gamePanel.Controls.Add(this.Purple, 1, 0);
            this.gamePanel.Controls.Add(this.Blue, 0, 1);
            this.gamePanel.Controls.Add(this.Yellow, 1, 2);
            this.gamePanel.Controls.Add(this.Red, 1, 1);
            this.gamePanel.Controls.Add(this.Green, 0, 2);
            this.gamePanel.Location = new System.Drawing.Point(0, 65);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.RowCount = 3;
            this.gamePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.gamePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.gamePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.gamePanel.Size = new System.Drawing.Size(654, 629);
            this.gamePanel.TabIndex = 14;
            // 
            // Purple
            // 
            this.Purple.AutoSize = true;
            this.Purple.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Purple.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Purple.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Purple.Location = new System.Drawing.Point(333, 6);
            this.Purple.Margin = new System.Windows.Forms.Padding(6);
            this.Purple.Name = "Purple";
            this.Purple.Size = new System.Drawing.Size(315, 197);
            this.Purple.TabIndex = 9;
            this.Purple.UseVisualStyleBackColor = false;
            this.Purple.Click += new System.EventHandler(this.Purple_Click);
            // 
            // Yellow
            // 
            this.Yellow.AutoSize = true;
            this.Yellow.BackColor = System.Drawing.Color.Yellow;
            this.Yellow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Yellow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Yellow.Location = new System.Drawing.Point(333, 424);
            this.Yellow.Margin = new System.Windows.Forms.Padding(6);
            this.Yellow.Name = "Yellow";
            this.Yellow.Size = new System.Drawing.Size(315, 199);
            this.Yellow.TabIndex = 11;
            this.Yellow.UseVisualStyleBackColor = false;
            this.Yellow.Click += new System.EventHandler(this.Yellow_Click);
            // 
            // Red
            // 
            this.Red.AutoSize = true;
            this.Red.BackColor = System.Drawing.Color.Red;
            this.Red.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Red.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Red.Location = new System.Drawing.Point(333, 215);
            this.Red.Margin = new System.Windows.Forms.Padding(6);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(315, 197);
            this.Red.TabIndex = 10;
            this.Red.UseVisualStyleBackColor = false;
            this.Red.Click += new System.EventHandler(this.Red_Click);
            // 
            // controlPanel
            // 
            this.controlPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(156)))), ((int)(((byte)(167)))));
            this.controlPanel.Controls.Add(this.scoreNum);
            this.controlPanel.Controls.Add(this.livesIcon);
            this.controlPanel.Controls.Add(this.startBtn);
            this.controlPanel.Controls.Add(this.scoreLbl);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.controlPanel.Location = new System.Drawing.Point(0, 691);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(654, 132);
            this.controlPanel.TabIndex = 15;
            // 
            // scoreNum
            // 
            this.scoreNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.scoreNum.AutoSize = true;
            this.scoreNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreNum.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.scoreNum.Location = new System.Drawing.Point(389, 49);
            this.scoreNum.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.scoreNum.Name = "scoreNum";
            this.scoreNum.Size = new System.Drawing.Size(46, 51);
            this.scoreNum.TabIndex = 16;
            this.scoreNum.Text = "0";
            // 
            // livesIcon
            // 
            this.livesIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.livesIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(156)))), ((int)(((byte)(167)))));
            this.livesIcon.ForeColor = System.Drawing.Color.RoyalBlue;
            this.livesIcon.IconChar = FontAwesome.Sharp.IconChar.Heart;
            this.livesIcon.IconColor = System.Drawing.Color.RoyalBlue;
            this.livesIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.livesIcon.IconSize = 81;
            this.livesIcon.Location = new System.Drawing.Point(561, 27);
            this.livesIcon.Name = "livesIcon";
            this.livesIcon.Size = new System.Drawing.Size(81, 81);
            this.livesIcon.TabIndex = 15;
            this.livesIcon.TabStop = false;
            // 
            // startBtn
            // 
            this.startBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.startBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startBtn.FlatAppearance.BorderSize = 0;
            this.startBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.startBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.startBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startBtn.IconChar = FontAwesome.Sharp.IconChar.PlayCircle;
            this.startBtn.IconColor = System.Drawing.Color.White;
            this.startBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.startBtn.IconSize = 85;
            this.startBtn.Location = new System.Drawing.Point(12, 27);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(97, 81);
            this.startBtn.TabIndex = 14;
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.Replay);
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(156)))), ((int)(((byte)(167)))));
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.soundMenuItm,
            this.aboutMenuItm});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(12, 12, 0, 12);
            this.menuStrip.Size = new System.Drawing.Size(654, 78);
            this.menuStrip.TabIndex = 16;
            this.menuStrip.Text = "menuStrip1";
            // 
            // soundMenuItm
            // 
            this.soundMenuItm.Name = "soundMenuItm";
            this.soundMenuItm.Size = new System.Drawing.Size(207, 54);
            this.soundMenuItm.Text = "Sound On";
            this.soundMenuItm.Click += new System.EventHandler(this.soundOnOff);
            this.soundMenuItm.MouseEnter += new System.EventHandler(this.soundMenuItm_MouseEnter);
            this.soundMenuItm.MouseLeave += new System.EventHandler(this.soundMenuItm_MouseLeave);
            // 
            // aboutMenuItm
            // 
            this.aboutMenuItm.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.aboutMenuItm.Name = "aboutMenuItm";
            this.aboutMenuItm.Size = new System.Drawing.Size(144, 54);
            this.aboutMenuItm.Text = "About";
            this.aboutMenuItm.Click += new System.EventHandler(this.about);
            this.aboutMenuItm.MouseEnter += new System.EventHandler(this.aboutMenuItm_MouseEnter);
            this.aboutMenuItm.MouseLeave += new System.EventHandler(this.aboutMenuItm_MouseLeave);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(654, 823);
            this.Controls.Add(this.controlPanel);
            this.Controls.Add(this.gamePanel);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximumSize = new System.Drawing.Size(1360, 1700);
            this.MinimumSize = new System.Drawing.Size(680, 850);
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  Simon Says";
            this.gamePanel.ResumeLayout(false);
            this.gamePanel.PerformLayout();
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.livesIcon)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Orange;
        private System.Windows.Forms.Button Blue;
        private System.Windows.Forms.Button Green;
        private System.Windows.Forms.Label scoreLbl;
        private System.Windows.Forms.TableLayoutPanel gamePanel;
        private System.Windows.Forms.Button Purple;
        private System.Windows.Forms.Button Yellow;
        private System.Windows.Forms.Button Red;
        private System.Windows.Forms.Panel controlPanel;
        private FontAwesome.Sharp.IconButton startBtn;
        private FontAwesome.Sharp.IconPictureBox livesIcon;
        public System.Windows.Forms.Label scoreNum;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem soundMenuItm;
        private System.Windows.Forms.ToolStripMenuItem aboutMenuItm;
    }
}
