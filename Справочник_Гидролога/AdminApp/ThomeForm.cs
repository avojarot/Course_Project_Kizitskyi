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
    public partial class THomeForm : HomeForm
    {
        public THomeForm(HydrologistGuide guide)
        {
            InitializeComponent();
            this.guide = guide;
            VerifiContent();
            BST.DataSource = guide;
        }
        protected override void VerifiContent()
        {
            if (!(guide.CurrentUser is Admin))
            {
                this.TNew.Visible = false;
                this.TDelete.Visible = false;
                this.TEdit.Visible = false;

            }
        }
        
        private void articlesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void saveToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            base.saveToolStripMenuItem_Click(sender, e);
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            guide.Load();
            BST.DataSource = guide;
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void help_Click_1(object sender, EventArgs e)
        {
            base.help_Click(sender,e);
        }

        private void TestDelete_Click(object sender, EventArgs e)
        {
            var item = NTList.SelectedItem as Test;
            if (item == null)
                return;
            var mess = MessageBox.Show($"Действительно удалить тест {item.Name} ? ",
                "Удаление", MessageBoxButtons.YesNo);
            if (DialogResult.Yes == mess)
            {   if (BST.DataSource != guide)
                    ((List<Test>)BST.DataSource).Remove(item);
                guide.Tests.Remove(item);
                BST.ResetBindings(false);
                guide.changed = true;
            }
        }

        private void TestEdit_Click(object sender, EventArgs e)
        {
            var item = NTList.SelectedItem as Test;
            if (item == null)
                return;
            int index = guide.Tests.IndexOf(item);
            var editForm = new ETF(item);
            editForm.ShowDialog();
            if (editForm.DialogResult == DialogResult.OK)
            {
                guide.Tests[index] = new Test(editForm.test);
                BST.ResetBindings(false);
                guide.changed = true;
            }
        }

        private void TESThomeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            base.HomeForm_FormClosing(sender, e);
        }

        private void TestNew_Click(object sender, EventArgs e)
        {
            var editForm = new ETF();
            editForm.ShowDialog();
            if (editForm.DialogResult == DialogResult.OK)
            {
                guide.Tests.Add(new Test(editForm.test));
                BST.ResetBindings(false);
                guide.changed = true;
            }
        }

        private void TSearch_Click(object sender, EventArgs e)
        {
            var search = new TestSearchForm<Test>(guide.Tests);
            search.ShowDialog();
            if (search.DialogResult == DialogResult.Yes)
            {
                BST.DataSource = search.Searched;
                if (search.Searched.Count == 0)
                    MessageBox.Show("К сожалению, ничего не найденo...", "Ошибка");
            }
            else if (search.DialogResult == DialogResult.No)
                BST.DataSource = guide.Tests;

            BST.ResetBindings(false);
        }

        private void NTList_DoubleClick(object sender, EventArgs e)
        {
            var current = NTList.SelectedItem as Test;
            if (current == null)
                return;
            var art = new TestingForm(current,guide.CurrentUser);
            this.Hide();
            art.ShowDialog();
            if (art.DialogResult == DialogResult.Cancel)
                this.Show();
            guide.Save();
        }
    }
}
