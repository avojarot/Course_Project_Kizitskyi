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
            this.articlesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ArtEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.ArtNew = new System.Windows.Forms.ToolStripMenuItem();
            this.ArtDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.ArtSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.testsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TestEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.TestNew = new System.Windows.Forms.ToolStripMenuItem();
            this.TestDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.TestSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.ArticleList = new System.Windows.Forms.ListBox();
            this.articlesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hydrologistGuideBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.articlesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hydrologistGuideBindingSource)).BeginInit();
            this.LoginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.articlesToolStripMenuItem,
            this.testsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(97, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // articlesToolStripMenuItem
            // 
            this.articlesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ArtEdit,
            this.ArtNew,
            this.ArtDelete,
            this.ArtSearch});
            this.articlesToolStripMenuItem.Name = "articlesToolStripMenuItem";
            this.articlesToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.articlesToolStripMenuItem.Text = "Articles";
            // 
            // ArtEdit
            // 
            this.ArtEdit.Name = "ArtEdit";
            this.ArtEdit.Size = new System.Drawing.Size(109, 22);
            this.ArtEdit.Text = "Edit";
            this.ArtEdit.Click += new System.EventHandler(this.ArtEdit_Click);
            // 
            // ArtNew
            // 
            this.ArtNew.Name = "ArtNew";
            this.ArtNew.Size = new System.Drawing.Size(109, 22);
            this.ArtNew.Text = "New";
            this.ArtNew.Click += new System.EventHandler(this.ArtNew_Click);
            // 
            // ArtDelete
            // 
            this.ArtDelete.Name = "ArtDelete";
            this.ArtDelete.Size = new System.Drawing.Size(109, 22);
            this.ArtDelete.Text = "Delete";
            this.ArtDelete.Click += new System.EventHandler(this.ArtDelete_Click);
            // 
            // ArtSearch
            // 
            this.ArtSearch.Name = "ArtSearch";
            this.ArtSearch.Size = new System.Drawing.Size(109, 22);
            this.ArtSearch.Text = "Search";
            // 
            // testsToolStripMenuItem
            // 
            this.testsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TestEdit,
            this.TestNew,
            this.TestDelete,
            this.TestSearch});
            this.testsToolStripMenuItem.Name = "testsToolStripMenuItem";
            this.testsToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.testsToolStripMenuItem.Text = "Tests";
            // 
            // TestEdit
            // 
            this.TestEdit.Name = "TestEdit";
            this.TestEdit.Size = new System.Drawing.Size(109, 22);
            this.TestEdit.Text = "Edit";
            // 
            // TestNew
            // 
            this.TestNew.Name = "TestNew";
            this.TestNew.Size = new System.Drawing.Size(109, 22);
            this.TestNew.Text = "New";
            // 
            // TestDelete
            // 
            this.TestDelete.Name = "TestDelete";
            this.TestDelete.Size = new System.Drawing.Size(109, 22);
            this.TestDelete.Text = "Delete";
            // 
            // TestSearch
            // 
            this.TestSearch.Name = "TestSearch";
            this.TestSearch.Size = new System.Drawing.Size(109, 22);
            this.TestSearch.Text = "Search";
            // 
            // ArticleList
            // 
            this.ArticleList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ArticleList.DataSource = this.articlesBindingSource;
            this.ArticleList.DisplayMember = "Name";
            this.ArticleList.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ArticleList.FormattingEnabled = true;
            this.ArticleList.ItemHeight = 20;
            this.ArticleList.Location = new System.Drawing.Point(12, 102);
            this.ArticleList.Name = "ArticleList";
            this.ArticleList.Size = new System.Drawing.Size(776, 324);
            this.ArticleList.Sorted = true;
            this.ArticleList.TabIndex = 1;
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
            this.LoginPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.LoginPanel.Controls.Add(this.label1);
            this.LoginPanel.Location = new System.Drawing.Point(12, 39);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(776, 57);
            this.LoginPanel.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(440, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Все существующие статьи про водные объекты";
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LoginPanel);
            this.Controls.Add(this.ArticleList);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HomeForm";
            this.Text = "Справочник гидролога";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HomeForm_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.articlesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hydrologistGuideBindingSource)).EndInit();
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem articlesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ArtEdit;
        private System.Windows.Forms.ToolStripMenuItem ArtNew;
        private System.Windows.Forms.ToolStripMenuItem ArtDelete;
        private System.Windows.Forms.ToolStripMenuItem testsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TestEdit;
        private System.Windows.Forms.ToolStripMenuItem TestNew;
        private System.Windows.Forms.ToolStripMenuItem TestDelete;
        private System.Windows.Forms.ListBox ArticleList;
        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem ArtSearch;
        private System.Windows.Forms.ToolStripMenuItem TestSearch;
        private System.Windows.Forms.BindingSource articlesBindingSource;
        private System.Windows.Forms.BindingSource hydrologistGuideBindingSource;
    }
}