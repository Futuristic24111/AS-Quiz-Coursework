using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_Coursework
{
    public partial class HelpScreen : Form
    {
        public HelpScreen()
        {
            InitializeComponent();
            CenterToScreen();
            helpSetUp();
        }

        List<help> tutorials = new List<help>();
        private void helpSetUp()
        {
            tutorials.Add(new help("The Multi-Choice Question is a question\ntype that has 4 buttons and\na question, it's your\n" +
                "job to select the appropriate button to\nthe corresponding question.", "Multi - Choice Question"));
            tutorials.Add(new help("The Fill-The-Blanks Question is a question\ntype with a term and a word missing.\nIt's your job to fill " +
                "in this word\nby typing it in the text box\nprovided.", "Fill-The-Blanks Question"));
            tutorials.Add(new help("The True-False Question is a button\nprompted question type with a statement\nthat is either true or false, it" +
                " is your\n job to figure out if the statement\nis true or not then press the\ncorresponding button.", "True - False Question"));
            tutorials.Add(new help("The Drag - Drop Question is a question\ntype with three pictures and three\ndefinitions, it is your job to " +
                "drag the\ndefinition to the corresponding picture.", "Drag - Drop Question"));
            tutLbl.Text = tutorials[0].GetHelpLbl();
            typeLbl.Text = tutorials[0].GetQuestType();
            MultBtn.Enabled = false;
        }

        private void MultBtn_Click(object sender, EventArgs e)
        {
            FillBtn.Enabled = true;
            TrueBtn.Enabled = true;
            DragBtn.Enabled = true;
            MultBtn.Enabled = false;

            tutLbl.Text = tutorials[0].GetHelpLbl();
            typeLbl.Text = tutorials[0].GetQuestType();
        }

        private void FillBtn_Click(object sender, EventArgs e)
        {
            FillBtn.Enabled = false;
            TrueBtn.Enabled = true;
            DragBtn.Enabled = true;
            MultBtn.Enabled = true;

            tutLbl.Text = tutorials[1].GetHelpLbl();
            typeLbl.Text = tutorials[1].GetQuestType();
        }

        private void TrueBtn_Click(object sender, EventArgs e)
        {
            FillBtn.Enabled = true;
            TrueBtn.Enabled = false;
            DragBtn.Enabled = true;
            MultBtn.Enabled = true;

            tutLbl.Text = tutorials[2].GetHelpLbl();
            typeLbl.Text = tutorials[2].GetQuestType();
        }

        private void DragBtn_Click(object sender, EventArgs e)
        {
            FillBtn.Enabled = true;
            TrueBtn.Enabled = true;
            DragBtn.Enabled = false;
            MultBtn.Enabled = true;

            tutLbl.Text = tutorials[3].GetHelpLbl();
            typeLbl.Text = tutorials[3].GetQuestType();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
