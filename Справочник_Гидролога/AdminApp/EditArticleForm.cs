using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hydrologist.DAL;
using Hydrologist.models;

namespace AdminApp
{   // Форма для редактирования и создания статей
    public partial class EditArticleForm : Form
    {   //Объект в котором временно хранятся 
        // редактируемые данные
        public WaterObject Water { get; set; }
        //Коструктор для создания
        public EditArticleForm()
        {
            InitializeComponent();
        }
        //Коструктор для редактирования
        public EditArticleForm(WaterObject o2) : this()
        {
            Water = new WaterObject(o2);
            EditionalBox.Text = Water.EditionalData;
            AreaNumber.Value = Water.Area;
            WaterImage.Image = Water.Image;
            NameBox.Text = Water.Name;
            RegionCbox.Text = Water.Region;
            DepthNumber.Value = Water.Depth;
            TypeCbox.Text = Water.Type;

        }
        private void PictureBox1_Click(object sender, EventArgs e)
        { var dial = new OpenFileDialog();
            if (dial.ShowDialog() == DialogResult.OK)
            {
                WaterImage.Image = new Bitmap(dial.FileName);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(Water == null)
            {
                Water = new WaterObject();
            }
            Water.EditionalData = EditionalBox.Text;
            Water.Area = AreaNumber.Value;
            Water.Image = (Bitmap)WaterImage.Image;
            Water.Name = NameBox.Text;
            Water.Region = RegionCbox.Text;
            Water.Depth = DepthNumber.Value;
            Water.Type = TypeCbox.Text;
        }

        //Метод для проверки ввода пользователя
        public static bool Сhek(Control c, FormClosingEventArgs e)
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
            Сhek(NameBox,e);
            Сhek(TypeCbox,e);
            Сhek(RegionCbox,e);
            Сhek(DepthNumber,e);
            Сhek(EditionalBox,e);
            Сhek(AreaNumber, e);
          
        }

        private void Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TypeCbox.Items.Contains(TypeCbox.Text))
            {   
                WaterImage.Image = DAO.LoadTestImage(TypeCbox.Text);
            }
            else
            {
                const string baseImage = "Лужа";
                WaterImage.Image = DAO.LoadTestImage(baseImage);
            }
        }
    }
}
