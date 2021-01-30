using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimonSays
{
    public partial class GameOver : Form
    {
        public static string Score { get; set; }

        public GameOver()
        {
            InitializeComponent();
        }

        private void Setup()
        {
            Program.AddFontFile("scramble-font", resultsLbl);
            Program.AddFontFile("numbers_font", scoreLbl);
            scoreLbl.Text = Score;
        }
        private void Restart(object sender, EventArgs e)
        {
            Program.OpenForm(this, new GameStart());
        }
        private void Quit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GameOver_Load(object sender, EventArgs e)
        {
            Setup();
        }
    }
}
