namespace AdminApp
{
    partial class ArticleHomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArticleHomeForm));
            this.GeneralMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ArtSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.help = new System.Windows.Forms.ToolStripMenuItem();
            this.ArticleList = new System.Windows.Forms.ListBox();
            this.ArticleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HydrologisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NavigationMenu = new System.Windows.Forms.MenuStrip();
            this.articlesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ArtEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.ArtNew = new System.Windows.Forms.ToolStripMenuItem();
            this.ArtDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.testsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GeneralMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ArticleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HydrologisBindingSource)).BeginInit();
            this.LoginPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.NavigationMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // GeneralMenu
            // 
            this.GeneralMenu.BackColor = System.Drawing.Color.DarkGreen;
            this.GeneralMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.ArtSearch,
            this.help});
            this.GeneralMenu.Location = new System.Drawing.Point(0, 0);
            this.GeneralMenu.Name = "GeneralMenu";
            this.GeneralMenu.Size = new System.Drawing.Size(784, 24);
            this.GeneralMenu.TabIndex = 0;
            this.GeneralMenu.Text = "menuStrip1";
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
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.loadToolStripMenuItem.Text = "Загрузить";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.LoadToolStripMenuItem_Click);
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
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
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
            this.help.Click += new System.EventHandler(this.Help_Click);
            // 
            // ArticleList
            // 
            this.ArticleList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ArticleList.BackColor = System.Drawing.Color.LawnGreen;
            this.ArticleList.DataSource = this.ArticleBindingSource;
            this.ArticleList.DisplayMember = "Name";
            this.ArticleList.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ArticleList.FormattingEnabled = true;
            this.ArticleList.ItemHeight = 20;
            this.ArticleList.Location = new System.Drawing.Point(122, 102);
            this.ArticleList.Name = "ArticleList";
            this.ArticleList.Size = new System.Drawing.Size(655, 304);
            this.ArticleList.Sorted = true;
            this.ArticleList.TabIndex = 1;
            this.ArticleList.DoubleClick += new System.EventHandler(this.ArticleList_DoubleClick);
            // 
            // ArticleBindingSource
            // 
            this.ArticleBindingSource.DataMember = "Articles";
            this.ArticleBindingSource.DataSource = this.HydrologisBindingSource;
            // 
            // HydrologisBindingSource
            // 
            this.HydrologisBindingSource.DataSource = typeof(Hydrologist.models.HydrologistGuide);
            // 
            // LoginPanel
            // 
            this.LoginPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginPanel.BackColor = System.Drawing.Color.DarkGreen;
            this.LoginPanel.Controls.Add(this.label1);
            this.LoginPanel.Location = new System.Drawing.Point(122, 27);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(655, 69);
            this.LoginPanel.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LawnGreen;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 33);
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
            this.panel2.Size = new System.Drawing.Size(116, 69);
            this.panel2.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(3, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 34);
            this.label2.TabIndex = 0;
            this.label2.Text = "Навигация \r\nпо разделам";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.DarkGreen;
            this.panel1.Controls.Add(this.NavigationMenu);
            this.panel1.Location = new System.Drawing.Point(0, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(116, 307);
            this.panel1.TabIndex = 10;
            // 
            // NavigationMenu
            // 
            this.NavigationMenu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NavigationMenu.BackColor = System.Drawing.Color.PaleGreen;
            this.NavigationMenu.Dock = System.Windows.Forms.DockStyle.None;
            this.NavigationMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.articlesToolStripMenuItem,
            this.testsToolStripMenuItem});
            this.NavigationMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.NavigationMenu.Location = new System.Drawing.Point(0, 0);
            this.NavigationMenu.Name = "NavigationMenu";
            this.NavigationMenu.Size = new System.Drawing.Size(83, 64);
            this.NavigationMenu.TabIndex = 0;
            this.NavigationMenu.Text = "menuStrip2";
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
            this.articlesToolStripMenuItem.Size = new System.Drawing.Size(76, 29);
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
            this.testsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.testsToolStripMenuItem.Name = "testsToolStripMenuItem";
            this.testsToolStripMenuItem.Size = new System.Drawing.Size(76, 29);
            this.testsToolStripMenuItem.Text = "Тесты";
            this.testsToolStripMenuItem.Click += new System.EventHandler(this.TestsToolStripMenuItem_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.LoginPanel);
            this.Controls.Add(this.ArticleList);
            this.Controls.Add(this.GeneralMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.GeneralMenu;
            this.MinimumSize = new System.Drawing.Size(400, 225);
            this.Name = "HomeForm";
            this.Text = "Справочник гидролога";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HomeForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HomeForm_FormClosed);
            this.GeneralMenu.ResumeLayout(false);
            this.GeneralMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ArticleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HydrologisBindingSource)).EndInit();
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.NavigationMenu.ResumeLayout(false);
            this.NavigationMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip GeneralMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ListBox ArticleList;
        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem help;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripMenuItem ArtSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip NavigationMenu;
        private System.Windows.Forms.ToolStripMenuItem articlesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ArtEdit;
        private System.Windows.Forms.ToolStripMenuItem ArtNew;
        private System.Windows.Forms.ToolStripMenuItem ArtDelete;
        private System.Windows.Forms.ToolStripMenuItem testsToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource ArticleBindingSource;
        private System.Windows.Forms.BindingSource HydrologisBindingSource;
    }
}