using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Quiz_Coursework.Classes
{
    public class Player
    {
        public static string Username = string.Empty;
        public int Score;
        public static int HighScore = 0;

        public Player(string name)
        {
            Username = name;
            Score = 0;
        }
        public void ResetPlayer()
        {
            Username = "";
            Score = 0;
        }
        public void IncreaseScore()
        {
            Score++;
        }
        public static void playerHighScore()
        {
            string filePath = @"previousplayers.txt";
            string[] lines = File.ReadAllLines(filePath);
            int highScore = 0;
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i] == Username)
                {
                    if (Question.qz1)
                    {
                        highScore = Convert.ToInt32(lines[i + 1]);
                        break;
                    }
                    else if (Question.qz2)
                    {
                        highScore = Convert.ToInt32(lines[i + 2]);
                        break;
                    }
                }
            }
            HighScore = highScore;
        }
        public static void PlayerAvatar()
        {
            string[] users = File.ReadLines("Users.Txt").ToArray();
            string avatar = string.Empty;
            for (int i = 0; i < users.Length; i++)
            {
                string[] userData = users[i].Split('~');
                if (Username == userData[0])
                {
                    avatar = userData[2];
                    if (avatar == "av1")
                    {
                        Avatar.av1 = true;
                        Avatar.av2 = false;
                        Avatar.av3 = false;
                        Avatar.av4 = false;
                        Avatar.av5 = false;
                        Avatar.av6 = false;
                    }
                    else if (avatar == "av2")
                    {
                        Avatar.av1 = false;
                        Avatar.av2 = true;
                        Avatar.av3 = false;
                        Avatar.av4 = false;
                        Avatar.av5 = false;
                        Avatar.av6 = false;
                    }
                    else if (avatar == "av3")
                    {
                        Avatar.av1 = false;
                        Avatar.av2 = false;
                        Avatar.av3 = true;
                        Avatar.av4 = false;
                        Avatar.av5 = false;
                        Avatar.av6 = false;
                    }
                    else if (avatar == "av4")
                    {
                        Avatar.av1 = false;
                        Avatar.av2 = false;
                        Avatar.av3 = false;
                        Avatar.av4 = true;
                        Avatar.av5 = false;
                        Avatar.av6 = false;
                    }
                    else if (avatar == "av5")
                    {
                        Avatar.av1 = false;
                        Avatar.av2 = false;
                        Avatar.av3 = false;
                        Avatar.av4 = false;
                        Avatar.av5 = true;
                        Avatar.av6 = false;
                    }
                    else if (avatar == "av6")
                    {
                        Avatar.av1 = false;
                        Avatar.av2 = false;
                        Avatar.av3 = false;
                        Avatar.av4 = false;
                        Avatar.av5 = false;
                        Avatar.av6 = true;
                    }
                    break;
                }
            }
        }
    }
}
