using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace OnlineMart_Trivial
{
    public partial class cart : Form
    {
        public cart()
        {
            InitializeComponent();
            RestartGame();
        }

        #region No Tick Constrols
        //Optimized Controls(No Tick)
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
        #endregion

        bool goLeft, goRight;
        int speed = 5;
        int coin = 0;
        int missed = 0;
        bool added = false;


        Random randX = new Random();
        Random randY = new Random();

        private void FormMiniGames_Load(object sender, EventArgs e)
        {

        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            labelCoin.Text = "Coin Collected : " + coin;
            labelMissed.Text = "Missed: " + missed;

            if (goLeft && player.Left > 0)
            {
                player.Left -= 12;
                player.Image = Properties.Resources.cart_flipped;
            }

            if(goRight && player.Left + player.Width < this.ClientSize.Width)
            {
                player.Left += 12;
                player.Image = Properties.Resources.cart;
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "coin")
                {
                    x.Top += speed;

                    if (x.Top + x.Height > this.ClientSize.Height)
                    {
                        x.Top = randY.Next(80, 300) * -1;
                        x.Left = randX.Next(5, this.ClientSize.Width - x.Width);
                        missed += 1;

                        var original = this.Location;
                        var rnd = new Random(1337);
                        const int shake_amplitude = 10;
                        for (int i = 0; i < 10; i++)
                        {
                            this.Location = new Point(original.X + rnd.Next(-shake_amplitude, shake_amplitude), original.Y + rnd.Next(-shake_amplitude, shake_amplitude));
                            System.Threading.Thread.Sleep(20);
                        }
                        this.Location = original;
                    }

                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        x.Top = randY.Next(80, 300) * -1;
                        x.Left = randX.Next(5, this.ClientSize.Width - x.Width);
                        coin += 1;
                    }
                }
            }

            if (coin > 10 && !added) {
                speed += 5;
                added = true;
            }

            if (missed > 5)
            {
                gameTimer.Stop();
                MessageBox.Show("Game Over!" + Environment.NewLine + "We've lost so many coins!");
                RestartGame();
            }
        }

        private void FormMiniGames_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) goLeft = true;
            if (e.KeyCode == Keys.Right) goRight = true;

        }

        private void FormMiniGames_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) goLeft = false;
            if (e.KeyCode == Keys.Right) goRight = false;
        }

        private void RestartGame()
        {
            foreach(Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "coin")
                {
                    x.Top = randY.Next(80, 300) * -1;
                    x.Left = randX.Next(5, this.ClientSize.Width - x.Width);
                }
            }

            player.Left = this.ClientSize.Width / 2;
            player.Image = Properties.Resources.cart;

            goLeft = false;
            goRight = false;
            added = false;

            speed = 8;
            coin = 0;
            missed = 0;

            gameTimer.Start();
        }
    }
}
