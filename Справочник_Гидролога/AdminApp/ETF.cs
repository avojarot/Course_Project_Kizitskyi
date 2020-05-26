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
{
    public partial class ETF : Form
    {
        public Test test;
        public ETF()
        {
            InitializeComponent();
            test = new Test();
            questionsBindingSource.DataSource = test;
        }
    
        public ETF(Test t):this()
        {   
            test = new Test(t);
            NameA1.Text = test.Name;
            questionsBindingSource.DataSource = test;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var item = CQL1.SelectedItem as Question;
            if (item == null)
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
        private void change()
        {
            var item = CQL1.SelectedItem as Question;
            if (item == null)
                return;
            int index = test.Questions.IndexOf(item);
            var editForm = new EditQueForm(item);
            editForm.ShowDialog();
            if (editForm.DialogResult == DialogResult.OK)
            {
                test.Questions[index] = new Question(editForm.question);
                questionsBindingSource.ResetBindings(false);
            }
        }
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            change();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var editForm = new EditQueForm();
            editForm.ShowDialog();
            if (editForm.DialogResult == DialogResult.OK)
            {  
               test.Questions.Add(new Question(editForm.question));
               questionsBindingSource.ResetBindings(false);
            }
        }

        private void CQL1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            change();
        }

        private void Save1_Click(object sender, EventArgs e)
        {
            test.Name = NameA1.Text;
        }

        private void ETF1_FormClosing(object sender, FormClosingEventArgs e)
        {
            EditArticleForm.chek(NameA1, e);
            bool res = test.Questions.Count == 0;
            if (res)
            {
                CQL1.BackColor = Color.LightPink;
                e.Cancel = true;
            }
            else
                CQL1.BackColor = Color.LightGreen;



        }

        private void search1ToolStripMenuItem_Click(object sender, EventArgs e)
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
