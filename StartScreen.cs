using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quiz_Coursework.Classes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Quiz_Coursework
{
    public partial class StartScreen : Form
    {
        public StartScreen(string username)
        {
            InitializeComponent();
            CenterToScreen();
            Player = new Player(username);

            welcomeLbl.Text = "Welcome " + username;
            string objectDeSerialized = Serializer.DeserializePlayer();
            string[] parts = objectDeSerialized.Split(",");
            lastPlayerLbl.Text = "Last Player: " + parts[0] + " who scored " + parts[1] + "/8";
        }
        public static Player Player;
        private void button5_Click(object sender, EventArgs e)
        {
            Question.click.controls.play();
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Question.click.controls.play();
            static void DeclareWebPage()
            {
                string url = "https://www.learnandmaster.com/resources/Learn-and-Master-Guitar-Lesson-Book.pdf";

                OpenWebpage(url);
            }

            static void OpenWebpage(string url)
            {
                try
                {
                    Process.Start(new ProcessStartInfo
                    {
                        FileName = url,
                        UseShellExecute = true
                    });
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error opening webpage: {ex.Message}");
                }
            }
            DeclareWebPage();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Question.click.controls.play();
            static void DeclareWebPage()
            {
                string url = "https://www.thisisclassicalguitar.com/wp-content/uploads/2021/03/Classical-Guitar-Method-Vol1-2020.pdf";

                OpenWebpage(url);
            }

            static void OpenWebpage(string url)
            {
                try
                {
                    Process.Start(new ProcessStartInfo
                    {
                        FileName = url,
                        UseShellExecute = true
                    });
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error opening webpage: {ex.Message}");
                }
            }
            DeclareWebPage();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Question.click.controls.play();
            Hide();
            Question.qz1 = true;
            Question.whichQuestion();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Question.click.controls.play();
            Hide();
            Question.qz2 = true;
            Question.whichQuestion();
        }
    }
}
