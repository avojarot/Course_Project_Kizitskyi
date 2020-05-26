namespace AdminApp
{
    partial class THomeForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip22 = new System.Windows.Forms.MenuStrip();
            this.articlesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.TEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.TNew = new System.Windows.Forms.ToolStripMenuItem();
            this.TDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.NTList = new System.Windows.Forms.ListBox();
            this.BST = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip11 = new System.Windows.Forms.MenuStrip();
            this.file = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.Thelp = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip22.SuspendLayout();
            this.panel2.SuspendLayout();
            this.LoginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BST)).BeginInit();
            this.menuStrip11.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.DarkGreen;
            this.panel1.Controls.Add(this.menuStrip22);
            this.panel1.Location = new System.Drawing.Point(0, 154);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(94, 285);
            this.panel1.TabIndex = 15;
            // 
            // menuStrip22
            // 
            this.menuStrip22.BackColor = System.Drawing.Color.PaleGreen;
            this.menuStrip22.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.articlesToolStripMenuItem,
            this.TSM});
            this.menuStrip22.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip22.Location = new System.Drawing.Point(0, 0);
            this.menuStrip22.Name = "menuStrip22";
            this.menuStrip22.Size = new System.Drawing.Size(94, 83);
            this.menuStrip22.TabIndex = 0;
            this.menuStrip22.Text = "menuStrip2";
            // 
            // articlesToolStripMenuItem
            // 
            this.articlesToolStripMenuItem.BackColor = System.Drawing.Color.LawnGreen;
            this.articlesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.articlesToolStripMenuItem.Name = "articlesToolStripMenuItem";
            this.articlesToolStripMenuItem.Size = new System.Drawing.Size(87, 29);
            this.articlesToolStripMenuItem.Text = "Статьи";
            this.articlesToolStripMenuItem.Click += new System.EventHandler(this.articlesToolStripMenuItem_Click);
            // 
            // TSM
            // 
            this.TSM.BackColor = System.Drawing.Color.LawnGreen;
            this.TSM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TEdit,
            this.TNew,
            this.TDelete});
            this.TSM.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.TSM.Name = "TSM";
            this.TSM.Size = new System.Drawing.Size(87, 29);
            this.TSM.Text = "Тесты";
            // 
            // TEdit
            // 
            this.TEdit.Name = "TEdit";
            this.TEdit.Size = new System.Drawing.Size(205, 30);
            this.TEdit.Text = "Редактировать";
            this.TEdit.Click += new System.EventHandler(this.TestEdit_Click);
            // 
            // TNew
            // 
            this.TNew.Name = "TNew";
            this.TNew.Size = new System.Drawing.Size(205, 30);
            this.TNew.Text = "Создать";
            this.TNew.Click += new System.EventHandler(this.TestNew_Click);
            // 
            // TDelete
            // 
            this.TDelete.Name = "TDelete";
            this.TDelete.Size = new System.Drawing.Size(205, 30);
            this.TDelete.Text = "Удалить";
            this.TDelete.Click += new System.EventHandler(this.TestDelete_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGreen;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(0, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(94, 119);
            this.panel2.TabIndex = 14;
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
            // LoginPanel
            // 
            this.LoginPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginPanel.BackColor = System.Drawing.Color.DarkGreen;
            this.LoginPanel.Controls.Add(this.label10);
            this.LoginPanel.Location = new System.Drawing.Point(100, 29);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(688, 69);
            this.LoginPanel.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.LawnGreen;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(27, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(205, 24);
            this.label10.TabIndex = 0;
            this.label10.Text = "Все доступные тесты";
            // 
            // NTList
            // 
            this.NTList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NTList.BackColor = System.Drawing.Color.LawnGreen;
            this.NTList.DataSource = this.BST;
            this.NTList.DisplayMember = "Name";
            this.NTList.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NTList.FormattingEnabled = true;
            this.NTList.ItemHeight = 20;
            this.NTList.Location = new System.Drawing.Point(100, 104);
            this.NTList.Name = "NTList";
            this.NTList.Size = new System.Drawing.Size(688, 344);
            this.NTList.Sorted = true;
            this.NTList.TabIndex = 12;
            this.NTList.DoubleClick += new System.EventHandler(this.NTList_DoubleClick);
            // 
            // BST
            // 
            this.BST.DataMember = "Tests";
            this.BST.DataSource = typeof(Hydrologist.models.HydrologistGuide);
            // 
            // menuStrip11
            // 
            this.menuStrip11.BackColor = System.Drawing.Color.DarkGreen;
            this.menuStrip11.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file,
            this.TSearch,
            this.Thelp});
            this.menuStrip11.Location = new System.Drawing.Point(0, 0);
            this.menuStrip11.Name = "menuStrip11";
            this.menuStrip11.Size = new System.Drawing.Size(800, 24);
            this.menuStrip11.TabIndex = 11;
            this.menuStrip11.Text = "menuStrip1";
            // 
            // file
            // 
            this.file.BackColor = System.Drawing.Color.LawnGreen;
            this.file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.file.Name = "file";
            this.file.Size = new System.Drawing.Size(48, 20);
            this.file.Text = "Файл";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.saveToolStripMenuItem.Text = "Сохранить";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click_1);
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
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click_1);
            // 
            // TSearch
            // 
            this.TSearch.BackColor = System.Drawing.Color.LawnGreen;
            this.TSearch.Name = "TSearch";
            this.TSearch.Size = new System.Drawing.Size(54, 20);
            this.TSearch.Text = "Поиск";
            this.TSearch.Click += new System.EventHandler(this.TSearch_Click);
            // 
            // Thelp
            // 
            this.Thelp.BackColor = System.Drawing.Color.LawnGreen;
            this.Thelp.Name = "Thelp";
            this.Thelp.Size = new System.Drawing.Size(68, 20);
            this.Thelp.Text = "Помощь";
            this.Thelp.Click += new System.EventHandler(this.help_Click_1);
            // 
            // THomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.LoginPanel);
            this.Controls.Add(this.NTList);
            this.Controls.Add(this.menuStrip11);
            this.Name = "THomeForm";
            this.Text = "Справочник гидролога";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TESThomeForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip22.ResumeLayout(false);
            this.menuStrip22.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BST)).EndInit();
            this.menuStrip11.ResumeLayout(false);
            this.menuStrip11.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip22;
        private System.Windows.Forms.ToolStripMenuItem articlesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSM;
        private System.Windows.Forms.ToolStripMenuItem TEdit;
        private System.Windows.Forms.ToolStripMenuItem TNew;
        private System.Windows.Forms.ToolStripMenuItem TDelete;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox NTList;
        private System.Windows.Forms.MenuStrip menuStrip11;
        private System.Windows.Forms.ToolStripMenuItem file;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSearch;
        private System.Windows.Forms.ToolStripMenuItem Thelp;
        private System.Windows.Forms.BindingSource BST;
    }
}