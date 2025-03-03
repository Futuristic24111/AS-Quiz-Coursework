using Quiz_Coursework.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using WMPLib;
using Microsoft.VisualBasic.ApplicationServices;

namespace Quiz_Coursework
{
    public partial class MultiChoiceScreen : Form
    {
        WindowsMediaPlayer sound = new WindowsMediaPlayer();
        WindowsMediaPlayer ding = new WindowsMediaPlayer();
        WindowsMediaPlayer wrong = new WindowsMediaPlayer();
        public MultiChoiceScreen()
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

        private List<Question> questions = new List<Question>();
        private void SetupQuestionBank1()
        {
            questions.Add(new Question("What is the major second of C?",
                new[] { "D", "E", "Db", "Bb" }, 0));
            questions.Add(new Question("Which chord is composed of 1, \n3 and 5 tones?",
                new[] { "Minor", "5", "Major", "Sus2" }, 2));
            questions.Add(new Question("What is the construction of the \nmajor blues scale?",
                new[] { "1, 2, b3, 3, 5, 6", "1, b3, 4, 5, b7", "1, 2, 3, 4, 5, 6, 7", "1, b3, 4, b5, 5, b7" }, 0));
            questions.Add(new Question("What notes are the strings on a \nguitar?",
                new[] { "E-F-A-B-C-E", "E-A-D-G-B-E", "E-G-F-B-A-E", "E-A-G-D-B-E" }, 1));
            NextQuestion();
        }
        private void SetupQuestionBank2()
        {
            questions.Add(new Question("What is it called when a line \nin guitar music turns zigzaggy?",
                new[] { "Bend", "Slide", "Hammer-On", "Vibrato" }, 3));
            questions.Add(new Question("What are the screws at the top of a\n guitar called used to\n tune the guitar?",
                new[] { "Bridges", "Tuning Pegs", "Tuning Screws", "Nuts" }, 1));
            questions.Add(new Question("What is it called when you pick the\n strings of your guitar in\n interchanging directions?",
                new[] { "Alternate Picking", "Directional Picking", "Silly Picking", " Changed Picking" }, 0));
            questions.Add(new Question("What does the 1/4 above a bend mean\n you should do?",
                new[] { "Bend but play it quietly", "Bend up to past a whole tone", "Play it 4 times", "Only bend slightly" }, 3));
            NextQuestion();
        }

        int ansPos = 0;

        private Random random = new Random();
        int index = 0;
        private void NextQuestion()
        {
            Question.questNo++;
            questionNoLbl.Text = "Question " + Question.questNo;
            if (Question.multCount == 0)
            {
                int r = random.Next(questions.Count - 1);
                Question.firstGo = r;
                index = r;
            }
            else if (Question.multCount == 1)
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
            string[] answers = questions[index].GetPossibleAnswers();
            int correctAnswerPos = questions[index].GetAnswerPosition();
            questionLbl.Text = questions[index].GetQuestionText();

            button1.Text = answers[0];
            button2.Text = answers[1];
            button3.Text = answers[2];
            button4.Text = answers[3];

            ansPos = correctAnswerPos;
        }

        private void CheckAnswer(int answer)
        {
            if (answer == ansPos)
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
                if (btn1 == true)
                {
                    button1.BackColor = Color.Red;
                }
                else if (btn2 == true)
                {
                    button2.BackColor = Color.Red;
                }
                else if (btn3 == true)
                {
                    button3.BackColor = Color.Red;
                }
                else if (btn4 == true)
                {
                    button4.BackColor = Color.Red;
                }

            }
            button6.Show();
            if (ansPos == 0)
            {
                button1.BackColor = Color.Green;
            }
            else if (ansPos == 1)
            {
                button2.BackColor = Color.Green;
            }
            else if (ansPos == 2)
            {
                button3.BackColor = Color.Green;
            }
            else if (ansPos == 3)
            {
                button4.BackColor = Color.Green;
            }
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            btn1 = false;
            btn2 = false;
            btn3 = false;
            btn4 = false;
        }

        public static bool btn1 = false;
        public static bool btn2 = false;
        public static bool btn3 = false;
        public static bool btn4 = false;

        public void button1_Click(object sender, EventArgs e)
        {
            Question.click.controls.play();
            btn1 = true;
            CheckAnswer(0);
        }

        public void button2_Click(object sender, EventArgs e)
        {
            Question.click.controls.play();
            btn2 = true;
            CheckAnswer(1);
        }

        public void button3_Click(object sender, EventArgs e)
        {
            Question.click.controls.play();
            btn3 = true;
            CheckAnswer(2);
        }

        public void button4_Click(object sender, EventArgs e)
        {
            Question.click.controls.play();
            btn4 = true;
            CheckAnswer(3);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Question.click.controls.play();
            timer1.Stop();
            Hide();
            Question.multCount++;
            if (Question.multCount == 2)
            {
                Question.used.Add("mult");
                if (Question.used.Contains("fill"))
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
                    new FillTheBlanksScreen().Show();
                }
            }
            else
            {
                new MultiChoiceScreen().Show();
            }
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

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new HelpScreen().Show();
        }
    }
}
