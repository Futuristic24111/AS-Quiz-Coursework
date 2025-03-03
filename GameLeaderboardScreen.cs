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
    public partial class GameLeaderboardScreen : Form
    {
        public GameLeaderboardScreen()
        {
            InitializeComponent();
            CenterToScreen();
            podiumSetUp();
            pictureBox1.SendToBack();
        }
        private void podiumSetUp()
        {
            string filePath = @"gamescores.txt";
            string[] lines = File.ReadAllLines(filePath);
            List<KeyValuePair<string, int>> userScores = new List<KeyValuePair<string, int>>();
            for (int i = 0; i < lines.Length; i += 2)
            {
                try
                {
                    string username = lines[i];
                    int score = Convert.ToInt32(lines[i + 1]);
                    userScores.Add(new KeyValuePair<string, int>(username, score));
                }
                catch
                {
                    i++;
                    string username = lines[i];
                    int score = Convert.ToInt32(lines[i + 1]);
                    userScores.Add(new KeyValuePair<string, int>(username, score));
                }
            }
            userScores = userScores.OrderByDescending(pair => pair.Value).ToList();
            firstLbl.Text = $"{userScores[0].Key}: {userScores[0].Value}";
            try
            {
                secondLbl.Text = $"{userScores[1].Key}: {userScores[1].Value}";
            }
            catch
            {
                secondLbl.Text = "-";
            }
            try
            {
                thirdLbl.Text = $"{userScores[2].Key}: {userScores[2].Value}";
            }
            catch
            {
                thirdLbl.Text = "-";
            }
            userScores.RemoveAt(0);
            try
            {
                userScores.RemoveAt(0);
            }
            catch { }
            try
            {
                userScores.RemoveAt(0);
            }
            catch { }
            foreach (var pair in userScores)
            {
                playerLstBox.Items.Add($"{pair.Key}: {pair.Value}");
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Question.click.controls.play();
            Hide();
            new GameEndScreen(GameEndScreen.Score).Show();
        }
    }
}
