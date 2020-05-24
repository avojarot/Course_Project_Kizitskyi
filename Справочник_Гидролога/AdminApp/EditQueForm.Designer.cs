namespace AdminApp
{
    partial class EditQueForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MainText = new System.Windows.Forms.TextBox();
            this.myData = new System.Windows.Forms.DataGridView();
            this.Option = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.answerOptionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.questionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.right = new System.Windows.Forms.ComboBox();
            this.answerOptionsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.QPoints = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.DS = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Cansel = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.myData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.answerOptionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.answerOptionsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QPoints)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainText
            // 
            this.MainText.Location = new System.Drawing.Point(78, 27);
            this.MainText.Multiline = true;
            this.MainText.Name = "MainText";
            this.MainText.Size = new System.Drawing.Size(293, 38);
            this.MainText.TabIndex = 0;
            // 
            // myData
            // 
            this.myData.AutoGenerateColumns = false;
            this.myData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Option});
            this.myData.DataSource = this.answerOptionsBindingSource;
            this.myData.Location = new System.Drawing.Point(6, 105);
            this.myData.Name = "myData";
            this.myData.Size = new System.Drawing.Size(365, 136);
            this.myData.TabIndex = 1;
            this.myData.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // Option
            // 
            this.Option.DataPropertyName = "Value";
            this.Option.HeaderText = "Вариант ответа";
            this.Option.Name = "Option";
            this.Option.Width = 300;
            // 
            // answerOptionsBindingSource
            // 
            this.answerOptionsBindingSource.DataMember = "AnswerOptions";
            this.answerOptionsBindingSource.DataSource = this.questionsBindingSource;
            // 
            // questionsBindingSource
            // 
            this.questionsBindingSource.DataMember = "Questions";
            this.questionsBindingSource.DataSource = this.testBindingSource;
            // 
            // testBindingSource
            // 
            this.testBindingSource.DataSource = typeof(Hydrologist.models.Test);
            // 
            // right
            // 
            this.right.DataSource = this.answerOptionsBindingSource1;
            this.right.DisplayMember = "Value";
            this.right.FormattingEnabled = true;
            this.right.Location = new System.Drawing.Point(78, 78);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(121, 21);
            this.right.TabIndex = 2;
            // 
            // answerOptionsBindingSource1
            // 
            this.answerOptionsBindingSource1.DataMember = "AnswerOptions";
            this.answerOptionsBindingSource1.DataSource = this.questionsBindingSource;
            // 
            // QPoints
            // 
            this.QPoints.Location = new System.Drawing.Point(288, 78);
            this.QPoints.Maximum = new decimal(new int[] {
            200000000,
            0,
            0,
            0});
            this.QPoints.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.QPoints.Name = "QPoints";
            this.QPoints.Size = new System.Drawing.Size(83, 20);
            this.QPoints.TabIndex = 7;
            this.QPoints.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "Текст \r\nвопроса";
            // 
            // DS
            // 
            this.DS.AutoSize = true;
            this.DS.Location = new System.Drawing.Point(3, 73);
            this.DS.Name = "DS";
            this.DS.Size = new System.Drawing.Size(71, 26);
            this.DS.TabIndex = 9;
            this.DS.Text = "Правильный\r\n вариант";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 26);
            this.label3.TabIndex = 10;
            this.label3.Text = "Очки за \r\nвопрос";
            // 
            // Cansel
            // 
            this.Cansel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cansel.Location = new System.Drawing.Point(308, 256);
            this.Cansel.Name = "Cansel";
            this.Cansel.Size = new System.Drawing.Size(75, 23);
            this.Cansel.TabIndex = 14;
            this.Cansel.Text = "Cansel";
            this.Cansel.UseVisualStyleBackColor = true;
            // 
            // Save
            // 
            this.Save.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Save.Location = new System.Drawing.Point(200, 256);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 15;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(383, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // EditQueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 291);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Cansel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.QPoints);
            this.Controls.Add(this.right);
            this.Controls.Add(this.myData);
            this.Controls.Add(this.MainText);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EditQueForm";
            this.Text = "EditQueForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditQueForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.myData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.answerOptionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.answerOptionsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QPoints)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MainText;
        private System.Windows.Forms.DataGridView myData;
        private System.Windows.Forms.BindingSource answerOptionsBindingSource;
        private System.Windows.Forms.BindingSource questionsBindingSource;
        private System.Windows.Forms.BindingSource testBindingSource;
        private System.Windows.Forms.ComboBox right;
        private System.Windows.Forms.NumericUpDown QPoints;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Cansel;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.BindingSource answerOptionsBindingSource1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Option;
    }
}