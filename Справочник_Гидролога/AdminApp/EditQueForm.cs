using Hydrologist.models;
using HydrologistGuideLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminApp
{
    public partial class EditQueForm : Form
    {   public Question question;
        public EditQueForm()
        {
            InitializeComponent();
            question = new Question();
            question.AnswerOptions.Add(new QuestionOp(""));
            answerOptionsBindingSource.DataSource = question;
            answerOptionsBindingSource1.DataSource = question;
            
        }
        public EditQueForm(Question q) :this()
        {
            question = new Question(q);
            MainText.Text = question.TextOfQuestion;
            right.Text = question.CorrectAnswer.Value;
            answerOptionsBindingSource.DataSource = question;
            answerOptionsBindingSource1.DataSource = question;
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            answerOptionsBindingSource1.ResetBindings(false);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var indexOfNew = question.AnswerOptions.Count;
            question.AnswerOptions.Add(new QuestionOp(""));
            answerOptionsBindingSource.ResetBindings(false);
            myData.CurrentCell = myData["Option", indexOfNew];
            myData.BeginEdit(false);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myData.BeginEdit(false);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var item = myData.CurrentCell.Value as string;
            if (item == null)
                return;
            var mess = MessageBox.Show($"Действительно удалить вариант {item} ? ",
                "Удаление", MessageBoxButtons.YesNo);
            if (DialogResult.Yes == mess)
            {    
                question.AnswerOptions.Remove(new QuestionOp(item));
                answerOptionsBindingSource.ResetBindings(false);
                answerOptionsBindingSource1.ResetBindings(false);
            }
        }

        private void EditQueForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.Cancel)
                return;
            EditArticleForm.chek(MainText, e);
            EditArticleForm.chek(right, e);
            EditArticleForm.chek(QPoints, e);
            if (question.AnswerOptions.Count == 0)
                e.Cancel = true;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            question.CorrectAnswer = new QuestionOp(right.Text);
            question.Points = (int)QPoints.Value;
            question.TextOfQuestion = MainText.Text;
        }
    }
}
