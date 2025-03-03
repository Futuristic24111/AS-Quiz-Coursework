using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using WMPLib;

namespace Quiz_Coursework.Classes
{
    public class Question
    {
        public static WindowsMediaPlayer click = new WindowsMediaPlayer();
        public string QuestionText { get; set; }
        public string[] Answers { get; set; }
        public int CorrectAnswerPosition { get; set; }

        public static int questNo = 0;

        public static int timerSeconds = 0;

        public static bool firsttime = true;

        public Question(string questionText, string[] answers, int correctAnswerPosition)
        {
            QuestionText = questionText;
            Answers = answers;
            CorrectAnswerPosition = correctAnswerPosition;
        }
        public string GetQuestionText()
        {
            return QuestionText;
        }
        public string[] GetPossibleAnswers()
        {
            return Answers;
        }
        public int GetAnswerPosition()
        {
            return CorrectAnswerPosition;
        }
        public static bool qz1 = false;
        public static bool qz2 = false;

        public static int multCount = 0;
        public static int fillCount = 0;
        public static int trueCount = 0;
        public static int dragCount = 0;

        public static List<string> used = new List<string>();

        public static int firstGo = 0;

        public static void clickSetUp()
        {
            click.URL = @"Click.mp3";
            click.controls.stop();
        }
        public static void whichQuestion()
        {
            Random random = new Random();
            int p = random.Next(3);

            switch (p)
            {
                case 0:
                    new MultiChoiceScreen().Show();
                    break;
                case 1:
                    new FillTheBlanksScreen().Show();
                    break;
                case 2:
                    new TrueFalseScreen().Show();
                    break;
                case 3:
                    new DragDropScreen().Show();
                    break;
            }
        }
    }
}
