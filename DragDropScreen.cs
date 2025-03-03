using Microsoft.Win32;
using Quiz_Coursework.Classes;
using Quiz_Coursework.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Quiz_Coursework
{
    public partial class DragDropScreen : Form
    {
        WindowsMediaPlayer sound = new WindowsMediaPlayer();
        WindowsMediaPlayer ding = new WindowsMediaPlayer();
        WindowsMediaPlayer wrong = new WindowsMediaPlayer();
        public DragDropScreen()
        {
            InitializeComponent();
            screenSetUp();
            CenterToScreen();
            AllowDropping();
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
            timer2.Interval = 1000;
            timer3.Interval = 1000;
            timer4.Interval = 1000;
            menuStrip1.Hide();
            sound.URL = @"Foo Fightas.mp3";
            ding.URL = @"Ding.mp3";
            wrong.URL = @"Wrong.mp3";
            sound.controls.stop();
            ding.controls.stop();
            wrong.controls.stop();
        }
        private void SetupQuestionBank1()
        {
            if (Question.dragCount == 0)
            {
                ansPicBox1.Image = Properties.Resources.Crochet;
                ansPicBox2.Image = Properties.Resources.Semibreve;
                ansPicBox3.Image = Properties.Resources.Minim;
                ansLbl1.Text = "Semibreve";
                ansLbl2.Text = "Crochet";
                ansLbl3.Text = "Minim";
            }
            else if (Question.dragCount == 1)
            {
                ansPicBox1.Image = Properties.Resources.Slide;
                ansPicBox2.Image = Properties.Resources.Bend_Image;
                ansPicBox3.Image = Properties.Resources.Tie;
                ansLbl1.Text = "Bend";
                ansLbl2.Text = "Tie";
                ansLbl3.Text = "Slide";
            }
            NextQuestion();
        }
        private void SetupQuestionBank2()
        {
            if (Question.dragCount == 0)
            {
                ansPicBox1.Image = Properties.Resources.Neck;
                ansPicBox2.Image = Properties.Resources.Bridge;
                ansPicBox3.Image = Properties.Resources.TuningPegs;
                ansLbl1.Text = "TuningPegs";
                ansLbl2.Text = "Bridge";
                ansLbl3.Text = "Neck";
            }
            else if (Question.dragCount == 1)
            {
                ansPicBox1.Image = Properties.Resources.Pick;
                ansPicBox2.Image = Properties.Resources.WhammyBar;
                ansPicBox3.Image = Properties.Resources.Capo;
                ansLbl1.Text = "WhammyBar";
                ansLbl2.Text = "Capo";
                ansLbl3.Text = "Pick";
            }
            NextQuestion();
        }

        private void NextQuestion()
        {
            Question.questNo = Question.questNo + 1;
            questionNoLbl.Text = "Question " + Question.questNo;
            questionLbl.Text = "Match the term to the picture.";
        }

        private void CheckAnswer(string shownImage)
        {
            if (shownImage == "Tick")
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
            }
            button6.Show();
        }
        private void AllowDropping()
        {
            ansPicBox1.AllowDrop = true;
            ansPicBox2.AllowDrop = true;
            ansPicBox3.AllowDrop = true;
        }

        private Label currentLabel;

        private void LabelGrabbed(object sender, MouseEventArgs e)
        {
            currentLabel = (Label)sender;
            currentLabel.DoDragDrop(currentLabel.Text, DragDropEffects.Copy);
        }

        private void AllowDragDropCopy(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        public int corrCount = 0;
        public int doneCount = 0;

        private void picDragDrop(object sender, DragEventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            string result = (string)e.Data.GetData(DataFormats.Text);
            Debug.WriteLine(result);
            if (pictureBox == null)
            {
                return;
            }
            currentLabel.Hide();
            if (result == "Crochet")
            {
                corrCount++;
                ansPicBox1.Image = Properties.Resources.Tick;
            }
            else if (result == "Slide")
            {
                corrCount++;
                ansPicBox1.Image = Properties.Resources.Tick;
            }
            else if (result == "Neck")
            {
                corrCount++;
                ansPicBox1.Image = Properties.Resources.Tick;
            }
            else if (result == "Pick")
            {
                corrCount++;
                ansPicBox1.Image = Properties.Resources.Tick;
            }
            else
            {
                ansPicBox1.Image = Properties.Resources.X;
            }
            doneCount++;
            timer2.Start();
            if (doneCount == 3)
            {
                if (corrCount == 3)
                {
                    CheckAnswer("Tick");
                }
                else
                {
                    CheckAnswer("Cross");
                }
            }
        }
        private void pic2DragDrop(object sender, DragEventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            string result = (string)e.Data.GetData(DataFormats.Text);
            Debug.WriteLine(result);
            if (pictureBox == null)
            {
                return;
            }
            currentLabel.Hide();
            if (result == "Semibreve")
            {
                corrCount++;
                ansPicBox2.Image = Properties.Resources.Tick;
            }
            else if (result == "Bend")
            {
                corrCount++;
                ansPicBox2.Image = Properties.Resources.Tick;
            }
            else if (result == "Bridge")
            {
                corrCount++;
                ansPicBox2.Image = Properties.Resources.Tick;
            }
            else if (result == "WhammyBar")
            {
                corrCount++;
                ansPicBox2.Image = Properties.Resources.Tick;
            }
            else
            {
                ansPicBox2.Image = Properties.Resources.X;
            }
            doneCount++;
            timer3.Start();
            if (doneCount == 3)
            {
                if (corrCount == 3)
                {
                    CheckAnswer("Tick");
                }
                else
                {
                    CheckAnswer("Cross");
                }
            }
        }
        private void pic3DragDrop(object sender, DragEventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            string result = (string)e.Data.GetData(DataFormats.Text);
            Debug.WriteLine(result);
            if (pictureBox == null)
            {
                return;
            }
            currentLabel.Hide();
            if (result == "Minim")
            {
                corrCount++;
                ansPicBox3.Image = Properties.Resources.Tick;
            }
            else if (result == "Tie")
            {
                corrCount++;
                ansPicBox3.Image = Properties.Resources.Tick;
            }
            else if (result == "TuningPegs")
            {
                corrCount++;
                ansPicBox3.Image = Properties.Resources.Tick;
            }
            else if (result == "Capo")
            {
                corrCount++;
                ansPicBox3.Image = Properties.Resources.Tick;
            }
            else
            {
                ansPicBox3.Image = Properties.Resources.X;
            }
            doneCount++;
            timer4.Start();
            if (doneCount == 3)
            {
                if (corrCount == 3)
                {
                    CheckAnswer("Tick");
                }
                else
                {
                    CheckAnswer("Cross");
                }
            }
        }

        int count = 0;
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                playerStatsListBox.Show();
                count++;
            }
            else if (count == 1)
            {
                playerStatsListBox.Hide();
                count = 0;
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Question.click.controls.play();
            Application.Exit();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Question.click.controls.play();
            timer1.Stop();
            Hide();
            Question.dragCount++;
            if (Question.dragCount == 2)
            {
                Question.used.Add("dragdrop");
                if (Question.used.Contains("mult"))
                {
                    if (Question.used.Contains("fill"))
                    {
                        if (Question.used.Contains("truefalse"))
                        {
                            new Form1().Show();
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
            else
            {
                new DragDropScreen().Show();
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            Question.timerSeconds++;
            timerLbl.Text = "Timer: " + Question.timerSeconds;
        }

        private void FooFightas(object sender, EventArgs e)
        {
            sound.controls.play();
        }
        public int picBox1 = 0;
        public int picBox2 = 0;
        public int picBox3 = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            picBox1++;
            if (picBox1 == 1)
            {
                ansPicBox1.Hide();
                timer2.Stop();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            picBox2++;
            if (picBox2 == 1)
            {
                ansPicBox2.Hide();
                timer3.Stop();
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            picBox3++;
            if (picBox3 == 1)
            {
                ansPicBox3.Hide();
                timer4.Stop();
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
        int count1 = 0;
        private void button5_Click(object sender, EventArgs e)
        {
            Question.click.controls.play();
            button5.Text = "Show Menu";
            if (count1 == 0)
            {
                menuStrip1.Show();
                button5.Text = "Hide Menu";
                count1++;
            }
            else if (count1 == 1)
            {
                menuStrip1.Hide();
                button5.Text = "Show Menu";
                count1 = 0;
            }
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new HelpScreen().Show();
        }
    }
}
