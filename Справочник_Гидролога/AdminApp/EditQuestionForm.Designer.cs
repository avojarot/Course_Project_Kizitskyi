namespace AdminApp
{
    partial class EditQuestionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditQuestionForm));
            this.MainBox = new System.Windows.Forms.TextBox();
            this.GridOptins = new System.Windows.Forms.DataGridView();
            this.Option = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuestionopionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QuestionBindingSourceGrid = new System.Windows.Forms.BindingSource(this.components);
            this.TestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RightCbox = new System.Windows.Forms.ComboBox();
            this.QuestionBindingSourceCbox = new System.Windows.Forms.BindingSource(this.components);
            this.QuestionPoints = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.DS = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CanselButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.EditMenu = new System.Windows.Forms.MenuStrip();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.GridOptins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuestionopionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuestionBindingSourceGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuestionBindingSourceCbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuestionPoints)).BeginInit();
            this.EditMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainBox
            // 
            this.MainBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainBox.Location = new System.Drawing.Point(78, 27);
            this.MainBox.Multiline = true;
            this.MainBox.Name = "MainBox";
            this.MainBox.Size = new System.Drawing.Size(294, 38);
            this.MainBox.TabIndex = 0;
            // 
            // GridOptins
            // 
            this.GridOptins.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridOptins.AutoGenerateColumns = false;
            this.GridOptins.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridOptins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridOptins.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Option});
            this.GridOptins.DataSource = this.QuestionopionsBindingSource;
            this.GridOptins.Location = new System.Drawing.Point(6, 105);
            this.GridOptins.Name = "GridOptins";
            this.GridOptins.Size = new System.Drawing.Size(366, 155);
            this.GridOptins.TabIndex = 1;
            this.GridOptins.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.NataGridView1_CellEndEdit);
            // 
            // Option
            // 
            this.Option.DataPropertyName = "Value";
            this.Option.HeaderText = "Вариант ответа";
            this.Option.Name = "Option";
            // 
            // QuestionopionsBindingSource
            // 
            this.QuestionopionsBindingSource.DataMember = "AnswerOptions";
            this.QuestionopionsBindingSource.DataSource = this.QuestionBindingSourceGrid;
            // 
            // QuestionBindingSourceGrid
            // 
            this.QuestionBindingSourceGrid.DataMember = "Questions";
            this.QuestionBindingSourceGrid.DataSource = this.TestBindingSource;
            // 
            // TestBindingSource
            // 
            this.TestBindingSource.DataSource = typeof(Hydrologist.models.Test);
            // 
            // RightCbox
            // 
            this.RightCbox.DataSource = this.QuestionBindingSourceCbox;
            this.RightCbox.DisplayMember = "Value";
            this.RightCbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RightCbox.FormattingEnabled = true;
            this.RightCbox.Location = new System.Drawing.Point(78, 78);
            this.RightCbox.Name = "RightCbox";
            this.RightCbox.Size = new System.Drawing.Size(75, 21);
            this.RightCbox.TabIndex = 2;
            // 
            // QuestionBindingSourceCbox
            // 
            this.QuestionBindingSourceCbox.DataMember = "AnswerOptions";
            this.QuestionBindingSourceCbox.DataSource = this.QuestionBindingSourceGrid;
            // 
            // QuestionPoints
            // 
            this.QuestionPoints.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.QuestionPoints.Location = new System.Drawing.Point(320, 78);
            this.QuestionPoints.Maximum = new decimal(new int[] {
            200000000,
            0,
            0,
            0});
            this.QuestionPoints.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.QuestionPoints.Name = "QuestionPoints";
            this.QuestionPoints.Size = new System.Drawing.Size(52, 20);
            this.QuestionPoints.TabIndex = 7;
            this.QuestionPoints.Value = new decimal(new int[] {
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
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(264, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 26);
            this.label3.TabIndex = 10;
            this.label3.Text = "Очки за \r\nвопрос";
            // 
            // CanselButton
            // 
            this.CanselButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CanselButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CanselButton.Location = new System.Drawing.Point(297, 266);
            this.CanselButton.Name = "CanselButton";
            this.CanselButton.Size = new System.Drawing.Size(75, 23);
            this.CanselButton.TabIndex = 14;
            this.CanselButton.Text = "Закрыть";
            this.CanselButton.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SaveButton.Location = new System.Drawing.Point(200, 266);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 15;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.Save_Click);
            // 
            // EditMenu
            // 
            this.EditMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.EditMenu.Location = new System.Drawing.Point(0, 0);
            this.EditMenu.Name = "EditMenu";
            this.EditMenu.Size = new System.Drawing.Size(384, 24);
            this.EditMenu.TabIndex = 16;
            this.EditMenu.Text = "menuStrip1";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.newToolStripMenuItem.Text = "Создать";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.editToolStripMenuItem.Text = "Редактировать";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.EditToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.deleteToolStripMenuItem.Text = "Удалить";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // EditQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 291);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.CanselButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.QuestionPoints);
            this.Controls.Add(this.RightCbox);
            this.Controls.Add(this.GridOptins);
            this.Controls.Add(this.MainBox);
            this.Controls.Add(this.EditMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.EditMenu;
            this.MinimumSize = new System.Drawing.Size(290, 250);
            this.Name = "EditQuestionForm";
            this.Text = "Справочник гидролога";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditQueForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.GridOptins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuestionopionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuestionBindingSourceGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuestionBindingSourceCbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuestionPoints)).EndInit();
            this.EditMenu.ResumeLayout(false);
            this.EditMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MainBox;
        private System.Windows.Forms.DataGridView GridOptins;
        private System.Windows.Forms.BindingSource QuestionopionsBindingSource;
        private System.Windows.Forms.BindingSource QuestionBindingSourceGrid;
        private System.Windows.Forms.BindingSource TestBindingSource;
        private System.Windows.Forms.ComboBox RightCbox;
        private System.Windows.Forms.NumericUpDown QuestionPoints;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CanselButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.BindingSource QuestionBindingSourceCbox;
        private System.Windows.Forms.MenuStrip EditMenu;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Option;
    }
}