using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hydrologist.models;

namespace AdminApp
{
    public partial class ArticleForm : Form
    {
        public WaterObject obj { get; set; }
        public ArticleForm()
        {
            InitializeComponent();
        }
        public ArticleForm(WaterObject o2) : this()
        {
            obj = new WaterObject(o2);
            Editional.Text = obj.EditionalData;
            Area.Value = obj.Area;
            pictureBox1.Image = obj.Image;
            NameA.Text = obj.Name;
            Region.Text = obj.Region;
            Regime.Text = obj.Regime;
            Type.Text = obj.Type;

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        { var dial = new OpenFileDialog();
            if (dial.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(dial.FileName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(obj == null)
            {
                obj = new WaterObject();
            }
            obj.EditionalData = Editional.Text;
            obj.Area = Area.Value;
            obj.Image = (Bitmap)pictureBox1.Image;
            obj.Name = NameA.Text;
            obj.Region = Region.Text;
            obj.Regime = Regime.Text;
            obj.Type = Type.Text;
        }


        private bool chek(Control c, FormClosingEventArgs e)
        {
            bool res = string.IsNullOrWhiteSpace(c.Text);
            if (res)
            {
                c.BackColor = Color.LightPink;
                e.Cancel = true;
            }
            else
                c.BackColor = Color.LightGreen;
            return res;
        }

        private void ArticleForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            chek(NameA,e);
            chek(Type,e);
            chek(Region,e);
            chek(Regime,e);
            chek(Editional,e);
          
        }
    }
}
