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
            this.OPTIONS = new System.Windows.Forms.ListBox();
            this.answerOptionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Qtext = new System.Windows.Forms.TextBox();
            this.END = new System.Windows.Forms.Button();
            this.NEXT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.answerOptionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // OPTIONS
            // 
            this.OPTIONS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OPTIONS.DataSource = this.answerOptionsBindingSource;
            this.OPTIONS.DisplayMember = "Value";
            this.OPTIONS.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OPTIONS.FormattingEnabled = true;
            this.OPTIONS.ItemHeight = 25;
            this.OPTIONS.Location = new System.Drawing.Point(12, 166);
            this.OPTIONS.MaximumSize = new System.Drawing.Size(660, 154);
            this.OPTIONS.MinimumSize = new System.Drawing.Size(660, 154);
            this.OPTIONS.Name = "OPTIONS";
            this.OPTIONS.Size = new System.Drawing.Size(660, 154);
            this.OPTIONS.TabIndex = 0;
            this.OPTIONS.TabStop = false;
            this.OPTIONS.ValueMember = "Value";
            this.OPTIONS.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListBox1_MouseClick);
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
            // Qtext
            // 
            this.Qtext.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Qtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Qtext.Location = new System.Drawing.Point(12, 52);
            this.Qtext.Multiline = true;
            this.Qtext.Name = "Qtext";
            this.Qtext.ReadOnly = true;
            this.Qtext.Size = new System.Drawing.Size(660, 97);
            this.Qtext.TabIndex = 1;
            this.Qtext.TabStop = false;
            this.Qtext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // END
            // 
            this.END.Location = new System.Drawing.Point(12, 12);
            this.END.Name = "END";
            this.END.Size = new System.Drawing.Size(100, 34);
            this.END.TabIndex = 2;
            this.END.Text = "Завершить тест \r\nдосрочно";
            this.END.UseVisualStyleBackColor = true;
            this.END.Click += new System.EventHandler(this.END_Click);
            // 
            // NEXT
            // 
            this.NEXT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NEXT.Location = new System.Drawing.Point(568, 11);
            this.NEXT.Name = "NEXT";
            this.NEXT.Size = new System.Drawing.Size(104, 35);
            this.NEXT.TabIndex = 3;
            this.NEXT.Text = "Пропустить \r\nвопрос";
            this.NEXT.UseVisualStyleBackColor = true;
            this.NEXT.Click += new System.EventHandler(this.NEXT_Click);
            // 
            // TestingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 341);
            this.Controls.Add(this.NEXT);
            this.Controls.Add(this.END);
            this.Controls.Add(this.Qtext);
            this.Controls.Add(this.OPTIONS);
            this.MaximumSize = new System.Drawing.Size(700, 380);
            this.MinimumSize = new System.Drawing.Size(700, 380);
            this.Name = "TestingForm";
            this.Text = "Справочник гидролога";
            ((System.ComponentModel.ISupportInitialize)(this.answerOptionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox OPTIONS;
        private System.Windows.Forms.TextBox Qtext;
        private System.Windows.Forms.Button END;
        private System.Windows.Forms.Button NEXT;
        private System.Windows.Forms.BindingSource answerOptionsBindingSource;
        private System.Windows.Forms.BindingSource testBindingSource;
    }
}