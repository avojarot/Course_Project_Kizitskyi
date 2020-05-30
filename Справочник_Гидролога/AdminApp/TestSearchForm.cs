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
{   //Форма для поиска тестов и вопросов
    public partial class TestSearchForm<T> : Form 
    {
       readonly List<T> anSerched;
        //офильтрованая колекция
        public List<T> Searched;
        //Создание формы
        public TestSearchForm(List<T> list)
        {
            InitializeComponent();
            anSerched = list;
        }

        private void Search_Click(object sender, EventArgs e)
        {   if (anSerched.Count == 0)
                return;
            T t = anSerched[0];
            if(t is Test)
            Searched = anSerched.Where(x => ((Test)(Object)x).Name.ToLower()
            .IndexOf(NameBox.Text.ToLower()) > -1).ToList();
            else if (t is Question)
            Searched = anSerched.Where(x => ((Question)(Object)x).TextOfQuestion.ToLower()
            .IndexOf(NameBox.Text.ToLower()) > -1).ToList();
        }
    }
}
