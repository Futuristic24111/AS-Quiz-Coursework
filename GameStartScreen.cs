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
    public partial class GameStartScreen : Form
    {
        public GameStartScreen(string username)
        {
            InitializeComponent();
            CenterToScreen();
            WelcomeLbl.Text = "Hello " + username + ", and welcome to Jet Wars!!!";
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            Question.click.controls.play();
            Hide();
            new EndScreen(false).Show();
        }

        private void playBtn_Click(object sender, EventArgs e)
        {
            Question.click.controls.play();
            Hide();
            new GameScreen().Show();
        }

        private void LeaderboardBtn_Click(object sender, EventArgs e)
        {
            new GameLeaderboardScreen().Show();
        }
    }
}
