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
    public partial class SearchForm1 : Form
    {
        List<WaterObject> anSerched;
       public List<WaterObject> Searched;
        public SearchForm1(List<WaterObject> water)
        {   
            InitializeComponent();
            anSerched = new List<WaterObject>();
            anSerched.AddRange(water);
        }

        private void Search_Click(object sender, EventArgs e)
        {
            decimal minD = (DepthMin.Value > DepthMax.Value) ? DepthMax.Value : DepthMin.Value;
            decimal maxD = (DepthMin.Value < DepthMax.Value) ? DepthMax.Value : DepthMin.Value;

            decimal minA = (AreaMin.Value > AreaMax.Value) ? AreaMax.Value : AreaMin.Value;
            decimal maxA = (AreaMin.Value < AreaMax.Value) ? AreaMax.Value : AreaMin.Value;

            Searched = anSerched.Where(c => c.Name.ToLower().IndexOf(NameA.Text.ToLower()) > -1 && 
            c.Type.ToLower().IndexOf(Type.Text.ToLower()) > -1 
            && c.Region.ToLower().IndexOf(Region.Text.ToLower())> -1 && c.Depth>=minD &&
            c.Depth <= maxD && c.Area >= minA && c.Area<=maxA).ToList();

            this.Close();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
