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
        bool changed;
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
            articlesBindingSource.ResetBindings(false);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ArtDelete_Click(object sender, EventArgs e)
        {
            var item = ArticleList.SelectedItem as WaterObject;
            if (item == null)
                return;
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
            if (item == null)
                return;
            int index = guide.Articles.IndexOf(item);
            var editForm = new EditArticleForm(item);
            editForm.ShowDialog();
            if (editForm.DialogResult == DialogResult.OK)
            {
                guide.Articles[index] = new WaterObject(editForm.obj);
                articlesBindingSource.ResetBindings(false);
                changed = true;
            }
        }

        private void ArtNew_Click(object sender, EventArgs e)
        {
            var editForm = new EditArticleForm();
            editForm.ShowDialog();
            if (editForm.DialogResult == DialogResult.OK)
            {
                guide.Articles.Add(new WaterObject(editForm.obj));
                articlesBindingSource.ResetBindings(false);
                changed = true;
            }
        }

        private void HomeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
         Application.Exit();
        }

        private void HomeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (changed)
            {
              var dial =  MessageBox.Show("Сохранить изменения?","Сохранение",MessageBoxButtons.YesNoCancel);
                if (dial == DialogResult.Cancel)
                    e.Cancel = true;
                else if (dial == DialogResult.Yes)
                    guide.Save();

            }
        }

        private void ArticleList_DoubleClick(object sender, EventArgs e)
        {
            var current = ArticleList.SelectedItem as WaterObject;
            if (current == null)
                return;
            var art = new ArticleForm(current);
            this.Hide();
            art.ShowDialog();
            if (art.DialogResult == DialogResult.Cancel)
                this.Show();
              
        }

        private void help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Здесь нет никакого хелпа", "Help");
        }
    }
}
