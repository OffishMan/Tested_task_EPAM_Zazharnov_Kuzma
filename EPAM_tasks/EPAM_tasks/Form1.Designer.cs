namespace EPAM_tasks
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(554, 340);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox4);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(546, 314);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Task 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(7, 109);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(532, 20);
            this.textBox4.TabIndex = 5;
            this.textBox4.Text = "Результат работы программы:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(7, 7);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(533, 20);
            this.textBox3.TabIndex = 4;
            this.textBox3.Text = "Введите последовательность элементов через пробел или нажмите \"Сгенерировать\"";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 135);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(533, 40);
            this.textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 33);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(534, 40);
            this.textBox1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(108, 79);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Отсортировать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Сгенерировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox10);
            this.tabPage2.Controls.Add(this.textBox9);
            this.tabPage2.Controls.Add(this.textBox8);
            this.tabPage2.Controls.Add(this.textBox7);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.textBox6);
            this.tabPage2.Controls.Add(this.textBox5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(546, 314);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Task 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(311, 83);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(81, 20);
            this.textBox10.TabIndex = 7;
            this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(166, 83);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(139, 20);
            this.textBox9.TabIndex = 6;
            this.textBox9.Text = "Проверить наличие числа";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(7, 138);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(533, 20);
            this.textBox8.TabIndex = 5;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(7, 111);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(533, 20);
            this.textBox7.TabIndex = 4;
            this.textBox7.Text = "Результат работы программы:";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(440, 80);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Выполнить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(7, 81);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Сгенерировать";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(7, 34);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox6.Size = new System.Drawing.Size(533, 40);
            this.textBox6.TabIndex = 1;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(7, 7);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(533, 20);
            this.textBox5.TabIndex = 0;
            this.textBox5.Text = "Введите последовательность элементов через пробел или нажмите \"Сгенерировать\"";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBox14);
            this.tabPage3.Controls.Add(this.button5);
            this.tabPage3.Controls.Add(this.textBox13);
            this.tabPage3.Controls.Add(this.textBox12);
            this.tabPage3.Controls.Add(this.textBox11);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(546, 314);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Task 3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(7, 136);
            this.textBox14.Multiline = true;
            this.textBox14.Name = "textBox14";
            this.textBox14.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox14.Size = new System.Drawing.Size(533, 40);
            this.textBox14.TabIndex = 4;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(7, 80);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 3;
            this.button5.Text = "Выполнить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(7, 109);
            this.textBox13.Name = "textBox13";
            this.textBox13.ReadOnly = true;
            this.textBox13.Size = new System.Drawing.Size(533, 20);
            this.textBox13.TabIndex = 2;
            this.textBox13.Text = "Результат работы программы:";
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(7, 34);
            this.textBox12.Multiline = true;
            this.textBox12.Name = "textBox12";
            this.textBox12.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox12.Size = new System.Drawing.Size(533, 40);
            this.textBox12.TabIndex = 1;
            this.textBox12.Text = "Тестовый текст для проверки третьего задания, кстати, это текст для теста";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(7, 7);
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(533, 20);
            this.textBox11.TabIndex = 0;
            this.textBox11.Text = "Введите строку:";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button6);
            this.tabPage4.Controls.Add(this.textBox17);
            this.tabPage4.Controls.Add(this.textBox16);
            this.tabPage4.Controls.Add(this.textBox15);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(546, 314);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Task 4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(7, 34);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 3;
            this.button6.Text = "Вычислить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(75, 7);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(88, 20);
            this.textBox17.TabIndex = 2;
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(54, 7);
            this.textBox16.Name = "textBox16";
            this.textBox16.ReadOnly = true;
            this.textBox16.Size = new System.Drawing.Size(24, 20);
            this.textBox16.TabIndex = 1;
            this.textBox16.Text = "! =";
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(7, 7);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(50, 20);
            this.textBox15.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.textBox20);
            this.tabPage5.Controls.Add(this.button7);
            this.tabPage5.Controls.Add(this.textBox19);
            this.tabPage5.Controls.Add(this.textBox18);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(546, 314);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Task 5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // textBox20
            // 
            this.textBox20.Location = new System.Drawing.Point(7, 91);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(533, 20);
            this.textBox20.TabIndex = 3;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(7, 61);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 2;
            this.button7.Text = "Выполнить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // textBox19
            // 
            this.textBox19.Location = new System.Drawing.Point(7, 34);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(533, 20);
            this.textBox19.TabIndex = 1;
            this.textBox19.Text = "{([])}";
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(7, 7);
            this.textBox18.Name = "textBox18";
            this.textBox18.ReadOnly = true;
            this.textBox18.Size = new System.Drawing.Size(533, 20);
            this.textBox18.TabIndex = 0;
            this.textBox18.Text = "Введите последовательность скобок:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 364);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.TextBox textBox18;
    }
}

