using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flappy_bird_game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int gravity = 25, speed = 25,score=0;
        Random random = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            Start();

        }
        void Start() {
            score = 0;
            bird_picturebox.Top = 10;
            pipe1.Left = random.Next(900, 2000);
            pipe2.Left = random.Next(900, 2000);
            pipe3.Left = random.Next(900, 2000);
            pipe4.Left = random.Next(900, 2000);
            timer1.Interval = 10;
            timer1.Enabled = true;
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -10;
            }
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 10;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bird_picturebox.Top += gravity;
            pipe1.Left -= speed;
            pipe2.Left -= speed;
            pipe3.Left -= speed;
            pipe4.Left -= speed;

            if (pipe1.Left <-100)
            {
                score += 1;
                pipe1.Left = random.Next(900, 2000);

               

            }
            if (pipe2.Left < -100)
            {
                score += 1;
                pipe2.Left = random.Next(900, 2000);
               
             
            }
            if (pipe3.Left < -100)
            {
                score += 1;
                pipe3.Left = random.Next(900, 4000);
             
               

            }
            if (pipe4.Left < -100)
            {
                score += 1;
                pipe4.Left = random.Next(900, 4000);
                
              

            }
            lblScore.Text = "Score: " + score.ToString();


          
            if ((bird_picturebox.Bounds.IntersectsWith(pipe1.Bounds)) || (bird_picturebox.Bounds.IntersectsWith(pipe2.Bounds)) ||
                 (bird_picturebox.Bounds.IntersectsWith(pipe3.Bounds)) || (bird_picturebox.Bounds.IntersectsWith(pipe4.Bounds)) ||
                 (bird_picturebox.Bounds.IntersectsWith(ground.Bounds)))

            {
                string text1 = "Game Over \n Score: "+score.ToString();
                timer1.Stop();
              DialogResult dialog =  MessageBox.Show("You Lost",text1,MessageBoxButtons.RetryCancel);
                if (dialog == DialogResult.Retry)
                {
                    
                    Start();
                }
                if (dialog == DialogResult.Cancel)
                {
                    Application.Exit();

                }

            }
               
        }
        


}
}
