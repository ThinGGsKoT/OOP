namespace Ind_Zadanie
{
    partial class BookList
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Back_button = new System.Windows.Forms.Button();
            this.bookID_textBox = new System.Windows.Forms.TextBox();
            this.bookID_button = new System.Windows.Forms.Button();
            this.Author_textBox = new System.Windows.Forms.TextBox();
            this.Author_button = new System.Windows.Forms.Button();
            this.Name_textBox = new System.Windows.Forms.TextBox();
            this.Namesearch_button = new System.Windows.Forms.Button();
            this.Showall_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(42, 112);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(680, 303);
            this.listBox1.TabIndex = 0;
            // 
            // Back_button
            // 
            this.Back_button.Location = new System.Drawing.Point(738, 12);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(50, 22);
            this.Back_button.TabIndex = 18;
            this.Back_button.Text = "Назад";
            this.Back_button.UseVisualStyleBackColor = true;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // bookID_textBox
            // 
            this.bookID_textBox.Location = new System.Drawing.Point(387, 31);
            this.bookID_textBox.Name = "bookID_textBox";
            this.bookID_textBox.Size = new System.Drawing.Size(162, 20);
            this.bookID_textBox.TabIndex = 35;
            // 
            // bookID_button
            // 
            this.bookID_button.Location = new System.Drawing.Point(387, 57);
            this.bookID_button.Name = "bookID_button";
            this.bookID_button.Size = new System.Drawing.Size(162, 39);
            this.bookID_button.TabIndex = 34;
            this.bookID_button.Text = "Искать по ID";
            this.bookID_button.UseVisualStyleBackColor = true;
            this.bookID_button.Click += new System.EventHandler(this.BookID_button_Click);
            // 
            // Author_textBox
            // 
            this.Author_textBox.Location = new System.Drawing.Point(219, 31);
            this.Author_textBox.Name = "Author_textBox";
            this.Author_textBox.Size = new System.Drawing.Size(162, 20);
            this.Author_textBox.TabIndex = 33;
            // 
            // Author_button
            // 
            this.Author_button.Location = new System.Drawing.Point(219, 57);
            this.Author_button.Name = "Author_button";
            this.Author_button.Size = new System.Drawing.Size(162, 39);
            this.Author_button.TabIndex = 32;
            this.Author_button.Text = "Искать по автору";
            this.Author_button.UseVisualStyleBackColor = true;
            this.Author_button.Click += new System.EventHandler(this.Author_button_Click);
            // 
            // Name_textBox
            // 
            this.Name_textBox.Location = new System.Drawing.Point(47, 31);
            this.Name_textBox.Name = "Name_textBox";
            this.Name_textBox.Size = new System.Drawing.Size(162, 20);
            this.Name_textBox.TabIndex = 31;
            // 
            // Namesearch_button
            // 
            this.Namesearch_button.Location = new System.Drawing.Point(47, 57);
            this.Namesearch_button.Name = "Namesearch_button";
            this.Namesearch_button.Size = new System.Drawing.Size(162, 39);
            this.Namesearch_button.TabIndex = 30;
            this.Namesearch_button.Text = "Искать по названию";
            this.Namesearch_button.UseVisualStyleBackColor = true;
            this.Namesearch_button.Click += new System.EventHandler(this.Namesearch_button_Click);
            // 
            // Showall_button
            // 
            this.Showall_button.Location = new System.Drawing.Point(555, 57);
            this.Showall_button.Name = "Showall_button";
            this.Showall_button.Size = new System.Drawing.Size(167, 39);
            this.Showall_button.TabIndex = 36;
            this.Showall_button.Text = "Смотреть весь каталог";
            this.Showall_button.UseVisualStyleBackColor = true;
            this.Showall_button.Click += new System.EventHandler(this.Showall_button_Click);
            // 
            // BookList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Showall_button);
            this.Controls.Add(this.bookID_textBox);
            this.Controls.Add(this.bookID_button);
            this.Controls.Add(this.Author_textBox);
            this.Controls.Add(this.Author_button);
            this.Controls.Add(this.Name_textBox);
            this.Controls.Add(this.Namesearch_button);
            this.Controls.Add(this.Back_button);
            this.Controls.Add(this.listBox1);
            this.Name = "BookList";
            this.Text = "BookList";
            this.Load += new System.EventHandler(this.BookList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.TextBox bookID_textBox;
        private System.Windows.Forms.Button bookID_button;
        private System.Windows.Forms.TextBox Author_textBox;
        private System.Windows.Forms.Button Author_button;
        private System.Windows.Forms.TextBox Name_textBox;
        private System.Windows.Forms.Button Namesearch_button;
        private System.Windows.Forms.Button Showall_button;
    }
}