using FontAwesome.Sharp;
using SimonSays.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimonSays
{
    public partial class Game : Form
    {
        private readonly Random colorGen = new Random();
        private List<int> colorList = new List<int>();

        private readonly SoundPlayer orangeSound = new SoundPlayer(Resources.Orange);
        private readonly SoundPlayer blueSound = new SoundPlayer(Resources.Blue);
        private readonly SoundPlayer greenSound = new SoundPlayer(Resources.Green);
        private readonly SoundPlayer yellowSound = new SoundPlayer(Resources.Yellow);
        private readonly SoundPlayer purpleSound = new SoundPlayer(Resources.Purple);
        private readonly SoundPlayer redSound = new SoundPlayer(Resources.Red);

        private int position = 0;
        private int lives;
        private bool isActive = false;
        private bool twoLives, threeLives;
        private bool sound = true;

        public Game()
        {
            InitializeComponent();

            Setup();
        }

        private void Setup()
        {
            Program.AddFontFile("scramble-font", scoreLbl, menuStrip);
            Program.AddFontFile("numbers_font", scoreNum);
            startBtn.IconChar = IconChar.PlayCircle;
        }
        /// Generates the first color and then creates a new thread of showColors.
        public void Play()
        {
            twoLives = threeLives = false;
            scoreNum.Text = "0";
            isActive = true;
            lives = Convert.ToInt32(GameStart.Lives);

            if (lives == 2) twoLives = true;
            if (lives == 3) threeLives = true;

            colorList = new List<int>
            {
                colorGen.Next(6)
            };

            new Thread(ShowColors).Start();
        }

        /// Makes the button that corresponds to the colors in the list light up in order
        /// with a delay.
        private async void ShowColors()
        {
            isActive = false;

            foreach (int color in colorList)
            {
                //Will make the button that corresponds to the color in the
                //colorList light up.
                switch (color)
                {
                    case 0:
                        Orange.BackColor = Color.FromArgb(241, 244, 246);
                        if (sound) orangeSound.Play();
                        await Task.Delay(250);
                        Orange.BackColor = Color.FromArgb(255, 128, 0);
                        break;

                    case 1:
                        Blue.BackColor = Color.FromArgb(241, 244, 246);
                        if (sound) blueSound.Play();
                        await Task.Delay(250);
                        Blue.BackColor = Color.Blue;
                        break;

                    case 2:
                        Green.BackColor = Color.FromArgb(241, 244, 246);
                        if (sound) greenSound.Play();
                        await Task.Delay(250);
                        Green.BackColor = Color.FromArgb(0, 192, 0);
                        break;

                    case 3:
                        Purple.BackColor = Color.FromArgb(241, 244, 246);
                        if (sound) purpleSound.Play();
                        await Task.Delay(250);
                        Purple.BackColor = Color.FromArgb(192, 0, 192);
                        break;

                    case 4:
                        Red.BackColor = Color.FromArgb(241, 244, 246);
                        if (sound) redSound.Play();
                        await Task.Delay(250);
                        Red.BackColor = Color.Red;
                        break;

                    case 5:
                        Yellow.BackColor = Color.White;
                        if (sound) yellowSound.Play();
                        await Task.Delay(250);
                        Yellow.BackColor = Color.Yellow;
                        break;
                }

                await Task.Delay(250);
            }

            isActive = true;
        }

        /// This method is called everytime a button is pressed to check
        /// if that is the correct button. It controls the score and when
        /// the user has lost.
        /// 
        /// testColor is the color corrsponding to 
        /// the button that the user pressed
        private async void IsCorrect(int testColor)
        {
            if (!isActive)
            {
                return;
            }
            else if (colorList[position] == testColor)
            {
                position++;
                await Task.Delay(500);
            }
            else
            {
                lives--;
                if (threeLives)
                {
                    if (lives == 2)
                    {
                        livesIcon.IconChar = IconChar.Heartbeat;
                        return;
                    }
                    if (lives == 1)
                    {
                        livesIcon.IconChar = IconChar.HeartBroken;
                        return;
                    }
                }
                if (twoLives)
                {
                    if (lives == 1)
                    {
                        livesIcon.IconChar = IconChar.HeartBroken;
                        return;
                    }
                }
                if (lives == 0)
                {
                    livesIcon.IconChar = IconChar.Dizzy;
                    Program.OpenForm(this, new GameOver());
                    position = 0;
                    isActive = false;
                    colorList = new List<int>();
                    return;
                }
            }

            if (position >= colorList.Count)
            {
                colorList.Add(colorGen.Next(6));
                position = 0;
                new Thread(ShowColors).Start();
            }

            scoreNum.Text = (colorList.Count - 1).ToString();
            GameOver.Score = (colorList.Count - 1).ToString();
        }

        /// Listeners
        public void Replay(object sender, EventArgs e)
        {
            Play();
            startBtn.IconChar = IconChar.Redo;
        }
        private void Orange_Click(object sender, EventArgs e)
        {
            if (sound) orangeSound.Play();
            IsCorrect(0);
        }
        private void Blue_Click(object sender, EventArgs e)
        {
            if (sound) blueSound.Play();
            IsCorrect(1);
        }
        private void Green_Click(object sender, EventArgs e)
        {
            if (sound) greenSound.Play();
            IsCorrect(2);
        }
        private void Purple_Click(object sender, EventArgs e)
        {
            if (sound) purpleSound.Play();
            IsCorrect(3);
        }
        private void Red_Click(object sender, EventArgs e)
        {
            if (sound) redSound.Play();
            IsCorrect(4);
        }
        private void Yellow_Click(object sender, EventArgs e)
        {
            if (sound) yellowSound.Play();
            IsCorrect(5);
        }

        private void about(object sender, EventArgs e)
        {
            MessageBox.Show("Simon says game created by David Ohayon & Elie Barkate", "Creators");
        }
        private void soundOnOff(object sender, EventArgs e)
        {
            sound = !sound;
            if (!sound)
                soundMenuItm.Text = "Sound Off";
            else
                soundMenuItm.Text = "Sound On";
        }

        private void soundMenuItm_MouseEnter(object sender, EventArgs e)
        {
            Program.AddFontFile("scramble-font", menuStrip);
        }
        private void soundMenuItm_MouseLeave(object sender, EventArgs e)
        {
            Program.AddFontFile("scramble-font", menuStrip);
        }
        private void aboutMenuItm_MouseEnter(object sender, EventArgs e)
        {
            Program.AddFontFile("scramble-font", menuStrip);
        }
        private void aboutMenuItm_MouseLeave(object sender, EventArgs e)
        {
            Program.AddFontFile("scramble-font", menuStrip);
        }
    }
}