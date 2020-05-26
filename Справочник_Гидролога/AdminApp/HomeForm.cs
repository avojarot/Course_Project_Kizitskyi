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
        protected HydrologistGuide guide;
        
        public HomeForm() { }
        public HomeForm(HydrologistGuide guide)
        {
            InitializeComponent();
            this.guide = guide;
            VerifiContent();
            BSA.DataSource = guide;
        }
        protected virtual void VerifiContent()
        {
            if (!(guide.CurrentUser is Admin))
            {
                this.ArtNew.Visible = false;
                this.ArtDelete.Visible = false;
                this.ArtEdit.Visible = false;

            }
        }
       

        protected void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            guide.Save();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            guide.Load();
            BSA.ResetBindings(false);
        }

       protected void exitToolStripMenuItem_Click(object sender, EventArgs e)
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
            {   if(BSA.DataSource != guide) 
                  ((List<WaterObject>) BSA.DataSource).Remove(item);
                
                    
                guide.Articles.Remove(item);
                BSA.ResetBindings(false);
                guide.changed = true;
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
                BSA.ResetBindings(false);
                guide.changed = true;
            }
        }

        private void ArtNew_Click(object sender, EventArgs e)
        {
            var editForm = new EditArticleForm();
            editForm.ShowDialog();
            if (editForm.DialogResult == DialogResult.OK)
            {
                guide.Articles.Add(new WaterObject(editForm.obj));
                BSA.ResetBindings(false);
                guide.changed = true;
            }
        }

        protected void HomeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
         Application.Exit();
        }

        protected void HomeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (guide.changed)
            {
              var dial =  MessageBox.Show("Сохранить изменения?","Сохранение",
                  MessageBoxButtons.YesNoCancel);
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

        protected void help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Здесь нет никакого хелпа", "Help");
        }

        private void ArtSearch_Click(object sender, EventArgs e)
        {
            var search = new SearchForm1(guide.Articles);
            search.ShowDialog();
            if (search.DialogResult == DialogResult.Yes)
            {
                BSA.DataSource = search.Searched;
                if (search.Searched.Count == 0)
                    MessageBox.Show("К сожалению, ничего не найденo...", "Ошибка");
            }
            else if (search.DialogResult == DialogResult.No)
                BSA.DataSource = guide.Articles;
               
            BSA.ResetBindings(false);
        }

        private void testsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var testf = new THomeForm(guide);
           testf.ShowDialog();
            if (testf.DialogResult == DialogResult.OK)
                this.Show();
            else
            {
                this.Close();
            }
        }

       
    }
}
