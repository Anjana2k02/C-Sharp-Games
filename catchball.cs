using System;
using System.Drawing;
using System.Windows.Forms;

namespace CatchTheBallGame
{
    public partial class Form1 : Form
    {
        private int ballSpeed = 5;
        private int paddleSpeed = 15;
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            // Set initial positions
            this.panelPaddle.Width = 100;
            this.panelPaddle.Height = 20;
            this.panelPaddle.BackColor = Color.Blue;
            this.panelPaddle.Left = (this.ClientSize.Width - this.panelPaddle.Width) / 2;
            this.panelPaddle.Top = this.ClientSize.Height - this.panelPaddle.Height;

            this.pictureBoxBall.Width = 20;
            this.pictureBoxBall.Height = 20;
            this.pictureBoxBall.BackColor = Color.Red;
            this.pictureBoxBall.Left = random.Next(0, this.ClientSize.Width - this.pictureBoxBall.Width);
            this.pictureBoxBall.Top = 0;

            // Configure the timer
            this.timerGame.Interval = 20;
            this.timerGame.Tick += new EventHandler(this.TimerGame_Tick);
            this.timerGame.Start();
        }

        private void TimerGame_Tick(object sender, EventArgs e)
        {
            // Move the ball
            this.pictureBoxBall.Top += ballSpeed;

            // Ball reset if it falls off the screen
            if (this.pictureBoxBall.Top > this.ClientSize.Height)
            {
                this.pictureBoxBall.Top = 0;
                this.pictureBoxBall.Left = random.Next(0, this.ClientSize.Width - this.pictureBoxBall.Width);
            }

            // Check for collision with the paddle
            if (this.pictureBoxBall.Bounds.IntersectsWith(this.panelPaddle.Bounds))
            {
                this.pictureBoxBall.Top = 0;
                this.pictureBoxBall.Left = random.Next(0, this.ClientSize.Width - this.pictureBoxBall.Width);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && this.panelPaddle.Left > 0)
            {
                this.panelPaddle.Left -= paddleSpeed;
            }
            if (e.KeyCode == Keys.Right && this.panelPaddle.Right < this.ClientSize.Width)
            {
                this.panelPaddle.Left += paddleSpeed;
            }
        }
    }
}
