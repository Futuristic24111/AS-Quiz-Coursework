using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quiz_Coursework.Classes;
using WMPLib;

namespace Quiz_Coursework
{
    public partial class TrueFalseScreen : Form
    {
        WindowsMediaPlayer sound = new WindowsMediaPlayer();
        WindowsMediaPlayer ding = new WindowsMediaPlayer();
        WindowsMediaPlayer wrong = new WindowsMediaPlayer();
        public TrueFalseScreen()
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

        private List<string> celebrations = new List<string>();

        private List<TrueFalseQuestion> questions = new List<TrueFalseQuestion>();
        private void SetupQuestionBank1()
        {
            questions.Add(new TrueFalseQuestion("The major arpeggio is made up \nfrom the 1st, 3rd and 5th of the \nmajor scale.", true));
            questions.Add(new TrueFalseQuestion("The dominant 7 chord is\nconstructed by flattening the\n3rd and 7th.", false));
            questions.Add(new TrueFalseQuestion("The blues scale changes two note\nfrom the minor pentatonic.", false));
            questions.Add(new TrueFalseQuestion("There are 4 8ths in a quarter note.", false));
            NextQuestion();
        }

        private void SetupQuestionBank2()
        {
            questions.Add(new TrueFalseQuestion("Legatto is notes that are played\n very short and jumpy.", false));
            questions.Add(new TrueFalseQuestion("Rests are used to signify a note\n being cut off or no note being played.", true));
            questions.Add(new TrueFalseQuestion("The high e string is the 1st string\n of the guitar.", true));
            questions.Add(new TrueFalseQuestion("The ability to read and play music\n without previous practice is called\n sightreading.", true));
            NextQuestion();
        }

        public bool answer = false;
        private Random random = new Random();
        int index = 0;
        private void NextQuestion()
        {
            Question.questNo = Question.questNo + 1;
            questionNoLbl.Text = "Question " + Question.questNo;
            if (Question.trueCount == 0)
            {
                int r = random.Next(questions.Count - 1);
                Question.firstGo = r;
                index = r;
            }
            else if (Question.trueCount == 1)
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
            answer = questions[index].trueOrFalse();
        }
        private void CheckAnswer(bool subAns)
        {
            if (subAns == answer)
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
                if (trueBtn == true)
                {
                    button1.BackColor = Color.Red;
                }
                else if (falseBtn == true)
                {
                    button2.BackColor = Color.Red;
                }
            }
            button6.Show();

            if (answer == true)
            {
                button1.BackColor = Color.Green;
            }
            else if (answer == false)
            {
                button2.BackColor = Color.Green;
            }
            button1.Enabled = false;
            button2.Enabled = false;
            falseBtn = false;
            trueBtn = false;
        }

        bool trueBtn = false;
        bool falseBtn = false;

        private void button1_Click(object sender, EventArgs e)
        {
            Question.click.controls.play();
            trueBtn = true;
            CheckAnswer(true);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Question.click.controls.play();
            falseBtn = true;
            CheckAnswer(false);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Question.click.controls.play();
            timer1.Stop();
            Hide();
            Question.trueCount++;
            if (Question.trueCount == 2)
            {
                Question.used.Add("truefalse");
                if (Question.used.Contains("mult"))
                {
                    if (Question.used.Contains("fill"))
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
                        new FillTheBlanksScreen().Show();
                    }
                }
                else
                {
                    new MultiChoiceScreen().Show();
                }
            }
            else
            {
                new TrueFalseScreen().Show();
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
        int count = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            Question.click.controls.play();
            button3.Text = "Show Menu";
            if (count == 0)
            {
                menuStrip1.Show();
                button3.Text = "Hide Menu";
                count++;
            }
            else if (count == 1)
            {
                menuStrip1.Hide();
                button3.Text = "Show Menu";
                count = 0;
            }
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