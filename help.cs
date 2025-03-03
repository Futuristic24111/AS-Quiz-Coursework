using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Coursework
{
    public class help
    {
        private string Text;
        private string QuestType;

        public help (string text, string questType)
        {
            Text = text;
            QuestType = questType;
        }

        public string GetHelpLbl()
        {
            return Text;
        }

        public string GetQuestType()
        {
            return QuestType;
        }
    }
}
