using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Quiz_Coursework.Classes
{
    public class dragDropQuestion
    {
        public string QuestionText { get; set; }
        public string[] Answers { get; set; }
        public string[] PicAns { get; set; }
        public int[] MatchAns { get; set; }

        public dragDropQuestion(string questionText, string[] answers, string[] picAns, int[] matchAns)
        {
            QuestionText = questionText;
            Answers = answers;
            PicAns = picAns;
            MatchAns = matchAns;
        }

        public string GetQuestionText()
        {
            return QuestionText;
        }

        public string[] GetPossibleAnswers()
        {
            return Answers;
        }

        public string[] GetPossiblePicAnswers()
        {
            return PicAns;
        }

        public int[] GetMatch()
        {
            return MatchAns;
        }
    }
}
