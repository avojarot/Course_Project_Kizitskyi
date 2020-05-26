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
    public partial class TestSearchForm<T> : Form 
    {
        List<T> anSerched;
        public List<T> Searched;
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
            .IndexOf(textBox1.Text.ToLower()) > -1).ToList();
            else if (t is Question)
            Searched = anSerched.Where(x => ((Question)(Object)x).TextOfQuestion.ToLower()
            .IndexOf(textBox1.Text.ToLower()) > -1).ToList();
        }
    }
}
