namespace AdminApp
{
    partial class ETF
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
            this.label1 = new System.Windows.Forms.Label();
            this.NameA1 = new System.Windows.Forms.TextBox();
            this.CQL1 = new System.Windows.Forms.ListBox();
            this.questionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Save1 = new System.Windows.Forms.Button();
            this.Cansel1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.new1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edit1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.delete1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.search1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.questionsBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
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
            // NameA1
            // 
            this.NameA1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameA1.Location = new System.Drawing.Point(75, 41);
            this.NameA1.Multiline = true;
            this.NameA1.Name = "NameA1";
            this.NameA1.Size = new System.Drawing.Size(327, 20);
            this.NameA1.TabIndex = 8;
            // 
            // CQL1
            // 
            this.CQL1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CQL1.DataSource = this.questionsBindingSource;
            this.CQL1.DisplayMember = "TextOfQuestion";
            this.CQL1.FormattingEnabled = true;
            this.CQL1.Location = new System.Drawing.Point(12, 95);
            this.CQL1.Name = "CQL1";
            this.CQL1.Size = new System.Drawing.Size(390, 173);
            this.CQL1.TabIndex = 10;
            this.CQL1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.CQL1_MouseDoubleClick);
            // 
            // questionsBindingSource
            // 
            this.questionsBindingSource.DataMember = "Questions";
            this.questionsBindingSource.DataSource = typeof(Hydrologist.models.Test);
            // 
            // Save1
            // 
            this.Save1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Save1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Save1.Location = new System.Drawing.Point(208, 274);
            this.Save1.Name = "Save1";
            this.Save1.Size = new System.Drawing.Size(75, 23);
            this.Save1.TabIndex = 12;
            this.Save1.Text = "Сохранить";
            this.Save1.UseVisualStyleBackColor = true;
            this.Save1.Click += new System.EventHandler(this.Save1_Click);
            // 
            // Cansel1
            // 
            this.Cansel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Cansel1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cansel1.Location = new System.Drawing.Point(327, 274);
            this.Cansel1.Name = "Cansel1";
            this.Cansel1.Size = new System.Drawing.Size(75, 23);
            this.Cansel1.TabIndex = 13;
            this.Cansel1.Text = "Закрыть";
            this.Cansel1.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.new1ToolStripMenuItem,
            this.edit1ToolStripMenuItem,
            this.delete1ToolStripMenuItem,
            this.search1ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(414, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // new1ToolStripMenuItem
            // 
            this.new1ToolStripMenuItem.Name = "new1ToolStripMenuItem";
            this.new1ToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.new1ToolStripMenuItem.Text = "Создать";
            this.new1ToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // edit1ToolStripMenuItem
            // 
            this.edit1ToolStripMenuItem.Name = "edit1ToolStripMenuItem";
            this.edit1ToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.edit1ToolStripMenuItem.Text = "Редактировать";
            this.edit1ToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // delete1ToolStripMenuItem
            // 
            this.delete1ToolStripMenuItem.Name = "delete1ToolStripMenuItem";
            this.delete1ToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.delete1ToolStripMenuItem.Text = "Удалить";
            this.delete1ToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // search1ToolStripMenuItem
            // 
            this.search1ToolStripMenuItem.Name = "search1ToolStripMenuItem";
            this.search1ToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.search1ToolStripMenuItem.Text = "Поиск";
            this.search1ToolStripMenuItem.Click += new System.EventHandler(this.search1ToolStripMenuItem_Click);
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
            this.ClientSize = new System.Drawing.Size(414, 309);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Cansel1);
            this.Controls.Add(this.Save1);
            this.Controls.Add(this.CQL1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameA1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ETF";
            this.Text = "Справочник гидролога";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ETF1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.questionsBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameA1;
        private System.Windows.Forms.ListBox CQL1;
        private System.Windows.Forms.Button Save1;
        private System.Windows.Forms.Button Cansel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem new1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edit1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem delete1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem search1ToolStripMenuItem;
        private System.Windows.Forms.BindingSource questionsBindingSource;
        private System.Windows.Forms.Label label2;
    }
}