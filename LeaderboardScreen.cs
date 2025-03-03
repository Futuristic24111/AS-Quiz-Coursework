using Microsoft.VisualBasic.ApplicationServices;
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
using static System.Formats.Asn1.AsnWriter;

namespace Quiz_Coursework
{
    public partial class LeaderboardScreen : Form
    {
        public LeaderboardScreen()
        {
            InitializeComponent();
            CenterToScreen();
            podiumSetUp();
            pictureBox1.SendToBack();
        }


        private void podiumSetUp()
        {
            string filePath = @"previousplayers.txt";
            string[] lines = File.ReadAllLines(filePath);
            List<KeyValuePair<string, int>> userScores = new List<KeyValuePair<string, int>>();
            for (int i = 0; i < lines.Length; i += 3)
            {
                try
                {
                    string username = lines[i];
                    int score1 = Convert.ToInt32(lines[i + 1]);
                    int score2 = Convert.ToInt32(lines[i + 2]);
                    int totalScore = score1 + score2;
                    userScores.Add(new KeyValuePair<string, int>(username, totalScore));
                }
                catch
                {
                    i++;
                    string username = lines[i];
                    int score1 = Convert.ToInt32(lines[i + 1]);
                    int score2 = Convert.ToInt32(lines[i + 2]);
                    int totalScore = score1 + score2;
                    userScores.Add(new KeyValuePair<string, int>(username, totalScore));
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
            new EndScreen(false).Show();
        }
    }
}
