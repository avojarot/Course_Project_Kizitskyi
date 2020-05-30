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
{   //Класс для поиска статей по заданым параметрам
    public partial class SearchArticleForm : Form
    {
       readonly List<WaterObject> anSerched;
       //Коллекция в которой будет хранится результат поиска
       public List<WaterObject> Searched;
        //Инициализация формы
        public SearchArticleForm(List<WaterObject> water)
        {   
            InitializeComponent();
            anSerched = new List<WaterObject>(water);
        }

        private void Search_Click(object sender, EventArgs e)
        {
            decimal minD = (DepthMinNumber.Value > DepthMaxNumber.Value) ? DepthMaxNumber.Value 
                : DepthMinNumber.Value;
            decimal maxD = (DepthMinNumber.Value < DepthMaxNumber.Value) ? DepthMaxNumber.Value 
                : DepthMinNumber.Value;

            decimal minA = (AreaMinNumber.Value > AreaMaxNumber.Value) ? AreaMaxNumber.Value 
                : AreaMinNumber.Value;
            decimal maxA = (AreaMinNumber.Value < AreaMaxNumber.Value) ? AreaMaxNumber.Value 
                : AreaMinNumber.Value;

            Searched = anSerched.Where(c => c.Name.ToLower().IndexOf(NameBox.Text.ToLower()) > -1 && 
            c.Type.ToLower().IndexOf(TypeCbox.Text.ToLower()) > -1 
            && c.Region.ToLower().IndexOf(RegionCbox.Text.ToLower())> -1 && c.Depth>=minD &&
            c.Depth <= maxD && c.Area >= minA && c.Area<=maxA).ToList();

            this.Close();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
