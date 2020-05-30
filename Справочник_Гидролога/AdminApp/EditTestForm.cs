using Hydrologist.models;
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
{   //Форма для редактирования содержимого тестов
    // и создандания новых
    public partial class EditTestForm : Form
    {   //Редактируемый объект
        public Test test;
        //Коструктор для создания 
        public EditTestForm()
        {
            InitializeComponent();
            test = new Test();
            questionsBindingSource.DataSource = test;
        }
        //Конструктор для редактирования
        public EditTestForm(Test t):this()
        {   
            test = new Test(t);
            NameBox.Text = test.Name;
            questionsBindingSource.DataSource = test;
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(OptionList.SelectedItem is Question item))
                return;
            var mess = MessageBox.Show($"Действительно удалить тест {item.TextOfQuestion} ? ",
                "Удаление", MessageBoxButtons.YesNo);
            if (DialogResult.Yes == mess)
            {
                if (questionsBindingSource.DataSource != test)
                    ((List<Question>)questionsBindingSource.DataSource).Remove(item);
                test.Questions.Remove(item);
                questionsBindingSource.ResetBindings(false);
            }
        }
        private void Change()
        {
            if (!(OptionList.SelectedItem is Question item))
                return;
            int index = test.Questions.IndexOf(item);
            var editForm = new EditQuestionForm(item);
            editForm.ShowDialog();
            if (editForm.DialogResult == DialogResult.OK)
            {
                test.Questions[index] = new Question(editForm.question);
                questionsBindingSource.ResetBindings(false);
            }
        }
        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Change();
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var editForm = new EditQuestionForm();
            editForm.ShowDialog();
            if (editForm.DialogResult == DialogResult.OK)
            {  
               test.Questions.Add(new Question(editForm.question));
               questionsBindingSource.ResetBindings(false);
            }
        }

        private void CQL1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Change();
        }

        private void Save1_Click(object sender, EventArgs e)
        {
            test.Name = NameBox.Text;
        }

        private void ETF1_FormClosing(object sender, FormClosingEventArgs e)
        {
            EditArticleForm.Сhek(NameBox, e);
            bool res = test.Questions.Count == 0;
            if (res)
            {
                OptionList.BackColor = Color.LightPink;
                e.Cancel = true;
            }
            else
                OptionList.BackColor = Color.LightGreen;



        }

        private void Search1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var search = new TestSearchForm<Question>(test.Questions);
            search.ShowDialog();
            if (search.DialogResult == DialogResult.Yes)
            {
                questionsBindingSource.DataSource = search.Searched;
                if (search.Searched.Count == 0)
                    MessageBox.Show("К сожалению, ничего не найденo...", "Ошибка");
            }
            else if (search.DialogResult == DialogResult.No)
                questionsBindingSource.DataSource = test.Questions;

            questionsBindingSource.ResetBindings(false);
        }
    }
}
