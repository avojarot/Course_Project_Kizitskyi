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
    public partial class HomeForm : Form
    {
        HydrologistGuide guide;
        public HomeForm(HydrologistGuide guide)
        {
            InitializeComponent();
            this.guide = guide;
            VerifiContent();
            articlesBindingSource.DataSource = guide;
        }
        private void VerifiContent()
        {
            if (!(guide.CurrentUser is Admin))
            {
                ArtNew.Visible = false;
                ArtDelete.Visible = false;
                ArtEdit.Visible = false;
                TestNew.Visible = false;
                TestDelete.Visible = false;
                TestEdit.Visible = false;

            }
        }
       

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            guide.Save();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            guide.Load();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ArtDelete_Click(object sender, EventArgs e)
        {
            var item = ArticleList.SelectedItem as WaterObject;
           var mess = MessageBox.Show($"Действительно удалить статью {item.Name} ? ",
               "Удаление",MessageBoxButtons.YesNo);
            if (DialogResult.Yes == mess)
            {
                guide.Articles.Remove(item);
                articlesBindingSource.ResetBindings(false);
            }
        }

        private void ArtEdit_Click(object sender, EventArgs e)
        {
            var item = ArticleList.SelectedItem as WaterObject;
            int index = guide.Articles.IndexOf(item);
            var editForm = new ArticleForm(item);
            editForm.ShowDialog();
            guide.Articles[index] = new WaterObject(editForm.obj);
            articlesBindingSource.ResetBindings(false);
        }

        private void ArtNew_Click(object sender, EventArgs e)
        {
            var editForm = new ArticleForm();
            editForm.ShowDialog();
            guide.Articles.Add(new WaterObject(editForm.obj));
            articlesBindingSource.ResetBindings(false);
        }

        private void HomeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
