namespace AdminApp
{
    partial class EditTestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditTestForm));
            this.label1 = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.OptionList = new System.Windows.Forms.ListBox();
            this.questionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SaveButton = new System.Windows.Forms.Button();
            this.CanselButton = new System.Windows.Forms.Button();
            this.EditMenu = new System.Windows.Forms.MenuStrip();
            this.new1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edit1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.delete1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.search1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.questionsBindingSource)).BeginInit();
            this.EditMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Название";
            // 
            // NameBox
            // 
            this.NameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameBox.Location = new System.Drawing.Point(75, 41);
            this.NameBox.Multiline = true;
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(327, 20);
            this.NameBox.TabIndex = 8;
            // 
            // OptionList
            // 
            this.OptionList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OptionList.DataSource = this.questionsBindingSource;
            this.OptionList.DisplayMember = "TextOfQuestion";
            this.OptionList.FormattingEnabled = true;
            this.OptionList.Location = new System.Drawing.Point(12, 95);
            this.OptionList.Name = "OptionList";
            this.OptionList.Size = new System.Drawing.Size(390, 173);
            this.OptionList.TabIndex = 10;
            this.OptionList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.CQL1_MouseDoubleClick);
            // 
            // questionsBindingSource
            // 
            this.questionsBindingSource.DataMember = "Questions";
            this.questionsBindingSource.DataSource = typeof(Hydrologist.models.Test);
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SaveButton.Location = new System.Drawing.Point(208, 276);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 12;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.Save1_Click);
            // 
            // CanselButton
            // 
            this.CanselButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CanselButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CanselButton.Location = new System.Drawing.Point(327, 276);
            this.CanselButton.Name = "CanselButton";
            this.CanselButton.Size = new System.Drawing.Size(75, 23);
            this.CanselButton.TabIndex = 13;
            this.CanselButton.Text = "Закрыть";
            this.CanselButton.UseVisualStyleBackColor = true;
            // 
            // EditMenu
            // 
            this.EditMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.new1ToolStripMenuItem,
            this.edit1ToolStripMenuItem,
            this.delete1ToolStripMenuItem,
            this.search1ToolStripMenuItem});
            this.EditMenu.Location = new System.Drawing.Point(0, 0);
            this.EditMenu.Name = "EditMenu";
            this.EditMenu.Size = new System.Drawing.Size(414, 24);
            this.EditMenu.TabIndex = 14;
            this.EditMenu.Text = "menuStrip1";
            // 
            // new1ToolStripMenuItem
            // 
            this.new1ToolStripMenuItem.Name = "new1ToolStripMenuItem";
            this.new1ToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.new1ToolStripMenuItem.Text = "Создать";
            this.new1ToolStripMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItem_Click);
            // 
            // edit1ToolStripMenuItem
            // 
            this.edit1ToolStripMenuItem.Name = "edit1ToolStripMenuItem";
            this.edit1ToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.edit1ToolStripMenuItem.Text = "Редактировать";
            this.edit1ToolStripMenuItem.Click += new System.EventHandler(this.EditToolStripMenuItem_Click);
            // 
            // delete1ToolStripMenuItem
            // 
            this.delete1ToolStripMenuItem.Name = "delete1ToolStripMenuItem";
            this.delete1ToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.delete1ToolStripMenuItem.Text = "Удалить";
            this.delete1ToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // search1ToolStripMenuItem
            // 
            this.search1ToolStripMenuItem.Name = "search1ToolStripMenuItem";
            this.search1ToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.search1ToolStripMenuItem.Text = "Поиск";
            this.search1ToolStripMenuItem.Click += new System.EventHandler(this.Search1ToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Список вопросов";
            // 
            // ETF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 311);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CanselButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.OptionList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.EditMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.EditMenu;
            this.MinimumSize = new System.Drawing.Size(300, 200);
            this.Name = "ETF";
            this.Text = "Справочник гидролога";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ETF1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.questionsBindingSource)).EndInit();
            this.EditMenu.ResumeLayout(false);
            this.EditMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.ListBox OptionList;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CanselButton;
        private System.Windows.Forms.MenuStrip EditMenu;
        private System.Windows.Forms.ToolStripMenuItem new1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edit1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem delete1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem search1ToolStripMenuItem;
        private System.Windows.Forms.BindingSource questionsBindingSource;
        private System.Windows.Forms.Label label2;
    }
}