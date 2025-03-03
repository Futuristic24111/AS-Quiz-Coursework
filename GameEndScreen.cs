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

namespace Quiz_Coursework
{
    public partial class GameEndScreen : Form
    {
        public static int Score = 0;
        public GameEndScreen(int score)
        {
            InitializeComponent();
            CenterToScreen();
            scoreLbl.Text = "You Scored: " + score;
            Score = score;
            UpdateScore();
        }
        public void UpdateScore()
        {
            string filePath = @"gamescores.txt";
            string[] users = File.ReadLines(filePath).ToArray();
            for (int i = 0; i < users.Count(); i++)
            {
                if (users[i] == Player.Username)
                {
                    int oldScore = Convert.ToInt32(users[i + 1]);
                    int newScore = Score;
                    if (newScore > oldScore)
                    {
                        OverwriteLine(filePath, i + 1, newScore.ToString());
                    }
                }
            }
        }
        private void OverwriteLine(string fileName, int lineToChange, string newScore)
        {
            try
            {
                string[] lines = File.ReadAllLines(fileName);
                if (lineToChange >= 0 && lineToChange < lines.Length)
                {
                    lines[lineToChange] = newScore;
                    File.WriteAllLines(fileName, lines);
                }
                else
                {
                    throw new ArgumentOutOfRangeException(nameof(lineToChange), "Invalid line number.");
                }
            }
            catch (Exception ex)
            {
                throw new IOException($"Error while overwriting line: {ex:Message}", ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Question.click.controls.play();
            Hide();
            new GameScreen().Show();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Question.click.controls.play();
            Hide();
            new EndScreen(false).Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Question.click.controls.play();
            Hide();
            new GameStartScreen(Player.Username).Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Question.click.controls.play();
            Hide();
            new GameLeaderboardScreen().Show();
        }
    }
}
