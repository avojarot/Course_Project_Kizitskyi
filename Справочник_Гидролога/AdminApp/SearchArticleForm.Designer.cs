namespace AdminApp
{
    partial class SearchArticleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchArticleForm));
            this.NameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TypeCbox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RegionCbox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DepthMinNumber = new System.Windows.Forms.NumericUpDown();
            this.DepthMaxNumber = new System.Windows.Forms.NumericUpDown();
            this.AreaMinNumber = new System.Windows.Forms.NumericUpDown();
            this.AreaMaxNumber = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DepthMinNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepthMaxNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AreaMinNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AreaMaxNumber)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(74, 42);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(121, 20);
            this.NameBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(11, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Название";
            // 
            // TypeCbox
            // 
            this.TypeCbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TypeCbox.FormattingEnabled = true;
            this.TypeCbox.Items.AddRange(new object[] {
            "Река",
            "Водохранилище",
            "Озеро",
            "Болото",
            "Море",
            "Пролив",
            "Залив",
            "Океан"});
            this.TypeCbox.Location = new System.Drawing.Point(252, 39);
            this.TypeCbox.Name = "TypeCbox";
            this.TypeCbox.Size = new System.Drawing.Size(121, 21);
            this.TypeCbox.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Location = new System.Drawing.Point(220, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Тип";
            // 
            // RegionCbox
            // 
            this.RegionCbox.FormattingEnabled = true;
            this.RegionCbox.Items.AddRange(new object[] {
            "Европа",
            "Азия",
            "Африка",
            "Северная Америка",
            "Южная Америка",
            "Австралия",
            "-"});
            this.RegionCbox.Location = new System.Drawing.Point(75, 72);
            this.RegionCbox.Name = "RegionCbox";
            this.RegionCbox.Size = new System.Drawing.Size(121, 21);
            this.RegionCbox.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Регион";
            // 
            // DepthMinNumber
            // 
            this.DepthMinNumber.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DepthMinNumber.Location = new System.Drawing.Point(75, 127);
            this.DepthMinNumber.Maximum = new decimal(new int[] {
            12000,
            0,
            0,
            0});
            this.DepthMinNumber.Name = "DepthMinNumber";
            this.DepthMinNumber.Size = new System.Drawing.Size(120, 20);
            this.DepthMinNumber.TabIndex = 22;
            // 
            // DepthMaxNumber
            // 
            this.DepthMaxNumber.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.DepthMaxNumber.Location = new System.Drawing.Point(252, 127);
            this.DepthMaxNumber.Maximum = new decimal(new int[] {
            12000,
            0,
            0,
            0});
            this.DepthMaxNumber.Name = "DepthMaxNumber";
            this.DepthMaxNumber.Size = new System.Drawing.Size(120, 20);
            this.DepthMaxNumber.TabIndex = 23;
            this.DepthMaxNumber.Value = new decimal(new int[] {
            12000,
            0,
            0,
            0});
            // 
            // AreaMinNumber
            // 
            this.AreaMinNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AreaMinNumber.Location = new System.Drawing.Point(76, 180);
            this.AreaMinNumber.Maximum = new decimal(new int[] {
            200000000,
            0,
            0,
            0});
            this.AreaMinNumber.Name = "AreaMinNumber";
            this.AreaMinNumber.Size = new System.Drawing.Size(120, 20);
            this.AreaMinNumber.TabIndex = 24;
            // 
            // AreaMaxNumber
            // 
            this.AreaMaxNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AreaMaxNumber.Location = new System.Drawing.Point(252, 180);
            this.AreaMaxNumber.Maximum = new decimal(new int[] {
            200000000,
            0,
            0,
            0});
            this.AreaMaxNumber.Name = "AreaMaxNumber";
            this.AreaMaxNumber.Size = new System.Drawing.Size(120, 20);
            this.AreaMaxNumber.TabIndex = 25;
            this.AreaMaxNumber.Value = new decimal(new int[] {
            200000000,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label4.Location = new System.Drawing.Point(12, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Глубина, м";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label5.Location = new System.Drawing.Point(21, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Площадь, км^2";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label6.Location = new System.Drawing.Point(21, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "От";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label7.Location = new System.Drawing.Point(218, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "До";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label8.Location = new System.Drawing.Point(21, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "От";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label9.Location = new System.Drawing.Point(218, 186);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "До";
            // 
            // SearchButton
            // 
            this.SearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchButton.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.SearchButton.Location = new System.Drawing.Point(183, 226);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 32;
            this.SearchButton.Text = "Поиск";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.Search_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ResetButton.DialogResult = System.Windows.Forms.DialogResult.No;
            this.ResetButton.Location = new System.Drawing.Point(297, 226);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 33;
            this.ResetButton.Text = "Сбросить";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.Reset_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(-2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 33);
            this.panel1.TabIndex = 34;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(8, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 22);
            this.label10.TabIndex = 0;
            this.label10.Text = "Поиск";
            // 
            // SearchForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AreaMaxNumber);
            this.Controls.Add(this.AreaMinNumber);
            this.Controls.Add(this.DepthMaxNumber);
            this.Controls.Add(this.DepthMinNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RegionCbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TypeCbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(400, 300);
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "SearchForm1";
            this.Text = "Справочник гидролога";
            ((System.ComponentModel.ISupportInitialize)(this.DepthMinNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepthMaxNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AreaMinNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AreaMaxNumber)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox TypeCbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox RegionCbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown DepthMinNumber;
        private System.Windows.Forms.NumericUpDown DepthMaxNumber;
        private System.Windows.Forms.NumericUpDown AreaMinNumber;
        private System.Windows.Forms.NumericUpDown AreaMaxNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
    }
}