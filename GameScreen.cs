using Quiz_Coursework.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Quiz_Coursework
{
    public partial class GameScreen : Form
    {
        new WindowsMediaPlayer Bang1 = new WindowsMediaPlayer();
        new WindowsMediaPlayer Bang2 = new WindowsMediaPlayer();
        new WindowsMediaPlayer Bang3 = new WindowsMediaPlayer();
        int moveLeft = 0;
        int enemyMove1 = 5;
        int enemyMove2 = 5;
        int enemyMove3 = 5;
        Random rnd = new Random();
        int bulletSpeed = 8;
        bool shooting = false;
        int score = 0;
        public GameScreen()
        {
            InitializeComponent();
            enemy1.Image = Properties.Resources.Enemy;
            enemy2.Image = Properties.Resources.Enemy;
            enemy3.Image = Properties.Resources.Enemy;
            enemy1.Top = -500;
            enemy2.Top = -900;
            enemy3.Top = -1300;
            bullet.Top = -100;
            bullet.Left = -100;
            Bang1.URL = @"Boom.mp3";
            Bang1.controls.stop();
            Bang2.URL = @"Boom.mp3";
            Bang2.controls.stop();
            Bang3.URL = @"Boom.mp3";
            Bang3.controls.stop();
        }

        private void onKeyDown(object sender, KeyEventArgs e)
        {
            if (clickCount == 1)
            {
                clickCount--;
                playTimer.Start();
            }
            else
            {
                if (e.KeyCode == Keys.Left)
                {
                    if (player.Location.X < 0)
                    {
                        moveLeft = 0;
                    }
                    else
                    {
                        moveLeft = -5;
                    }
                }
                else if (e.KeyCode == Keys.Right)
                {
                    if (player.Location.X > 700)
                    {
                        moveLeft = 0;
                    }
                    else
                    {
                        moveLeft = 5;
                    }
                }
                else if (e.KeyCode == Keys.Space)
                {
                    if (shooting == false)
                    {
                        bulletSpeed = 8;
                        bullet.Left = player.Left + 50; bullet.Top = player.Top;
                        shooting = true;
                    }
                }
            }
        }

        private void onKeyUp(object sender, KeyEventArgs e)
        {
            if (clickCount == 1)
            {
                clickCount--;
                playTimer.Start();
            }
            else
            {
                if (e.KeyCode == Keys.Left)
                {
                    moveLeft = 0;
                }
                else if (e.KeyCode == Keys.Right)
                {
                    moveLeft = 0;
                }
            }
        }

        private void playTimer_Tick(object sender, EventArgs e)
        {
            player.Left += moveLeft; bullet.Top -= bulletSpeed;
            enemy1.Top += enemyMove1; enemy2.Top += enemyMove2; enemy3.Top += enemyMove3;
            scoreText.Text = "" + score;
            if (enemy1.Top == 850 || enemy2.Top == 850 || enemy3.Top == 850)
            {
                gameOver();
            }
            if (shooting && bullet.Top < 0)
            {
                shooting = false;
                bulletSpeed = 0;
                bullet.Top = -100;
                bullet.Left = -100;
            }
            enemyHit();
        }
        private void enemyHit()
        {
            // bullet collide with the first enemy plane
            if (bullet.Bounds.IntersectsWith(enemy1.Bounds))
            {
                Bang1.controls.play();
                enemy1.Image = Properties.Resources.GameBoom;
                score += 1;
                enemyMove1 = 0;
                bad1.Start();
            }
            // collide with the second enemy plane
            else if (bullet.Bounds.IntersectsWith(enemy2.Bounds))
            {
                Bang2.controls.play();
                enemy2.Image = Properties.Resources.GameBoom;
                score += 1;
                enemyMove2 = 0;
                bad2.Start();
            }
            // finally bullet collides with the 
            else if (bullet.Bounds.IntersectsWith(enemy3.Bounds))
            {
                Bang3.controls.play();
                enemy2.Image = Properties.Resources.GameBoom;
                score += 1;
                enemyMove3 = 0;
                bad3.Start();
            }
            else
            {
                enemy1.Image = Properties.Resources.Enemy;
                enemy2.Image = Properties.Resources.Enemy;
                enemy3.Image = Properties.Resources.Enemy;
            }
        }
        private void gameOver()
        {
            playTimer.Enabled = false;
            Hide();
            new GameEndScreen(score).Show();
        }

        private void returnToMenuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Question.click.controls.play();
            Hide();
            new GameStartScreen(Player.Username).Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Question.click.controls.play();
            DialogResult dr = MessageBox.Show("Are you sure you want to log out?", "", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    Hide();
                    StartScreen.Player.ResetPlayer();
                    Question.qz1 = false;
                    Question.qz2 = false;
                    Question.multCount = 0;
                    Question.fillCount = 0;
                    Question.trueCount = 0;
                    Question.dragCount = 0;
                    Question.questNo = 0;
                    Question.used.Clear();
                    new LoginScreen().Show();
                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Question.click.controls.play();
            DialogResult dr = MessageBox.Show("Are you sure you want to Quit?", "", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    Application.Exit();
                    break;
                case DialogResult.No:
                    break;
            }
        }

        int clickCount = 0;
        private void pausePlayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Question.click.controls.play();
            clickCount++;
            if (clickCount == 1)
            {
                playTimer.Stop();
            }
            else if (clickCount == 2)
            {
                playTimer.Start();
                clickCount = 0;
            }
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Question.click.controls.play();
            Hide();
            new GameScreen().Show();
        }

        private void bad1_Tick(object sender, EventArgs e)
        {
            enemy1.Image = Properties.Resources.Enemy;
            enemy1.Top = -500;
            int ranP = rnd.Next(1, 300);
            enemy1.Left = ranP;
            shooting = false;
            bulletSpeed = 0;
            bullet.Top = -100;
            bullet.Left = -100;
            enemyMove1 = 5;
            bad1.Stop();
        }

        private void bad2_Tick(object sender, EventArgs e)
        {
            enemy2.Image = Properties.Resources.Enemy;
            enemy2.Top = -900;
            int ranP = rnd.Next(1, 400);
            enemy2.Left = ranP;
            shooting = false;
            bulletSpeed = 0;
            bullet.Top = -100;
            bullet.Left = -100;
            enemyMove2 = 5;
            bad2.Stop();
        }

        private void bad3_Tick(object sender, EventArgs e)
        {
            enemy3.Image = Properties.Resources.Enemy;
            enemy3.Top = -1300;
            int ranP = rnd.Next(1, 500);
            enemy3.Left = ranP;
            shooting = false;
            bulletSpeed = 0;
            bullet.Top = -100;
            bullet.Left = -100;
            enemyMove3 = 5;
            bad3.Stop();
        }
    }
}
