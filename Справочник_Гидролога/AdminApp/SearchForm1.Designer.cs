namespace AdminApp
{
    partial class SearchForm1
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
            this.NameA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Type = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Region1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DepthMin = new System.Windows.Forms.NumericUpDown();
            this.DepthMax = new System.Windows.Forms.NumericUpDown();
            this.AreaMin = new System.Windows.Forms.NumericUpDown();
            this.AreaMax = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DepthMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepthMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AreaMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AreaMax)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameA
            // 
            this.NameA.Location = new System.Drawing.Point(74, 42);
            this.NameA.Name = "NameA";
            this.NameA.Size = new System.Drawing.Size(121, 20);
            this.NameA.TabIndex = 2;
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
            // Type
            // 
            this.Type.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Type.FormattingEnabled = true;
            this.Type.Items.AddRange(new object[] {
            "Река",
            "Водохранилище",
            "Озеро",
            "Болото",
            "Море",
            "Пролив",
            "Залив",
            "Океан"});
            this.Type.Location = new System.Drawing.Point(252, 39);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(121, 21);
            this.Type.TabIndex = 18;
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
            // Region1
            // 
            this.Region1.FormattingEnabled = true;
            this.Region1.Items.AddRange(new object[] {
            "Европа",
            "Азия",
            "Африка",
            "Северная Америка",
            "Южная Америка",
            "Австралия",
            "-"});
            this.Region1.Location = new System.Drawing.Point(75, 72);
            this.Region1.Name = "Region1";
            this.Region1.Size = new System.Drawing.Size(121, 21);
            this.Region1.TabIndex = 20;
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
            // DepthMin
            // 
            this.DepthMin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DepthMin.Location = new System.Drawing.Point(75, 127);
            this.DepthMin.Maximum = new decimal(new int[] {
            12000,
            0,
            0,
            0});
            this.DepthMin.Name = "DepthMin";
            this.DepthMin.Size = new System.Drawing.Size(120, 20);
            this.DepthMin.TabIndex = 22;
            // 
            // DepthMax
            // 
            this.DepthMax.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.DepthMax.Location = new System.Drawing.Point(252, 127);
            this.DepthMax.Maximum = new decimal(new int[] {
            12000,
            0,
            0,
            0});
            this.DepthMax.Name = "DepthMax";
            this.DepthMax.Size = new System.Drawing.Size(120, 20);
            this.DepthMax.TabIndex = 23;
            this.DepthMax.Value = new decimal(new int[] {
            12000,
            0,
            0,
            0});
            // 
            // AreaMin
            // 
            this.AreaMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AreaMin.Location = new System.Drawing.Point(76, 180);
            this.AreaMin.Maximum = new decimal(new int[] {
            200000000,
            0,
            0,
            0});
            this.AreaMin.Name = "AreaMin";
            this.AreaMin.Size = new System.Drawing.Size(120, 20);
            this.AreaMin.TabIndex = 24;
            // 
            // AreaMax
            // 
            this.AreaMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AreaMax.Location = new System.Drawing.Point(252, 180);
            this.AreaMax.Maximum = new decimal(new int[] {
            200000000,
            0,
            0,
            0});
            this.AreaMax.Name = "AreaMax";
            this.AreaMax.Size = new System.Drawing.Size(120, 20);
            this.AreaMax.TabIndex = 25;
            this.AreaMax.Value = new decimal(new int[] {
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
            // Search
            // 
            this.Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Search.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.Search.Location = new System.Drawing.Point(183, 226);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 23);
            this.Search.TabIndex = 32;
            this.Search.Text = "Поиск";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Reset
            // 
            this.Reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Reset.DialogResult = System.Windows.Forms.DialogResult.No;
            this.Reset.Location = new System.Drawing.Point(297, 226);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(75, 23);
            this.Reset.TabIndex = 33;
            this.Reset.Text = "Сбросить";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
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
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AreaMax);
            this.Controls.Add(this.AreaMin);
            this.Controls.Add(this.DepthMax);
            this.Controls.Add(this.DepthMin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Region1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameA);
            this.MaximumSize = new System.Drawing.Size(400, 300);
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "SearchForm1";
            this.Text = "Справочник гидролога";
            ((System.ComponentModel.ISupportInitialize)(this.DepthMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepthMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AreaMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AreaMax)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Type;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Region1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown DepthMin;
        private System.Windows.Forms.NumericUpDown DepthMax;
        private System.Windows.Forms.NumericUpDown AreaMin;
        private System.Windows.Forms.NumericUpDown AreaMax;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
    }
}