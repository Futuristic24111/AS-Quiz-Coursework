using Quiz_Coursework.Classes;

namespace Quiz_Coursework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CenterToScreen();
            timer1.Start();
            label1.Hide();
            timer2.Interval = 1000;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(5);
            loadingLbl.Text = "Loading " + progressBar1.Value + "%";
            if (progressBar1.Value >= progressBar1.Maximum)
            {
                timer1.Stop();
                if (Question.qz1 == true || Question.qz2 == true)
                {
                    Hide();
                    new EndScreen(true).Show();
                }
                else if (Question.firsttime == true)
                {
                    label1.Show();
                    timer2.Start();
                }
                else
                {
                    Hide();
                    new LoginScreen().Show();
                }
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            Input();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Input();
        }
        private void Input()
        {
            if (progressBar1.Value >= progressBar1.Maximum)
            {
                Question.firsttime = false;
                Hide();
                new LoginScreen().Show();
            }
        }
        int tickCount = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            tickCount++;
            if (tickCount == 1)
            {
                label1.Show();
            }
            else if(tickCount == 2)
            {
                label1.Hide();
                tickCount = 0;
            }
        }
    }
}