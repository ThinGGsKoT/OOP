namespace Ind_Zadanie
{
    partial class ReadEntering
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
            this.Registation_button = new System.Windows.Forms.Button();
            this.Enter_button = new System.Windows.Forms.Button();
            this.Back_button = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Number = new System.Windows.Forms.TextBox();
            this.textBox_tName = new System.Windows.Forms.TextBox();
            this.textBox_fName = new System.Windows.Forms.TextBox();
            this.textBox_sName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Registation_button
            // 
            this.Registation_button.Location = new System.Drawing.Point(7, 173);
            this.Registation_button.Name = "Registation_button";
            this.Registation_button.Size = new System.Drawing.Size(102, 23);
            this.Registation_button.TabIndex = 0;
            this.Registation_button.Text = "Регистрация";
            this.Registation_button.UseVisualStyleBackColor = true;
            this.Registation_button.Click += new System.EventHandler(this.Registation_button_Click);
            // 
            // Enter_button
            // 
            this.Enter_button.Enabled = false;
            this.Enter_button.Location = new System.Drawing.Point(174, 173);
            this.Enter_button.Name = "Enter_button";
            this.Enter_button.Size = new System.Drawing.Size(112, 23);
            this.Enter_button.TabIndex = 1;
            this.Enter_button.Text = "Войти";
            this.Enter_button.UseVisualStyleBackColor = true;
            this.Enter_button.Click += new System.EventHandler(this.Enter_button_Click);
            // 
            // Back_button
            // 
            this.Back_button.Location = new System.Drawing.Point(263, 12);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(50, 22);
            this.Back_button.TabIndex = 17;
            this.Back_button.Text = "Назад";
            this.Back_button.UseVisualStyleBackColor = true;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CausesValidation = false;
            this.dateTimePicker1.CustomFormat = "\"dd.MM.yyyy\"";
            this.dateTimePicker1.Location = new System.Drawing.Point(112, 91);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(142, 20);
            this.dateTimePicker1.TabIndex = 27;
            this.dateTimePicker1.TabStop = false;
            this.dateTimePicker1.Value = new System.DateTime(2000, 1, 1, 0, 1, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Номер телефона";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Дата рождения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Отчество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Имя";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Фамилия";
            // 
            // textBox_Number
            // 
            this.textBox_Number.Location = new System.Drawing.Point(112, 117);
            this.textBox_Number.Name = "textBox_Number";
            this.textBox_Number.Size = new System.Drawing.Size(142, 20);
            this.textBox_Number.TabIndex = 21;
            // 
            // textBox_tName
            // 
            this.textBox_tName.Location = new System.Drawing.Point(112, 65);
            this.textBox_tName.Name = "textBox_tName";
            this.textBox_tName.Size = new System.Drawing.Size(174, 20);
            this.textBox_tName.TabIndex = 20;
            // 
            // textBox_fName
            // 
            this.textBox_fName.Location = new System.Drawing.Point(112, 39);
            this.textBox_fName.Name = "textBox_fName";
            this.textBox_fName.Size = new System.Drawing.Size(132, 20);
            this.textBox_fName.TabIndex = 19;
            // 
            // textBox_sName
            // 
            this.textBox_sName.Location = new System.Drawing.Point(112, 13);
            this.textBox_sName.Name = "textBox_sName";
            this.textBox_sName.Size = new System.Drawing.Size(132, 20);
            this.textBox_sName.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(112, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Все поля обязательны для ввода!";
            // 
            // ReadEntering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 220);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Number);
            this.Controls.Add(this.textBox_tName);
            this.Controls.Add(this.textBox_fName);
            this.Controls.Add(this.textBox_sName);
            this.Controls.Add(this.Back_button);
            this.Controls.Add(this.Enter_button);
            this.Controls.Add(this.Registation_button);
            this.Name = "ReadEntering";
            this.Text = "ReadEntering";
            this.Load += new System.EventHandler(this.ReadEntering_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Registation_button;
        private System.Windows.Forms.Button Enter_button;
        private System.Windows.Forms.Button Back_button;
        protected internal System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Number;
        private System.Windows.Forms.TextBox textBox_tName;
        private System.Windows.Forms.TextBox textBox_fName;
        private System.Windows.Forms.TextBox textBox_sName;
        private System.Windows.Forms.Label label6;
    }
}