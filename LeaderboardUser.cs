using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Coursework
{
    public class LeaderboardUser
    {
        public string Username { get; }
        public int TotalScore { get; }

        public LeaderboardUser(string username, int totalScore)
        {
            Username = username;
            TotalScore = totalScore;
        }
    }
}
