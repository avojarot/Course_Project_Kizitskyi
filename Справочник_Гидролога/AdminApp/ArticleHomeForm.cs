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
{   //Форма для просмотра, редактирования,
    //удаления, создание статей
    public partial class ArticleHomeForm : Form
    {   //Сам справочник, с всеми базами
        protected HydrologistGuide guide;
        //Пустой конструктор
        public ArticleHomeForm() { }
        //Создание формы
        public ArticleHomeForm(HydrologistGuide guide)
        {
            InitializeComponent();
            this.guide = guide;
            VerifiContent();
            ArticleBindingSource.DataSource = guide;
        }
        //Проверка на админа и скрытие админских кнопок
        protected virtual void VerifiContent()
        {
            if (!(guide.CurrentUser is Admin))
            {
                this.ArtNew.Visible = false;
                this.ArtDelete.Visible = false;
                this.ArtEdit.Visible = false;

            }
        }
       
        //Сохранение справочника в файл
        protected void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            guide.Save();
        }

        private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            guide.Load();
            ArticleBindingSource.ResetBindings(false);
        }
        //Выход с формы
       protected void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ArtDelete_Click(object sender, EventArgs e)
        {
            if (!(ArticleList.SelectedItem is WaterObject item))
                return;
            var mess = MessageBox.Show($"Действительно удалить статью {item.Name} ? ",
               "Удаление",MessageBoxButtons.YesNo);
            if (DialogResult.Yes == mess)
            {   if(ArticleBindingSource.DataSource != guide) 
                  ((List<WaterObject>) ArticleBindingSource.DataSource).Remove(item);
                
                    
                guide.Articles.Remove(item);
                ArticleBindingSource.ResetBindings(false);
                guide.changed = true;
            }
        }

        private void ArtEdit_Click(object sender, EventArgs e)
        {
            if (!(ArticleList.SelectedItem is WaterObject item))
                return;
            int index = guide.Articles.IndexOf(item);
            var editForm = new EditArticleForm(item);
            editForm.ShowDialog();
            if (editForm.DialogResult == DialogResult.OK)
            {
                guide.Articles[index] = new WaterObject(editForm.Water);
                ArticleBindingSource.ResetBindings(false);
                guide.changed = true;
            }
        }

        private void ArtNew_Click(object sender, EventArgs e)
        {
            var editForm = new EditArticleForm();
            editForm.ShowDialog();
            if (editForm.DialogResult == DialogResult.OK)
            {
                guide.Articles.Add(new WaterObject(editForm.Water));
                ArticleBindingSource.ResetBindings(false);
                guide.changed = true;
            }
        }
        //Выход с приложения
        protected void HomeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
         Application.Exit();
        }
        //Запрос о сохранении несохранённого при выходе
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
            if (!(ArticleList.SelectedItem is WaterObject current))
                return;
            var art = new ArticleForm(current);
            this.Hide();
            art.ShowDialog();
            if (art.DialogResult == DialogResult.Cancel)
                this.Show();
              
        }
        //Попытка получить помощь
        protected void Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Чтобы получить помощь, читайте инструкцию пользователя", "Help");
        }

        private void ArtSearch_Click(object sender, EventArgs e)
        {
            var search = new SearchArticleForm(guide.Articles);
            search.ShowDialog();
            if (search.DialogResult == DialogResult.Yes)
            {
                ArticleBindingSource.DataSource = search.Searched;
                if (search.Searched.Count == 0)
                    MessageBox.Show("К сожалению, ничего не найденo...", "Ошибка");
            }
            else if (search.DialogResult == DialogResult.No)
                ArticleBindingSource.DataSource = guide.Articles;
               
            ArticleBindingSource.ResetBindings(false);
        }

        private void TestsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var testForm = new TestHomeForm(guide);
           testForm.ShowDialog();
            if (testForm.DialogResult == DialogResult.OK)
                this.Show();
            else
            {
                this.Close();
            }
        }

       
    }
}
