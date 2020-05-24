namespace AdminApp
{
    partial class HomeForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ArtSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.help = new System.Windows.Forms.ToolStripMenuItem();
            this.ArticleList = new System.Windows.Forms.ListBox();
            this.articlesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hydrologistGuideBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.articlesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ArtEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.ArtNew = new System.Windows.Forms.ToolStripMenuItem();
            this.ArtDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.testsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TestEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.TestNew = new System.Windows.Forms.ToolStripMenuItem();
            this.TestDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.articlesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hydrologistGuideBindingSource)).BeginInit();
            this.LoginPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkGreen;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.ArtSearch,
            this.help});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.Color.LawnGreen;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.saveToolStripMenuItem.Text = "Сохранить";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.loadToolStripMenuItem.Text = "Загрузить";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(129, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // ArtSearch
            // 
            this.ArtSearch.BackColor = System.Drawing.Color.LawnGreen;
            this.ArtSearch.Name = "ArtSearch";
            this.ArtSearch.Size = new System.Drawing.Size(54, 20);
            this.ArtSearch.Text = "Поиск";
            this.ArtSearch.Click += new System.EventHandler(this.ArtSearch_Click);
            // 
            // help
            // 
            this.help.BackColor = System.Drawing.Color.LawnGreen;
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(68, 20);
            this.help.Text = "Помощь";
            this.help.Click += new System.EventHandler(this.help_Click);
            // 
            // ArticleList
            // 
            this.ArticleList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ArticleList.BackColor = System.Drawing.Color.LawnGreen;
            this.ArticleList.DataSource = this.articlesBindingSource;
            this.ArticleList.DisplayMember = "Name";
            this.ArticleList.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ArticleList.FormattingEnabled = true;
            this.ArticleList.ItemHeight = 20;
            this.ArticleList.Location = new System.Drawing.Point(100, 102);
            this.ArticleList.Name = "ArticleList";
            this.ArticleList.Size = new System.Drawing.Size(688, 344);
            this.ArticleList.Sorted = true;
            this.ArticleList.TabIndex = 1;
            this.ArticleList.DoubleClick += new System.EventHandler(this.ArticleList_DoubleClick);
            // 
            // articlesBindingSource
            // 
            this.articlesBindingSource.DataMember = "Articles";
            this.articlesBindingSource.DataSource = this.hydrologistGuideBindingSource;
            // 
            // hydrologistGuideBindingSource
            // 
            this.hydrologistGuideBindingSource.DataSource = typeof(Hydrologist.models.HydrologistGuide);
            // 
            // LoginPanel
            // 
            this.LoginPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginPanel.BackColor = System.Drawing.Color.DarkGreen;
            this.LoginPanel.Controls.Add(this.label1);
            this.LoginPanel.Location = new System.Drawing.Point(100, 27);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(688, 69);
            this.LoginPanel.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LawnGreen;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(27, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(440, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Все существующие статьи про водные объекты";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGreen;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(0, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(94, 119);
            this.panel2.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(2, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 34);
            this.label2.TabIndex = 0;
            this.label2.Text = "Навигация \r\nпо разделам";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGreen;
            this.panel1.Controls.Add(this.menuStrip2);
            this.panel1.Location = new System.Drawing.Point(0, 152);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(94, 285);
            this.panel1.TabIndex = 10;
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.PaleGreen;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.articlesToolStripMenuItem,
            this.testsToolStripMenuItem});
            this.menuStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(94, 64);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // articlesToolStripMenuItem
            // 
            this.articlesToolStripMenuItem.BackColor = System.Drawing.Color.LawnGreen;
            this.articlesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ArtEdit,
            this.ArtNew,
            this.ArtDelete});
            this.articlesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.articlesToolStripMenuItem.Name = "articlesToolStripMenuItem";
            this.articlesToolStripMenuItem.Size = new System.Drawing.Size(87, 29);
            this.articlesToolStripMenuItem.Text = "Статьи";
            // 
            // ArtEdit
            // 
            this.ArtEdit.Name = "ArtEdit";
            this.ArtEdit.Size = new System.Drawing.Size(205, 30);
            this.ArtEdit.Text = "Редактировать";
            this.ArtEdit.Click += new System.EventHandler(this.ArtEdit_Click);
            // 
            // ArtNew
            // 
            this.ArtNew.Name = "ArtNew";
            this.ArtNew.Size = new System.Drawing.Size(205, 30);
            this.ArtNew.Text = "Создать";
            this.ArtNew.Click += new System.EventHandler(this.ArtNew_Click);
            // 
            // ArtDelete
            // 
            this.ArtDelete.Name = "ArtDelete";
            this.ArtDelete.Size = new System.Drawing.Size(205, 30);
            this.ArtDelete.Text = "Удалить";
            this.ArtDelete.Click += new System.EventHandler(this.ArtDelete_Click);
            // 
            // testsToolStripMenuItem
            // 
            this.testsToolStripMenuItem.BackColor = System.Drawing.Color.LawnGreen;
            this.testsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TestEdit,
            this.TestNew,
            this.TestDelete});
            this.testsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.testsToolStripMenuItem.Name = "testsToolStripMenuItem";
            this.testsToolStripMenuItem.Size = new System.Drawing.Size(87, 29);
            this.testsToolStripMenuItem.Text = "Тесты";
            this.testsToolStripMenuItem.Click += new System.EventHandler(this.testsToolStripMenuItem_Click);
            // 
            // TestEdit
            // 
            this.TestEdit.Name = "TestEdit";
            this.TestEdit.Size = new System.Drawing.Size(205, 30);
            this.TestEdit.Text = "Редактировать";
            // 
            // TestNew
            // 
            this.TestNew.Name = "TestNew";
            this.TestNew.Size = new System.Drawing.Size(205, 30);
            this.TestNew.Text = "Создать";
            // 
            // TestDelete
            // 
            this.TestDelete.Name = "TestDelete";
            this.TestDelete.Size = new System.Drawing.Size(205, 30);
            this.TestDelete.Text = "Удалить";
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.LoginPanel);
            this.Controls.Add(this.ArticleList);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HomeForm";
            this.Text = "Справочник гидролога";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HomeForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HomeForm_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.articlesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hydrologistGuideBindingSource)).EndInit();
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ListBox ArticleList;
        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem help;
        private System.Windows.Forms.BindingSource articlesBindingSource;
        private System.Windows.Forms.BindingSource hydrologistGuideBindingSource;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripMenuItem ArtSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem articlesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ArtEdit;
        private System.Windows.Forms.ToolStripMenuItem ArtNew;
        private System.Windows.Forms.ToolStripMenuItem ArtDelete;
        private System.Windows.Forms.ToolStripMenuItem testsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TestEdit;
        private System.Windows.Forms.ToolStripMenuItem TestNew;
        private System.Windows.Forms.ToolStripMenuItem TestDelete;
        private System.Windows.Forms.Label label2;
    }
}