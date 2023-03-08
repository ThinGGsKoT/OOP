namespace Ind_Zadanie
{
    partial class AddBook
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NameBooktextBox = new System.Windows.Forms.TextBox();
            this.Author_textBox = new System.Windows.Forms.TextBox();
            this.PublicCode_textBox = new System.Windows.Forms.TextBox();
            this.Description_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.AddBook_button = new System.Windows.Forms.Button();
            this.ChangeBook_button = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.BookID_textBox = new System.Windows.Forms.TextBox();
            this.Back_button = new System.Windows.Forms.Button();
            this.Status_button = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Автор:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Код издания:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Описание:";
            // 
            // NameBooktextBox
            // 
            this.NameBooktextBox.Location = new System.Drawing.Point(88, 41);
            this.NameBooktextBox.Name = "NameBooktextBox";
            this.NameBooktextBox.Size = new System.Drawing.Size(227, 20);
            this.NameBooktextBox.TabIndex = 4;
            // 
            // Author_textBox
            // 
            this.Author_textBox.Location = new System.Drawing.Point(88, 83);
            this.Author_textBox.Name = "Author_textBox";
            this.Author_textBox.Size = new System.Drawing.Size(227, 20);
            this.Author_textBox.TabIndex = 5;
            // 
            // PublicCode_textBox
            // 
            this.PublicCode_textBox.Location = new System.Drawing.Point(88, 126);
            this.PublicCode_textBox.Name = "PublicCode_textBox";
            this.PublicCode_textBox.Size = new System.Drawing.Size(227, 20);
            this.PublicCode_textBox.TabIndex = 6;
            // 
            // Description_textBox
            // 
            this.Description_textBox.Location = new System.Drawing.Point(88, 173);
            this.Description_textBox.Name = "Description_textBox";
            this.Description_textBox.Size = new System.Drawing.Size(227, 20);
            this.Description_textBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Статус:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 316);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Очередь:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(88, 293);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(227, 17);
            this.listBox1.TabIndex = 10;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(88, 316);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(227, 121);
            this.listBox2.TabIndex = 11;
            // 
            // AddBook_button
            // 
            this.AddBook_button.Location = new System.Drawing.Point(16, 465);
            this.AddBook_button.Name = "AddBook_button";
            this.AddBook_button.Size = new System.Drawing.Size(119, 23);
            this.AddBook_button.TabIndex = 12;
            this.AddBook_button.Text = "Добавить книгу";
            this.AddBook_button.UseVisualStyleBackColor = true;
            this.AddBook_button.Click += new System.EventHandler(this.AddBook_button_Click);
            // 
            // ChangeBook_button
            // 
            this.ChangeBook_button.Location = new System.Drawing.Point(159, 465);
            this.ChangeBook_button.Name = "ChangeBook_button";
            this.ChangeBook_button.Size = new System.Drawing.Size(137, 23);
            this.ChangeBook_button.TabIndex = 13;
            this.ChangeBook_button.Text = "Редактировать книгу";
            this.ChangeBook_button.UseVisualStyleBackColor = true;
            this.ChangeBook_button.Click += new System.EventHandler(this.ChangeBook_button_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Номер в каталоге:";
            // 
            // BookID_textBox
            // 
            this.BookID_textBox.Location = new System.Drawing.Point(134, 218);
            this.BookID_textBox.Name = "BookID_textBox";
            this.BookID_textBox.Size = new System.Drawing.Size(181, 20);
            this.BookID_textBox.TabIndex = 15;
            // 
            // Back_button
            // 
            this.Back_button.Location = new System.Drawing.Point(284, 12);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(50, 22);
            this.Back_button.TabIndex = 16;
            this.Back_button.Text = "Назад";
            this.Back_button.UseVisualStyleBackColor = true;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // Status_button
            // 
            this.Status_button.Location = new System.Drawing.Point(12, 264);
            this.Status_button.Name = "Status_button";
            this.Status_button.Size = new System.Drawing.Size(149, 23);
            this.Status_button.TabIndex = 17;
            this.Status_button.Text = "Смотреть статус книги";
            this.Status_button.UseVisualStyleBackColor = true;
            this.Status_button.Click += new System.EventHandler(this.Status_Button_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(167, 269);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "- Введите ID книги выше";
            // 
            // AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 504);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Status_button);
            this.Controls.Add(this.Back_button);
            this.Controls.Add(this.BookID_textBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ChangeBook_button);
            this.Controls.Add(this.AddBook_button);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Description_textBox);
            this.Controls.Add(this.PublicCode_textBox);
            this.Controls.Add(this.Author_textBox);
            this.Controls.Add(this.NameBooktextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddBook";
            this.Text = "Добавить/редактировать книгу";
            this.Load += new System.EventHandler(this.AddBook_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NameBooktextBox;
        private System.Windows.Forms.TextBox Author_textBox;
        private System.Windows.Forms.TextBox PublicCode_textBox;
        private System.Windows.Forms.TextBox Description_textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button AddBook_button;
        private System.Windows.Forms.Button ChangeBook_button;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox BookID_textBox;
        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.Button Status_button;
        private System.Windows.Forms.Label label8;
    }
}