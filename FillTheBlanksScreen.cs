using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using Quiz_Coursework.Classes;
using WMPLib;

namespace Quiz_Coursework
{
    public partial class FillTheBlanksScreen : Form
    {
        WindowsMediaPlayer sound = new WindowsMediaPlayer();
        WindowsMediaPlayer ding = new WindowsMediaPlayer();
        WindowsMediaPlayer wrong = new WindowsMediaPlayer();
        public FillTheBlanksScreen()
        {
            InitializeComponent();
            screenSetUp();
            CenterToScreen();
            if (Question.qz1 == true)
            {
                SetupQuestionBank1();
            }
            else if (Question.qz2 == true)
            {
                SetupQuestionBank2();
            }
            Player.PlayerAvatar();
            displayAvatar();
        }
        public void displayAvatar()
        {
            if (Avatar.av1 == true)
            {
                pictureBox8.Image = Properties.Resources.Avatar2;
            }
            else if (Avatar.av2 == true)
            {
                pictureBox8.Image = Properties.Resources.Avatar3;
            }
            else if (Avatar.av3 == true)
            {
                pictureBox8.Image = Properties.Resources.Avatar4;
            }
            else if (Avatar.av4 == true)
            {
                pictureBox8.Image = Properties.Resources.Avatar5;
            }
            else if (Avatar.av5 == true)
            {
                pictureBox8.Image = Properties.Resources.Avatar6;
            }
            else if (Avatar.av6 == true)
            {
                pictureBox8.Image = Properties.Resources.Avatar7;
            }
        }
        public void screenSetUp()
        {
            timer1.Start();
            playerLbl.Text = Player.Username;
            playerStatsListBox.Items.Add(string.Format("Score: " + StartScreen.Player.Score));
            Player.playerHighScore();
            playerStatsListBox.Items.Add(string.Format("High Score: " + Player.HighScore));
            button6.Hide();
            playerStatsListBox.Hide();
            timer1.Interval = 1000;
            menuStrip1.Hide();
            sound.URL = @"Foo Fightas.mp3";
            ding.URL = @"Ding.mp3";
            wrong.URL = @"Wrong.mp3";
            sound.controls.stop();
            ding.controls.stop();
            wrong.controls.stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Question.timerSeconds++;
            timerLbl.Text = "Timer: " + Question.timerSeconds;
        }

        private List<fillBlanksQuestion> questions = new List<fillBlanksQuestion>();
        private void SetupQuestionBank1()
        {
            questions.Add(new fillBlanksQuestion("The guitar is a part of the \n_______ instrument family.", "STRING"));
            questions.Add(new fillBlanksQuestion("Guitar sheet music is called \n_________.", "TAB"));
            questions.Add(new fillBlanksQuestion("There are _______ notes in the \npentatonic scale.", "5"));
            questions.Add(new fillBlanksQuestion("The dominant 7 chord is made by \nflattening the _____", "7"));
            NextQuestion();
        }

        private void SetupQuestionBank2()
        {
            questions.Add(new fillBlanksQuestion("The slanted line between 2 \nnotes signifies a __________.", "SLIDE"));
            questions.Add(new fillBlanksQuestion("A dot above a note means it \nis _________.", "STACCATO"));
            questions.Add(new fillBlanksQuestion("A _______ is signified by notes \nplayed at the same time.", "CHORD"));
            questions.Add(new fillBlanksQuestion("Standard guitar tuning is _________ \n(answer example: ABCDEF).", "EADGBE"));
            NextQuestion();
        }

        public static string answer = string.Empty;
        private Random random = new Random();
        int index = 0;
        private void NextQuestion()
        {
            Question.questNo = Question.questNo + 1;
            questionNoLbl.Text = "Question " + Question.questNo;
            if (Question.fillCount == 0)
            {
                int r = random.Next(questions.Count - 1);
                Question.firstGo = r;
                index = r;
            }
            else if (Question.fillCount == 1)
            {
                switch (Question.firstGo)
                {
                    case 0:
                        index = 1;
                        break;
                    case 1:
                        index = 0;
                        break;
                    case 2:
                        index = 3;
                        break;
                    case 3:
                        index = 2;
                        break;
                }

            }
            questionLbl.Text = questions[index].GetQuestionText();
            answer = questions[index].GetAnswerText();
            fillBlanksQuestion.ans = answer;
        }

        public static string submittedAns = string.Empty;

        private void CheckAnswer(string subAns)
        {
            textBox1.Enabled = false;
            submitBtn.Enabled = false;
            bool valid = fillBlanksQuestion.ValidateAnswer();
            if (subAns == answer || valid == true)
            {
                StartScreen.Player.IncreaseScore();
                playerStatsListBox.Items.Clear();
                playerStatsListBox.Items.Add(string.Format("Score: " + StartScreen.Player.Score));
                playerStatsListBox.Items.Add(string.Format("High Score: " + Player.HighScore));
                ding.controls.play();
            }
            else
            {
                wrong.controls.play();
                new InvalidAnswerException(submittedAns);
            }
            button6.Show();
        }
        private void submitBtn_Click(object sender, EventArgs e)
        {
            Question.click.controls.play();
            submittedAns = textBox1.Text;
            submittedAns = submittedAns.ToUpper();
            CheckAnswer(submittedAns);
        }

        int count1 = 0;
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (count1 == 0)
            {
                playerStatsListBox.Show();
                count1++;
            }
            else if (count1 == 1)
            {
                playerStatsListBox.Hide();
                count1 = 0;
            }

        }
        int count = 0;
        private void button5_Click(object sender, EventArgs e)
        {
            Question.click.controls.play();
            button5.Text = "Show Menu";
            if (count == 0)
            {
                menuStrip1.Show();
                button5.Text = "Hide Menu";
                count++;
            }
            else if (count == 1)
            {
                menuStrip1.Hide();
                button5.Text = "Show Menu";
                count = 0;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Question.click.controls.play();
            timer1.Stop();
            Hide();
            Question.fillCount++;
            if (Question.fillCount == 2)
            {
                Question.used.Add("fill");
                if (Question.used.Contains("mult"))
                {
                    if (Question.used.Contains("truefalse"))
                    {
                        if (Question.used.Contains("dragdrop"))
                        {
                            new Form1().Show();
                        }
                        else
                        {
                            new DragDropScreen().Show();
                        }
                    }
                    else
                    {
                        new TrueFalseScreen().Show();
                    }
                }
                else
                {
                    new MultiChoiceScreen().Show();
                }
            }
            else
            {
                new FillTheBlanksScreen().Show();
            }
        }

        private void FooFightas(object sender, EventArgs e)
        {
            sound.controls.play();
        }

        private void backToMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Question.click.controls.play();
            string user = Player.Username;
            DialogResult dr = MessageBox.Show("Are you sure you want to return to the menu?", "", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    Hide();
                    StartScreen.Player.ResetPlayer();
                    new StartScreen(user).Show();
                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void backToLoginScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Question.click.controls.play();
            DialogResult dr = MessageBox.Show("Are you sure you want to log out?", "", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    Hide();
                    StartScreen.Player.ResetPlayer();
                    new LoginScreen().Show();
                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new HelpScreen().Show();
        }
    }
}
