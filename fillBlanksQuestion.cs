using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Quiz_Coursework.Classes
{
    public class fillBlanksQuestion
    {
        public string QuestionText { get; set; }
        public string Answer { get; set; }

        public static string ans = string.Empty;

        public fillBlanksQuestion(string questionText, string answer)
        {
            QuestionText = questionText;
            Answer = answer;
        }
        public string GetQuestionText()
        {
            return QuestionText;
        }
        public string GetAnswerText()
        {
            return Answer;
        }

        public static bool ValidateAnswer()
        {
            List<string> validOtherAnswers = new List<string>();
            if (ans == "STRING")
            {
                validOtherAnswers.Add("STRINGS");
            }
            else if (ans == "TAB")
            {
                validOtherAnswers.Add("TABS");
            }
            else if (ans == "5")
            {
                validOtherAnswers.Add("FIVE");
                validOtherAnswers.Add("V");
            }
            else if (ans == "7")
            {
                validOtherAnswers.Add("SEVEN");
                validOtherAnswers.Add("VII");
            }
            if (validOtherAnswers.Contains(FillTheBlanksScreen.submittedAns.ToUpper()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
