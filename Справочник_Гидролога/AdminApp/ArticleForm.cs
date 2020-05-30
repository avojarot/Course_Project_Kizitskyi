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
{   //Форма для просмотра статей
    public partial class ArticleForm : Form
    {   
        //Инициализация и заполнение формы
        public ArticleForm(WaterObject river)
        {
            InitializeComponent();
            NameBox.Text = river.Name;
            TypeBox.Text = river.Type;
            RegionBox.Text = river.Region;
            AreaBox.Text = river.Area.ToString();
            DeapthBox.Text = river.Depth.ToString();
            EditonalBox.Text = river.EditionalData;
            PictureBox.Image = river.Image;

        }

       

        private void Cansel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
