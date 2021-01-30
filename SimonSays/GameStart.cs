using System;
using System.Windows.Forms;

namespace SimonSays
{
    public partial class GameStart : Form
    {
        public static string Lives { get; set; }

        public GameStart()
        {
            InitializeComponent();
        }

        private void Setup()
        {
            Program.AddFontFile("scramble-font", livesLbl);
            Program.AddFontFile("numbers_font", lives);
        }
        private void Start(object sender, EventArgs e)
        {
            Program.OpenForm(this, new Game());
            Lives = lives.Value.ToString();
        }

        private void GameStart_Load(object sender, EventArgs e)
        {
            Setup();
        }
    }
}
