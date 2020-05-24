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
    public partial class TESThomeForm : HomeForm
    {
        public TESThomeForm(HydrologistGuide guide)
        {
            InitializeComponent();
            this.guide = guide;
            VerifiContent();
            testsBindingSource.DataSource = guide;
        }
        protected override void VerifiContent()
        {
            if (!(guide.CurrentUser is Admin))
            {
                this.ArtNew.Visible = false;
                this.ArtDelete.Visible = false;
                this.ArtEdit.Visible = false;
                this.TestNew.Visible = false;
                this.TestDelete.Visible = false;
                this.TestEdit.Visible = false;

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
            testsBindingSource.DataSource = guide;
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
            {
                guide.Tests.Remove(item);
                testsBindingSource.ResetBindings(false);
                guide.changed = true;
            }
        }

        private void TestEdit_Click(object sender, EventArgs e)
        {
            var item = NTList.SelectedItem as Test;
            if (item == null)
                return;
            int index = guide.Tests.IndexOf(item);
            var editForm = new ETF1(item);
            editForm.ShowDialog();
            if (editForm.DialogResult == DialogResult.OK)
            {
                guide.Tests[index] = new Test(editForm.test);
                testsBindingSource.ResetBindings(false);
                guide.changed = true;
            }
        }

        private void TESThomeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            base.HomeForm_FormClosing(sender, e);
        }

        private void TestNew_Click(object sender, EventArgs e)
        {
            var editForm = new ETF1();
            editForm.ShowDialog();
            if (editForm.DialogResult == DialogResult.OK)
            {
                guide.Tests.Add(new Test(editForm.test));
                testsBindingSource.ResetBindings(false);
                guide.changed = true;
            }
        }
    }
}
