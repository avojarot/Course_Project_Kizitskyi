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
    public partial class ArticleForm : Form
    {
        public ArticleForm(WaterObject river)
        {
            InitializeComponent();
            Name12.Text = river.Name;
            Type.Text = river.Type;
            Region.Text = river.Region;
            Area.Text = river.Area.ToString();
            Deapth.Text = river.Depth.ToString();
            Editonal.Text = river.EditionalData;
            picture.Image = river.Image;

        }

       

        private void Cansel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
