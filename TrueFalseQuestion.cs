using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Coursework.Classes
{
    public class TrueFalseQuestion
    {
        public string QuestionText { get; set; }
        public bool Answer { get; set; }

        public TrueFalseQuestion(string questionText, bool answer)
        {
            QuestionText = questionText;
            Answer = answer;
        }
        public string GetQuestionText()
        {
            return QuestionText;
        }

        public bool trueOrFalse()
        {
            return Answer;
        }
    }
}
