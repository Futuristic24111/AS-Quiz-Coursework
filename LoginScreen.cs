using Quiz_Coursework.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Quiz_Coursework
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
            CenterToScreen();
            Question.clickSetUp();
        }

        private int count = 0;

        private void registerBtn_Click(object sender, EventArgs e)
        {
            Question.click.controls.play();
            Hide();
            new RegisterScreen().Show();
        }

        public static string Username = string.Empty;
        public static string Password = string.Empty;

        private void loginBtn_Click(object sender, EventArgs e)
        {
            Question.click.controls.play();
            string userName = usernameTxtBox.Text;
            string password = passwordTxtBox.Text;
            if (!string.IsNullOrEmpty(userName) && !string.IsNullOrEmpty(password))
            {
                if (File.Exists(@"Users.Txt"))
                {
                    string[] users = File.ReadLines(@"Users.Txt").ToArray();
                    bool userFound = false;
                    for (int i = 0; i < users.Length; i++)
                    {
                        string[] userNameAndPassword = users[i].Split('~');
                        if (userName == userNameAndPassword[0] && password == userNameAndPassword[1])
                        {
                            userFound = true;
                            Username = userNameAndPassword[0];
                            Password = userNameAndPassword[1];
                            break;
                        }
                    }
                    if (userFound == true)
                    {
                        Hide();
                        new StartScreen(userName).Show();
                    }
                    else
                    {
                        MessageBox.Show("Details not found.", "Please register an account.");
                    }
                }
                else
                {
                    MessageBox.Show("No Users have been registered", "No Users found");
                }
            }
            else
            {
                MessageBox.Show("Username and password must not be empty", "Username or password missing");
            }
        }

        private void pressAndHold(object sender, MouseEventArgs e)
        {
            if (count == 0)
            {
                Question.click.controls.play();
                passwordTxtBox.UseSystemPasswordChar = false;
                count = count + 1;
            }
            else if (count == 1)
            {
                passwordTxtBox.UseSystemPasswordChar = true;
                count = 0;
            }
        }
    }
}