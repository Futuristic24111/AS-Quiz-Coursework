using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Coursework
{
    public class InvalidAnswerException : Exception
    {
        //private static string errorMessage = "Invalid answer: {0}.";
        public InvalidAnswerException(string ans) : base(string.Format(ans))
        {
            MessageBox.Show("Correct Answer: " + FillTheBlanksScreen.answer.ToLower(), "Invalid answer: " + ans);
        }
    }
}
