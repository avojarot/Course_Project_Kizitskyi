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
{   //Форма для просмотра, редактирования,
    //удаления, создание тестов
    public partial class TestHomeForm : ArticleHomeForm
    {   //Создание формы
        public TestHomeForm(HydrologistGuide guide)
        {
            InitializeComponent();
            this.guide = guide;
            VerifiContent();
            TestBindingSource.DataSource = guide;
        }
        //Проверка на админа и скрытие админских кнопок
        protected override void VerifiContent()
        {
            if (!(guide.CurrentUser is Admin))
            {
                this.TNew.Visible = false;
                this.TDelete.Visible = false;
                this.TEdit.Visible = false;

            }
        }
        
        private void ArticlesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void SaveToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            base.SaveToolStripMenuItem_Click(sender, e);
        }

        private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            guide.Load();
            TestBindingSource.DataSource = guide;
        }

        private void ExitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Help_Click_1(object sender, EventArgs e)
        {
            base.Help_Click(sender,e);
        }

        private void TestDelete_Click(object sender, EventArgs e)
        {
            if (!(TestList.SelectedItem is Test item))
                return;
            var mess = MessageBox.Show($"Действительно удалить тест {item.Name} ? ",
                "Удаление", MessageBoxButtons.YesNo);
            if (DialogResult.Yes == mess)
            {   if (TestBindingSource.DataSource != guide)
                    ((List<Test>)TestBindingSource.DataSource).Remove(item);
                guide.Tests.Remove(item);
                TestBindingSource.ResetBindings(false);
                guide.changed = true;
            }
        }

        private void TestEdit_Click(object sender, EventArgs e)
        {
            if (!(TestList.SelectedItem is Test item))
                return;
            int index = guide.Tests.IndexOf(item);
            var editForm = new EditTestForm(item);
            editForm.ShowDialog();
            if (editForm.DialogResult == DialogResult.OK)
            {
                guide.Tests[index] = new Test(editForm.test);
                TestBindingSource.ResetBindings(false);
                guide.changed = true;
            }
        }

        private void TESThomeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            base.HomeForm_FormClosing(sender, e);
            guide.changed = false;
        }

        private void TestNew_Click(object sender, EventArgs e)
        {
            var editForm = new EditTestForm();
            editForm.ShowDialog();
            if (editForm.DialogResult == DialogResult.OK)
            {
                guide.Tests.Add(new Test(editForm.test));
                TestBindingSource.ResetBindings(false);
                guide.changed = true;
            }
        }

        private void TSearch_Click(object sender, EventArgs e)
        {
            var search = new TestSearchForm<Test>(guide.Tests);
            search.ShowDialog();
            if (search.DialogResult == DialogResult.Yes)
            {
                TestBindingSource.DataSource = search.Searched;
                if (search.Searched.Count == 0)
                    MessageBox.Show("К сожалению, ничего не найденo...", "Ошибка");
            }
            else if (search.DialogResult == DialogResult.No)
                TestBindingSource.DataSource = guide.Tests;

            TestBindingSource.ResetBindings(false);
        }

        private void NTList_DoubleClick(object sender, EventArgs e)
        {
            if (!(TestList.SelectedItem is Test current))
                return;
            var art = new TestingForm(current,guide.CurrentUser);
            this.Hide();
            art.ShowDialog();
            if (art.DialogResult == DialogResult.Cancel)
                this.Show();
            guide.changed = true;
        }
    }
}
