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
{   //Форма для операций с вопросами
    public partial class EditQuestionForm : Form
        //Редактируемый вопрос
    {   public Question question;
        //Конструктор для создания вопроса
        public EditQuestionForm()
        {
            InitializeComponent();
            question = new Question();
            QuestionopionsBindingSource.DataSource = question;
            QuestionBindingSourceCbox.DataSource = question;
            
        }
        //Конструктор для редактирования вопроса
        public EditQuestionForm(Question q) :this()
        {
            question = new Question(q);
            MainBox.Text = question.TextOfQuestion;
            QuestionopionsBindingSource.DataSource = question;
            QuestionBindingSourceCbox.DataSource = question;
            RightCbox.Text = question.CorrectAnswer.Value;
        }

        private void NataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            QuestionBindingSourceCbox.ResetBindings(false);
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var indexOfNew = question.AnswerOptions.Count;
            question.AnswerOptions.Add(new QuestionOp(""));
            QuestionopionsBindingSource.ResetBindings(false);
            GridOptins.CurrentCell = GridOptins["Option", indexOfNew];
            GridOptins.BeginEdit(false);
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GridOptins.BeginEdit(false);
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(GridOptins.CurrentCell.Value is string item))
                return;
            var mess = MessageBox.Show($"Действительно удалить вариант {item} ? ",
                "Удаление", MessageBoxButtons.YesNo);
            if (DialogResult.Yes == mess)
            {    
                question.AnswerOptions.Remove(new QuestionOp(item));
                QuestionopionsBindingSource.ResetBindings(false);
                QuestionBindingSourceCbox.ResetBindings(false);
            }
        }

        private void EditQueForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.Cancel)
                return;
            EditArticleForm.Сhek(MainBox, e);
            EditArticleForm.Сhek(RightCbox, e);
            EditArticleForm.Сhek(QuestionPoints, e);
            if (question.AnswerOptions.Count == 0)
                e.Cancel = true;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            question.CorrectAnswer = new QuestionOp(RightCbox.Text);
            question.Points = (int)QuestionPoints.Value;
            question.TextOfQuestion = MainBox.Text;
        }
    }
}
