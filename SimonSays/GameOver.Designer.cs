
namespace SimonSays
{
    partial class GameOver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameOver));
            this.resultsLbl = new System.Windows.Forms.Label();
            this.restart = new FontAwesome.Sharp.IconButton();
            this.exit = new FontAwesome.Sharp.IconButton();
            this.scoreLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // resultsLbl
            // 
            this.resultsLbl.AutoSize = true;
            this.resultsLbl.BackColor = System.Drawing.Color.Transparent;
            this.resultsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultsLbl.ForeColor = System.Drawing.Color.White;
            this.resultsLbl.Location = new System.Drawing.Point(35, 501);
            this.resultsLbl.Name = "resultsLbl";
            this.resultsLbl.Size = new System.Drawing.Size(318, 31);
            this.resultsLbl.TabIndex = 0;
            this.resultsLbl.Text = "You lost, your score was:";
            // 
            // restart
            // 
            this.restart.BackColor = System.Drawing.Color.Transparent;
            this.restart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.restart.FlatAppearance.BorderSize = 0;
            this.restart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.restart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.restart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restart.IconChar = FontAwesome.Sharp.IconChar.Redo;
            this.restart.IconColor = System.Drawing.Color.White;
            this.restart.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.restart.IconSize = 120;
            this.restart.Location = new System.Drawing.Point(863, 547);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(97, 129);
            this.restart.TabIndex = 15;
            this.restart.UseVisualStyleBackColor = false;
            this.restart.Click += new System.EventHandler(this.Restart);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.exit.IconColor = System.Drawing.Color.White;
            this.exit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.exit.IconSize = 100;
            this.exit.Location = new System.Drawing.Point(863, 29);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(97, 104);
            this.exit.TabIndex = 16;
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.Quit);
            // 
            // scoreLbl
            // 
            this.scoreLbl.AutoSize = true;
            this.scoreLbl.BackColor = System.Drawing.Color.Transparent;
            this.scoreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLbl.ForeColor = System.Drawing.Color.White;
            this.scoreLbl.Location = new System.Drawing.Point(43, 547);
            this.scoreLbl.Name = "scoreLbl";
            this.scoreLbl.Size = new System.Drawing.Size(56, 61);
            this.scoreLbl.TabIndex = 17;
            this.scoreLbl.Text = "0";
            // 
            // GameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::SimonSays.Properties.Resources.gameover_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(986, 688);
            this.Controls.Add(this.scoreLbl);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.restart);
            this.Controls.Add(this.resultsLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1012, 759);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1012, 759);
            this.Name = "GameOver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  GameOver";
            this.Load += new System.EventHandler(this.GameOver_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label resultsLbl;
        private FontAwesome.Sharp.IconButton restart;
        private FontAwesome.Sharp.IconButton exit;
        private System.Windows.Forms.Label scoreLbl;
    }
}
