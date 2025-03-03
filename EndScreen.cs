using Quiz_Coursework.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Quiz_Coursework
{
    public partial class EndScreen : Form
    {
        public EndScreen(bool saveFiles)
        {
            InitializeComponent();
            CenterToScreen();
            setUp();
            if (saveFiles)
            {
                SaveLastScore();
                if (Question.qz1 == true)
                {
                    UpdateScore1();
                }
                else if (Question.qz2 == true)
                {
                    UpdateScore2();
                }
            }
        }

        private void setUp()
        {
            gameWarning.Hide();
            scoreLbl.Text = "You Scored: " + StartScreen.Player.Score;
            timerLbl.Text = "Time taken: " + Question.timerSeconds + " seconds";
        }
        private void quitBtn_Click(object sender, EventArgs e)
        {
            Question.click.controls.play();
            StartScreen.Player.ResetPlayer();
            Question.qz1 = false;
            Question.qz2 = false;
            System.Windows.Forms.Application.Exit();
        }

        private void restartBtn_Click(object sender, EventArgs e)
        {
            Question.click.controls.play();
            StartScreen.Player.ResetPlayer();
            Hide();
            Question.qz1 = false;
            Question.qz2 = false;
            Question.multCount = 0;
            Question.fillCount = 0;
            Question.trueCount = 0;
            Question.dragCount = 0;
            Question.questNo = 0;
            Question.used.Clear();
            Question.timerSeconds = 0;
            new StartScreen(LoginScreen.Username).Show();
        }

        bool CanGame = false;
        public void GameTime()
        {
            string filePath = @"previousplayers.txt";
            if (Question.qz1 == true)
            {
                int score1 = StartScreen.Player.Score;
                int score2 = 0;
                string[] users = File.ReadLines(filePath).ToArray();
                for (int i = 0; i < users.Count(); i++)
                {
                    if (users[i] == Player.Username)
                    {
                        string[] arrLine = File.ReadAllLines(filePath);
                        score2 = Convert.ToInt32(arrLine[i + 2]);
                    }
                }
                int totalScore = score2 + score1;
                if (totalScore >= 10)
                {
                    CanGame = true;
                }
                else { CanGame = false; }
            }
            else if (Question.qz2 == true)
            {
                int score1 = 0;
                int score2 = StartScreen.Player.Score;
                for (int i = 0; i < File.ReadLines(filePath).Count(); i++)
                {
                    if (File.ReadLines(filePath).Skip(i).Take(5).First() == Player.Username)
                    {
                        string[] arrLine = File.ReadAllLines(filePath);
                        score1 = Convert.ToInt32(arrLine[i + 1]);
                    }
                }
                int totalScore = score2 + score1;
                if (totalScore >= 10)
                {
                    CanGame = true;
                }
                else { CanGame = false; }
            }
        }
        private void gameBtn_Click(object sender, EventArgs e)
        {
            Question.click.controls.play();
            GameTime();
            if (CanGame == false)
            {
                MessageBox.Show("You must Score a total of 10 out of 16 for the 2 quizzes to unlock this game.", "Game cannot be played yet.");
                gameBtn.Enabled = false;
                gameBtn.BackColor = Color.Gray;
            }
            else
            {
                Hide();
                new GameStartScreen(Player.Username).Show();
            }
        }
        private void SaveLastScore()
        {
            Serializer.SerializePlayer();
        }
        private void leaderboardBtn_Click(object sender, EventArgs e)
        {
            Question.click.controls.play();
            new LeaderboardScreen().Show();
        }
        public void UpdateScore1()
        {
            string filePath = @"previousplayers.txt";
            string[] users = File.ReadLines(filePath).ToArray();
            for (int i = 0; i < users.Count(); i++)
            {
                if (users[i] == Player.Username)
                {
                    int oldScore = Convert.ToInt32(users[i + 1]);
                    int newScore = StartScreen.Player.Score;
                    if (newScore > oldScore)
                    {
                        OverwriteLine(filePath, i + 1, StartScreen.Player.Score.ToString());
                    }
                }
            }
        }
        public void UpdateScore2()
        {
            string filePath = @"previousplayers.txt";
            string[] users = File.ReadLines(filePath).ToArray();
            for (int i = 0; i < users.Count(); i++)
            {
                if (users[i] == Player.Username)
                {
                    int oldScore = Convert.ToInt32(users[i + 2]);
                    int newScore = StartScreen.Player.Score;
                    if (newScore > oldScore)
                    {
                        OverwriteLine(filePath, i + 2, StartScreen.Player.Score.ToString());
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
    }
}
