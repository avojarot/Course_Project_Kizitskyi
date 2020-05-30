namespace AdminApp
{
    partial class TestingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestingForm));
            this.OptionsLIst = new System.Windows.Forms.ListBox();
            this.answerOptionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QuestionBox = new System.Windows.Forms.TextBox();
            this.EndButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.answerOptionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // OptionsLIst
            // 
            this.OptionsLIst.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OptionsLIst.DataSource = this.answerOptionsBindingSource;
            this.OptionsLIst.DisplayMember = "Value";
            this.OptionsLIst.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OptionsLIst.FormattingEnabled = true;
            this.OptionsLIst.ItemHeight = 25;
            this.OptionsLIst.Location = new System.Drawing.Point(12, 136);
            this.OptionsLIst.Name = "OptionsLIst";
            this.OptionsLIst.ScrollAlwaysVisible = true;
            this.OptionsLIst.Size = new System.Drawing.Size(660, 154);
            this.OptionsLIst.TabIndex = 0;
            this.OptionsLIst.TabStop = false;
            this.OptionsLIst.ValueMember = "Value";
            this.OptionsLIst.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListBox1_MouseClick);
            // 
            // answerOptionsBindingSource
            // 
            this.answerOptionsBindingSource.DataMember = "AnswerOptions";
            this.answerOptionsBindingSource.DataSource = this.testBindingSource;
            // 
            // testBindingSource
            // 
            this.testBindingSource.DataMember = "Questions";
            this.testBindingSource.DataSource = typeof(Hydrologist.models.Test);
            // 
            // QuestionBox
            // 
            this.QuestionBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QuestionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuestionBox.Location = new System.Drawing.Point(15, 3);
            this.QuestionBox.Multiline = true;
            this.QuestionBox.Name = "QuestionBox";
            this.QuestionBox.ReadOnly = true;
            this.QuestionBox.Size = new System.Drawing.Size(622, 65);
            this.QuestionBox.TabIndex = 1;
            this.QuestionBox.TabStop = false;
            this.QuestionBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EndButton
            // 
            this.EndButton.Location = new System.Drawing.Point(3, 3);
            this.EndButton.Name = "EndButton";
            this.EndButton.Size = new System.Drawing.Size(100, 34);
            this.EndButton.TabIndex = 2;
            this.EndButton.Text = "Завершить тест \r\nдосрочно";
            this.EndButton.UseVisualStyleBackColor = true;
            this.EndButton.Click += new System.EventHandler(this.END_Click);
            // 
            // NextButton
            // 
            this.NextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NextButton.Location = new System.Drawing.Point(553, 3);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(104, 35);
            this.NextButton.TabIndex = 3;
            this.NextButton.Text = "Пропустить \r\nвопрос";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NEXT_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.QuestionBox);
            this.panel1.Location = new System.Drawing.Point(3, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(647, 78);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.EndButton);
            this.panel2.Controls.Add(this.NextButton);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(12, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(660, 123);
            this.panel2.TabIndex = 5;
            // 
            // TestingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 302);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.OptionsLIst);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(300, 220);
            this.Name = "TestingForm";
            this.Text = "Справочник гидролога";
            ((System.ComponentModel.ISupportInitialize)(this.answerOptionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox OptionsLIst;
        private System.Windows.Forms.TextBox QuestionBox;
        private System.Windows.Forms.Button EndButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.BindingSource answerOptionsBindingSource;
        private System.Windows.Forms.BindingSource testBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}