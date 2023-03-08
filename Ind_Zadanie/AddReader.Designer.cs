namespace Ind_Zadanie
{
    partial class AddReader
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
            this.textBox_sName = new System.Windows.Forms.TextBox();
            this.textBox_fName = new System.Windows.Forms.TextBox();
            this.textBox_tName = new System.Windows.Forms.TextBox();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.textBox_Number = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AddReader_button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.ChangeReader_button = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Load_button = new System.Windows.Forms.Button();
            this.Save_button = new System.Windows.Forms.Button();
            this.ReaderStatus_button = new System.Windows.Forms.Button();
            this.Back_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_sName
            // 
            this.textBox_sName.Location = new System.Drawing.Point(29, 39);
            this.textBox_sName.Name = "textBox_sName";
            this.textBox_sName.Size = new System.Drawing.Size(132, 20);
            this.textBox_sName.TabIndex = 0;
            // 
            // textBox_fName
            // 
            this.textBox_fName.Location = new System.Drawing.Point(167, 39);
            this.textBox_fName.Name = "textBox_fName";
            this.textBox_fName.Size = new System.Drawing.Size(132, 20);
            this.textBox_fName.TabIndex = 1;
            // 
            // textBox_tName
            // 
            this.textBox_tName.Location = new System.Drawing.Point(305, 39);
            this.textBox_tName.Name = "textBox_tName";
            this.textBox_tName.Size = new System.Drawing.Size(174, 20);
            this.textBox_tName.TabIndex = 2;
            // 
            // textBox_ID
            // 
            this.textBox_ID.Location = new System.Drawing.Point(199, 159);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(100, 20);
            this.textBox_ID.TabIndex = 3;
            // 
            // textBox_Number
            // 
            this.textBox_Number.Location = new System.Drawing.Point(167, 91);
            this.textBox_Number.Name = "textBox_Number";
            this.textBox_Number.Size = new System.Drawing.Size(142, 20);
            this.textBox_Number.TabIndex = 4;
            this.textBox_Number.TextChanged += new System.EventHandler(this.TextBox5_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Имя";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(302, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Отчество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Дата рождения";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Номер телефона";
            // 
            // AddReader_button
            // 
            this.AddReader_button.Location = new System.Drawing.Point(167, 118);
            this.AddReader_button.Name = "AddReader_button";
            this.AddReader_button.Size = new System.Drawing.Size(132, 23);
            this.AddReader_button.TabIndex = 11;
            this.AddReader_button.Text = "Добавить читателя";
            this.AddReader_button.UseVisualStyleBackColor = true;
            this.AddReader_button.Click += new System.EventHandler(this.AddReader_button_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Номер читательского билета:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CausesValidation = false;
            this.dateTimePicker1.CustomFormat = "\"dd.MM.yyyy\"";
            this.dateTimePicker1.Location = new System.Drawing.Point(167, 68);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(142, 20);
            this.dateTimePicker1.TabIndex = 14;
            this.dateTimePicker1.TabStop = false;
            this.dateTimePicker1.Value = new System.DateTime(2000, 1, 1, 0, 1, 0, 0);
            // 
            // ChangeReader_button
            // 
            this.ChangeReader_button.Location = new System.Drawing.Point(347, 118);
            this.ChangeReader_button.Name = "ChangeReader_button";
            this.ChangeReader_button.Size = new System.Drawing.Size(132, 23);
            this.ChangeReader_button.TabIndex = 15;
            this.ChangeReader_button.Text = "Редактировать";
            this.ChangeReader_button.UseVisualStyleBackColor = true;
            this.ChangeReader_button.Click += new System.EventHandler(this.ChangeReader_button_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(35, 189);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(520, 212);
            this.listBox1.TabIndex = 16;
            // 
            // Load_button
            // 
            this.Load_button.Location = new System.Drawing.Point(78, 415);
            this.Load_button.Name = "Load_button";
            this.Load_button.Size = new System.Drawing.Size(113, 23);
            this.Load_button.TabIndex = 17;
            this.Load_button.Text = "Загрузить";
            this.Load_button.UseVisualStyleBackColor = true;
            this.Load_button.Click += new System.EventHandler(this.Load_button_Click);
            // 
            // Save_button
            // 
            this.Save_button.Location = new System.Drawing.Point(366, 415);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(113, 23);
            this.Save_button.TabIndex = 18;
            this.Save_button.Text = "Сохранить";
            this.Save_button.UseVisualStyleBackColor = true;
            this.Save_button.Click += new System.EventHandler(this.Save_button_Click);
            // 
            // ReaderStatus_button
            // 
            this.ReaderStatus_button.Location = new System.Drawing.Point(305, 156);
            this.ReaderStatus_button.Name = "ReaderStatus_button";
            this.ReaderStatus_button.Size = new System.Drawing.Size(174, 23);
            this.ReaderStatus_button.TabIndex = 19;
            this.ReaderStatus_button.Text = "Просмотреть статус читателя";
            this.ReaderStatus_button.UseVisualStyleBackColor = true;
            this.ReaderStatus_button.Click += new System.EventHandler(this.ReaderStatus_button_Click);
            // 
            // Back_button
            // 
            this.Back_button.Location = new System.Drawing.Point(505, 12);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(50, 22);
            this.Back_button.TabIndex = 21;
            this.Back_button.Text = "Назад";
            this.Back_button.UseVisualStyleBackColor = true;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // AddReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 450);
            this.Controls.Add(this.Back_button);
            this.Controls.Add(this.ReaderStatus_button);
            this.Controls.Add(this.Save_button);
            this.Controls.Add(this.Load_button);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.ChangeReader_button);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AddReader_button);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Number);
            this.Controls.Add(this.textBox_ID);
            this.Controls.Add(this.textBox_tName);
            this.Controls.Add(this.textBox_fName);
            this.Controls.Add(this.textBox_sName);
            this.Name = "AddReader";
            this.Text = "Добавить/редактировать читателя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_sName;
        private System.Windows.Forms.TextBox textBox_fName;
        private System.Windows.Forms.TextBox textBox_tName;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.TextBox textBox_Number;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AddReader_button;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ChangeReader_button;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Load_button;
        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.Button ReaderStatus_button;
        private System.Windows.Forms.Button Back_button;
        protected internal System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

