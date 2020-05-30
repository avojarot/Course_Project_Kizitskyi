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
{   // Форма для прохождения теста
    public partial class TestingForm : Form
    {
        readonly Test test;
        readonly User Current;
        int points;
        bool flagEnd;
        int currentQestion;
        //Создание формы и запуск тестирования
        public TestingForm(Test t, User user)
        {
            InitializeComponent();
            test = new Test(t);
            Current = user;
            test.Ramdomize();
            QuestionBox.Text = test.Questions[currentQestion].TextOfQuestion;
            answerOptionsBindingSource.DataSource = test.Questions[currentQestion];

        }

     
        private void NextQestion()
        {
            currentQestion++;
            if (flagEnd || currentQestion >= test.Questions.Count)
            {
                Current.TotalMark += points;
                MessageBox.Show($"Вы завершили тест. Bаша оценка {points} из {test.MaxMark}. " +
                    $"Очков за всё время {Current.TotalMark}", 
                    "Результаты");
                this.Close();
                return;
            }
            QuestionBox.Text = test.Questions[currentQestion].TextOfQuestion;
            answerOptionsBindingSource.DataSource = test.Questions[currentQestion];
            answerOptionsBindingSource.ResetBindings(false);

        }
        public bool IsTrue(QuestionOp op)
        {
            return test.Questions[currentQestion].CorrectAnswer.Equals(op);
        }

        private void ListBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (!(OptionsLIst.SelectedItem is QuestionOp item))
                return;
            if (IsTrue(item))
            {
                points += test.Questions[currentQestion].Points;
            }
            NextQestion();
        }

        private void NEXT_Click(object sender, EventArgs e)
        {
            NextQestion();
        }

        private void END_Click(object sender, EventArgs e)
        {
            flagEnd = true;
            NextQestion();
        }

        
    }
}
