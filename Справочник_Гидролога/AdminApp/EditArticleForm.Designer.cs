namespace AdminApp
{
    partial class EditArticleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditArticleForm));
            this.WaterImage = new System.Windows.Forms.PictureBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.EditionalBox = new System.Windows.Forms.TextBox();
            this.AreaNumber = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CanselButton = new System.Windows.Forms.Button();
            this.RegionCbox = new System.Windows.Forms.ComboBox();
            this.TypeCbox = new System.Windows.Forms.ComboBox();
            this.DepthNumber = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.WaterImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AreaNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepthNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // WaterImage
            // 
            this.WaterImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WaterImage.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.WaterImage.Location = new System.Drawing.Point(240, 76);
            this.WaterImage.Name = "WaterImage";
            this.WaterImage.Size = new System.Drawing.Size(132, 91);
            this.WaterImage.TabIndex = 0;
            this.WaterImage.TabStop = false;
            this.WaterImage.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // NameBox
            // 
            this.NameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.NameBox.Location = new System.Drawing.Point(72, 14);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(121, 20);
            this.NameBox.TabIndex = 1;
            // 
            // EditionalBox
            // 
            this.EditionalBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.EditionalBox.Location = new System.Drawing.Point(72, 138);
            this.EditionalBox.Multiline = true;
            this.EditionalBox.Name = "EditionalBox";
            this.EditionalBox.Size = new System.Drawing.Size(120, 50);
            this.EditionalBox.TabIndex = 5;
            // 
            // AreaNumber
            // 
            this.AreaNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AreaNumber.Location = new System.Drawing.Point(261, 12);
            this.AreaNumber.Maximum = new decimal(new int[] {
            200000000,
            0,
            0,
            0});
            this.AreaNumber.Name = "AreaNumber";
            this.AreaNumber.Size = new System.Drawing.Size(120, 20);
            this.AreaNumber.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Тип";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.Location = new System.Drawing.Point(12, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Регион";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label4.Location = new System.Drawing.Point(10, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 26);
            this.label4.TabIndex = 10;
            this.label4.Text = "Макс.\r\nглубина,м\r\n";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label5.Location = new System.Drawing.Point(12, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 52);
            this.label5.TabIndex = 11;
            this.label5.Text = "Дополни-\r\nтельная\r\nинфор-\r\nмация";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label6.Location = new System.Drawing.Point(199, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 26);
            this.label6.TabIndex = 12;
            this.label6.Text = "Площадь,\r\nкм^2";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label7.Location = new System.Drawing.Point(210, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Фото";
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SaveButton.Location = new System.Drawing.Point(191, 192);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 14;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // CanselButton
            // 
            this.CanselButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CanselButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CanselButton.Location = new System.Drawing.Point(297, 192);
            this.CanselButton.Name = "CanselButton";
            this.CanselButton.Size = new System.Drawing.Size(75, 23);
            this.CanselButton.TabIndex = 15;
            this.CanselButton.Text = "Закрыть";
            this.CanselButton.UseVisualStyleBackColor = true;
            // 
            // RegionCbox
            // 
            this.RegionCbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.RegionCbox.FormattingEnabled = true;
            this.RegionCbox.Items.AddRange(new object[] {
            "Европа",
            "Азия",
            "Африка",
            "Северная Америка",
            "Южная Америка",
            "Австралия",
            "-"});
            this.RegionCbox.Location = new System.Drawing.Point(72, 75);
            this.RegionCbox.Name = "RegionCbox";
            this.RegionCbox.Size = new System.Drawing.Size(121, 21);
            this.RegionCbox.TabIndex = 16;
            // 
            // TypeCbox
            // 
            this.TypeCbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
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
            this.TypeCbox.Location = new System.Drawing.Point(72, 49);
            this.TypeCbox.Name = "TypeCbox";
            this.TypeCbox.Size = new System.Drawing.Size(121, 21);
            this.TypeCbox.TabIndex = 17;
            this.TypeCbox.SelectedIndexChanged += new System.EventHandler(this.Type_SelectedIndexChanged);
            this.TypeCbox.SelectionChangeCommitted += new System.EventHandler(this.Type_SelectedIndexChanged);
            this.TypeCbox.TextChanged += new System.EventHandler(this.Type_SelectedIndexChanged);
            // 
            // DepthNumber
            // 
            this.DepthNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DepthNumber.Location = new System.Drawing.Point(73, 112);
            this.DepthNumber.Maximum = new decimal(new int[] {
            12000,
            0,
            0,
            0});
            this.DepthNumber.Name = "DepthNumber";
            this.DepthNumber.Size = new System.Drawing.Size(120, 20);
            this.DepthNumber.TabIndex = 18;
            // 
            // EditArticleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(384, 221);
            this.Controls.Add(this.DepthNumber);
            this.Controls.Add(this.TypeCbox);
            this.Controls.Add(this.RegionCbox);
            this.Controls.Add(this.CanselButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AreaNumber);
            this.Controls.Add(this.EditionalBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.WaterImage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(400, 260);
            this.MinimumSize = new System.Drawing.Size(400, 250);
            this.Name = "EditArticleForm";
            this.Text = "Редактирование";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ArticleForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.WaterImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AreaNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepthNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox WaterImage;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox EditionalBox;
        private System.Windows.Forms.NumericUpDown AreaNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CanselButton;
        private System.Windows.Forms.ComboBox RegionCbox;
        private System.Windows.Forms.ComboBox TypeCbox;
        private System.Windows.Forms.NumericUpDown DepthNumber;
    }
}