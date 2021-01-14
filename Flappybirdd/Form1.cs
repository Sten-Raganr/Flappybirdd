using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappybirdd
{
    public partial class Form1 : Form
    {
        int gravity = 10;
        int pipespeed = 6;
        int score = 0;
        int snowgrav = 10;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bird.Top += gravity;
            pipetop.Left -= pipespeed;
            pipebot.Left -= pipespeed;
            snowflake.Top += snowgrav;
            snowflake1.Top += snowgrav;
            scoreLabel.Text = $"Score: {score}";

            if (pipetop.Left < -150)
            {
                pipetop.Left = 650;
                score++;
            }
            if (pipebot.Left < -150)
            {
                pipebot.Left = 525;
                score++;
            }
            if(snowflake.Top > 800)
            {
                snowflake.Top = 100; 
            }
            if (snowflake1.Top > 750)
            {
                snowflake.Top = 99;
                snowgrav= snowgrav - 1;
            }
            if (bird.Top < -25)
            {
                Gameover();
            }
            if (bird.Bounds.IntersectsWith(pipetop.Bounds) || bird.Bounds.IntersectsWith(pipebot.Bounds) || bird.Bounds.IntersectsWith(ground.Bounds))
            {
                Gameover();
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -5;
            }

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 5;
            }
        }
        private void Gameover()
        {
            timer1.Stop();
            scoreLabel.Text = "gameover";
            playagain.Visible = true;
        }

        private void playagain_Click(object sender, EventArgs e)
        {
            Form1 newform = new Form1();
            newform.Show();
            this.Dispose(false);
        }

        private void pipetop_Click(object sender, EventArgs e)
        {

        }

        private void ground_Click(object sender, EventArgs e)
        {

        }
    }
}
