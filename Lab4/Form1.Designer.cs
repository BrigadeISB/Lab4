namespace Lab4
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.outlistBox1 = new System.Windows.Forms.ListBox();
            this.outlistBox2 = new System.Windows.Forms.ListBox();
            this.outlistBox3 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SetMark = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.SetMark)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(244, 36);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(232, 100);
            this.listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(244, 173);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(232, 100);
            this.listBox2.TabIndex = 1;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 16;
            this.listBox3.Location = new System.Drawing.Point(244, 315);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(232, 100);
            this.listBox3.TabIndex = 2;
            // 
            // outlistBox1
            // 
            this.outlistBox1.FormattingEnabled = true;
            this.outlistBox1.ItemHeight = 16;
            this.outlistBox1.Location = new System.Drawing.Point(655, 36);
            this.outlistBox1.Name = "outlistBox1";
            this.outlistBox1.Size = new System.Drawing.Size(236, 100);
            this.outlistBox1.TabIndex = 3;
            // 
            // outlistBox2
            // 
            this.outlistBox2.FormattingEnabled = true;
            this.outlistBox2.ItemHeight = 16;
            this.outlistBox2.Location = new System.Drawing.Point(655, 173);
            this.outlistBox2.Name = "outlistBox2";
            this.outlistBox2.Size = new System.Drawing.Size(236, 100);
            this.outlistBox2.TabIndex = 4;
            // 
            // outlistBox3
            // 
            this.outlistBox3.FormattingEnabled = true;
            this.outlistBox3.ItemHeight = 16;
            this.outlistBox3.Location = new System.Drawing.Point(655, 315);
            this.outlistBox3.Name = "outlistBox3";
            this.outlistBox3.Size = new System.Drawing.Size(236, 100);
            this.outlistBox3.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(502, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 110);
            this.button1.TabIndex = 6;
            this.button1.Text = "Виставити оцінки";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(502, 249);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 110);
            this.button2.TabIndex = 7;
            this.button2.Text = "Очистити кампус";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(241, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Перевірка групи 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Перевірка групи 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Перевірка групи 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(652, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Оцінки групи 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(652, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Оцінки групи 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(652, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Оцінки групи 3";
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.ItemHeight = 16;
            this.listBox4.Location = new System.Drawing.Point(12, 55);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(213, 244);
            this.listBox4.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Роботи, здані на перевірку";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(15, 375);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(210, 113);
            this.button3.TabIndex = 16;
            this.button3.Text = "Оцінити студента";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // SetMark
            // 
            this.SetMark.Location = new System.Drawing.Point(15, 327);
            this.SetMark.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.SetMark.Name = "SetMark";
            this.SetMark.Size = new System.Drawing.Size(120, 22);
            this.SetMark.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 517);
            this.Controls.Add(this.SetMark);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.outlistBox3);
            this.Controls.Add(this.outlistBox2);
            this.Controls.Add(this.outlistBox1);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.SetMark)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox outlistBox1;
        private System.Windows.Forms.ListBox outlistBox2;
        private System.Windows.Forms.ListBox outlistBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.NumericUpDown SetMark;
    }
}

