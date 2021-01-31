
namespace SimonSays
{
    partial class GameStart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameStart));
            this.lives = new System.Windows.Forms.NumericUpDown();
            this.playBtn = new FontAwesome.Sharp.IconButton();
            this.livesLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lives)).BeginInit();
            this.SuspendLayout();
            // 
            // lives
            // 
            this.lives.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(176)))), ((int)(((byte)(0)))));
            this.lives.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lives.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lives.ForeColor = System.Drawing.Color.White;
            this.lives.Location = new System.Drawing.Point(357, 756);
            this.lives.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.lives.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.lives.Name = "lives";
            this.lives.ReadOnly = true;
            this.lives.Size = new System.Drawing.Size(80, 67);
            this.lives.TabIndex = 8;
            this.lives.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lives.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // playBtn
            // 
            this.playBtn.BackColor = System.Drawing.Color.Transparent;
            this.playBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playBtn.FlatAppearance.BorderSize = 0;
            this.playBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.playBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.playBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playBtn.IconChar = FontAwesome.Sharp.IconChar.PlayCircle;
            this.playBtn.IconColor = System.Drawing.Color.White;
            this.playBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.playBtn.IconSize = 145;
            this.playBtn.Location = new System.Drawing.Point(406, 239);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(163, 143);
            this.playBtn.TabIndex = 15;
            this.playBtn.UseVisualStyleBackColor = false;
            this.playBtn.Click += new System.EventHandler(this.Start);
            // 
            // livesLbl
            // 
            this.livesLbl.AutoSize = true;
            this.livesLbl.BackColor = System.Drawing.Color.Transparent;
            this.livesLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.livesLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.livesLbl.Location = new System.Drawing.Point(350, 695);
            this.livesLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.livesLbl.Name = "livesLbl";
            this.livesLbl.Size = new System.Drawing.Size(116, 42);
            this.livesLbl.TabIndex = 16;
            this.livesLbl.Text = "Lives:";
            // 
            // GameStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SimonSays.Properties.Resources.start_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(974, 929);
            this.Controls.Add(this.livesLbl);
            this.Controls.Add(this.playBtn);
            this.Controls.Add(this.lives);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1000, 1000);
            this.Name = "GameStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  Start";
            ((System.ComponentModel.ISupportInitialize)(this.lives)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton playBtn;
        private System.Windows.Forms.Label livesLbl;
        public System.Windows.Forms.NumericUpDown lives;
    }
}
