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
    public partial class EditArticleForm : Form
    {
        public WaterObject obj { get; set; }
        public EditArticleForm()
        {
            InitializeComponent();
        }
        public EditArticleForm(WaterObject o2) : this()
        {
            obj = new WaterObject(o2);
            Editional.Text = obj.EditionalData;
            Area.Value = obj.Area;
            pictureBox1.Image = obj.Image;
            NameA.Text = obj.Name;
            Region1.Text = obj.Region;
            Depth.Value = obj.Depth;
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
            obj.Region = Region1.Text;
            obj.Depth = Depth.Value;
            obj.Type = Type.Text;
        }


        public static bool chek(Control c, FormClosingEventArgs e)
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
            if (this.DialogResult == DialogResult.Cancel)
                return;
            chek(NameA,e);
            chek(Type,e);
            chek(Region1,e);
            chek(Depth,e);
            chek(Editional,e);
            chek(Area, e);
          
        }

       
    }
}
