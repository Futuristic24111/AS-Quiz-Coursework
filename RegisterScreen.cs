
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
using WMPLib;

namespace Quiz_Coursework
{
    public partial class RegisterScreen : Form
    {
        public RegisterScreen()
        {
            InitializeComponent();
            CenterToScreen();
            pictureBox7.BackgroundImage = Properties.Resources.Avatar2;
            pictureBox7.Show();
        }
        private int count = 0;
        private int countt = 0;
        string savedAvatar = string.Empty;

        private void createNewUserBtn_Click(object sender, EventArgs e)
        {
            Question.click.controls.play();
            string[] users = File.ReadLines(@"Users.Txt").ToArray();
            string filePath = @"Users.Txt";
            FileStream aFile;
            StreamWriter sw;

            try
            {

            }
            catch
            {
                MessageBox.Show("User failed to add", "Error Occurred");
            }
            if (!File.Exists(filePath))
            {
                aFile = new FileStream(filePath, FileMode.Create, FileAccess.Write);
            }
            else
            {
                aFile = new FileStream(filePath, FileMode.Append, FileAccess.Write);
            }
            sw = new StreamWriter(aFile);
            string userName = newUsernameTxtBox.Text;
            string password = newPasswordTxtBox.Text;
            string conPassword = conPasswordTxtBox.Text;




            if (!string.IsNullOrEmpty(userName) && !string.IsNullOrEmpty(password))
            {

            }
            else
            {
                MessageBox.Show("Username and Password must not be empty", "Username or password missing");
            }

            if (Avatar.av1 == true)
            {
                savedAvatar = "av1";
            }
            else if (Avatar.av2 == true)
            {
                savedAvatar = "av2";
            }
            else if (Avatar.av3 == true)
            {
                savedAvatar = "av3";
            }
            else if (Avatar.av4 == true)
            {
                savedAvatar = "av4";
            }
            else if (Avatar.av5 == true)
            {
                savedAvatar = "av5";
            }
            else if (Avatar.av6 == true)
            {
                savedAvatar = "av6";
            }

            if (label7.ForeColor == Color.Green && label8.ForeColor == Color.Green && label9.ForeColor == Color.Green)
            {

                bool found = false;
                for (int i = 0; i < users.Length; i++)
                {
                    string[] userData = users[i].Split('~');
                    if (userName == userData[0])
                    {
                        found = true;
                        break;
                    }
                }
                if (found == true)
                {
                    MessageBox.Show("Username already exists", "Please login or use a different Username");
                }
                else
                {
                    if (password == conPassword)
                    {
                        sw.WriteLine(userName + "~" + password + "~" + savedAvatar);

                        sw.Close();
                        aFile.Close();
                        AddToScores();

                        newUsernameTxtBox.Text = "";
                        newPasswordTxtBox.Text = "";
                        conPasswordTxtBox.Text = "";
                        Hide();
                        new Form1().Show();

                        MessageBox.Show("User has been added successfully.", "Successful");
                    }
                    else
                    {
                        MessageBox.Show("Passwords must match.", "Password and Confirm Password Error.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Password Invalid", "Password must meet all requirements");
            }
        }

        private int count2 = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            Question.click.controls.play();
            count2 = count2 + 1;
            if (count2 == 7)
            {
                count2 = 1;
            }
            if (count2 == 2)
            {
                pictureBox7.BackgroundImage = Properties.Resources.Avatar3;
                Avatar.av1 = false;
                Avatar.av2 = true;
                Avatar.av3 = false;
                Avatar.av4 = false;
                Avatar.av5 = false;
                Avatar.av6 = false;
            }
            else if (count2 == 3)
            {
                pictureBox7.BackgroundImage = Properties.Resources.Avatar4;
                Avatar.av1 = false;
                Avatar.av2 = false;
                Avatar.av3 = true;
                Avatar.av4 = false;
                Avatar.av5 = false;
                Avatar.av6 = false;
            }
            else if (count2 == 4)
            {
                pictureBox7.BackgroundImage = Properties.Resources.Avatar5;
                Avatar.av1 = false;
                Avatar.av2 = false;
                Avatar.av3 = false;
                Avatar.av4 = true;
                Avatar.av5 = false;
                Avatar.av6 = false;
            }
            else if (count2 == 5)
            {
                pictureBox7.BackgroundImage = Properties.Resources.Avatar6;
                Avatar.av1 = false;
                Avatar.av2 = false;
                Avatar.av3 = false;
                Avatar.av4 = false;
                Avatar.av5 = true;
                Avatar.av6 = false;
            }
            else if (count2 == 6)
            {
                pictureBox7.BackgroundImage = Properties.Resources.Avatar7;
                Avatar.av1 = false;
                Avatar.av2 = false;
                Avatar.av3 = false;
                Avatar.av4 = false;
                Avatar.av5 = false;
                Avatar.av6 = true;
            }
            else if (count2 == 1)
            {
                pictureBox7.BackgroundImage = Properties.Resources.Avatar2;
                Avatar.av1 = true;
                Avatar.av2 = false;
                Avatar.av3 = false;
                Avatar.av4 = false;
                Avatar.av5 = false;
                Avatar.av6 = false;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Question.click.controls.play();
            if (count2 == 0)
            {
                count2 = 6;
            }
            else
            {
                count2 = count2 - 1;
            }
            if (count2 == 2)
            {
                pictureBox7.BackgroundImage = Properties.Resources.Avatar3;
                Avatar.av1 = false;
                Avatar.av2 = true;
                Avatar.av3 = false;
                Avatar.av4 = false;
                Avatar.av5 = false;
                Avatar.av6 = false;
            }
            else if (count2 == 3)
            {
                pictureBox7.BackgroundImage = Properties.Resources.Avatar4;
                Avatar.av1 = false;
                Avatar.av2 = false;
                Avatar.av3 = true;
                Avatar.av4 = false;
                Avatar.av5 = false;
                Avatar.av6 = false;
            }
            else if (count2 == 4)
            {
                pictureBox7.BackgroundImage = Properties.Resources.Avatar5;
                Avatar.av1 = false;
                Avatar.av2 = false;
                Avatar.av3 = false;
                Avatar.av4 = true;
                Avatar.av5 = false;
                Avatar.av6 = false;
            }
            else if (count2 == 5)
            {
                pictureBox7.BackgroundImage = Properties.Resources.Avatar6;
                Avatar.av1 = false;
                Avatar.av2 = false;
                Avatar.av3 = false;
                Avatar.av4 = false;
                Avatar.av5 = true;
                Avatar.av6 = false;
            }
            else if (count2 == 6)
            {
                pictureBox7.BackgroundImage = Properties.Resources.Avatar7;
                Avatar.av1 = false;
                Avatar.av2 = false;
                Avatar.av3 = false;
                Avatar.av4 = false;
                Avatar.av5 = false;
                Avatar.av6 = true;
            }
            else if (count2 == 1)
            {
                pictureBox7.BackgroundImage = Properties.Resources.Avatar2;
                Avatar.av1 = true;
                Avatar.av2 = false;
                Avatar.av3 = false;
                Avatar.av4 = false;
                Avatar.av5 = false;
                Avatar.av6 = false;
            }
        }


        private void loginBtn_Click(object sender, EventArgs e)
        {
            Question.click.controls.play();

            Hide();
            new LoginScreen().Show();
        }

        private void textChange(object sender, EventArgs e)
        {
            if (newPasswordTxtBox.Text.Length >= 8)
            {
                label7.ForeColor = Color.Green;
            }
            else
            {
                label7.ForeColor = Color.Red;
            }
            bool hasSpecialCharacter = newPasswordTxtBox.Text.Any(c => !char.IsLetterOrDigit(c));
            if (hasSpecialCharacter)
            {
                label8.ForeColor = Color.Green;
            }
            else
            {
                label8.ForeColor = Color.Red;
            }
            bool hasNumber = newPasswordTxtBox.Text.Any(char.IsDigit);
            if (hasNumber)
            {
                label9.ForeColor = Color.Green;
            }
            else
            {
                label9.ForeColor = Color.Red;
            }
        }

        private void textChange2(object sender, EventArgs e)
        {   
            if (newPasswordTxtBox.Text == conPasswordTxtBox.Text)
            {
                label10.ForeColor = Color.Green;
            }
            else
            {
                label10.ForeColor = Color.Red;
            }
        }
        public void AddToScores()
        {
            int use = 0;
            string text = string.Empty;

            try
            {
                string filePath = @"previousplayers.txt";
                FileStream wFile;
                if (!File.Exists(filePath))
                {
                    use = 0;
                    wFile = new FileStream(filePath, FileMode.Create, FileAccess.Write);
                }
                else
                {
                    use = 1;
                    wFile = new FileStream(filePath, FileMode.Append, FileAccess.Write);
                }
                if (use == 0)
                {
                    text = newUsernameTxtBox.Text + "\n0\n0";
                }
                else if (use == 1)
                {
                    text = "\n" + newUsernameTxtBox.Text + "\n0\n0";
                }
                byte[] byteData;
                byteData = Encoding.ASCII.GetBytes(text);
                wFile.Write(byteData, 0, byteData.Length);
                wFile.Close();
            }
            catch
            {
                MessageBox.Show("User details not saved.", "Error occurred.");
            }
            int usee = 0;
            try
            {
                string fileName = @"gamescores.txt";
                FileStream rFile;
                if (!File.Exists(fileName))
                {
                    usee = 0;
                    rFile = new FileStream(fileName, FileMode.Create, FileAccess.Write);
                }
                else
                {
                    usee = 1;
                    rFile = new FileStream(fileName, FileMode.Append, FileAccess.Write);
                }
                if (usee == 0)
                {
                    text = newUsernameTxtBox.Text + "\n0";
                }
                else if (usee == 1)
                {
                    text = "\n" + newUsernameTxtBox.Text + "\n0";
                }
                byte[] byteData;
                byteData = Encoding.ASCII.GetBytes(text);
                rFile.Write(byteData, 0, byteData.Length);
                rFile.Close();
            }
            catch
            {
                MessageBox.Show("Users' game details not saved.", "Error occurred.");
            }
        }

        private void pressAndHold(object sender, MouseEventArgs e)
        {
            if (count == 0)
            {
                newPasswordTxtBox.UseSystemPasswordChar = false;
                count = count + 1;
                Question.click.controls.play();
            }
            else if (count == 1)
            {
                newPasswordTxtBox.UseSystemPasswordChar = true;
                count = 0;
            }
        }

        private void pressAndHold2(object sender, MouseEventArgs e)
        {
            if (countt == 0)
            {
                Question.click.controls.play();
                conPasswordTxtBox.UseSystemPasswordChar = false;
                countt = countt + 1;
            }
            else if (countt == 1)
            {
                conPasswordTxtBox.UseSystemPasswordChar = true;
                countt = 0;
            }
        }
    }
}
