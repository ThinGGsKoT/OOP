namespace Ind_Zadanie
{
    partial class Menu_Admin
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
            this.Add_Reader_button = new System.Windows.Forms.Button();
            this.Add_book_button = new System.Windows.Forms.Button();
            this.Issuance_button = new System.Windows.Forms.Button();
            this.BookList_button = new System.Windows.Forms.Button();
            this.ShowDemand_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Add_Reader_button
            // 
            this.Add_Reader_button.Location = new System.Drawing.Point(31, 24);
            this.Add_Reader_button.Name = "Add_Reader_button";
            this.Add_Reader_button.Size = new System.Drawing.Size(251, 32);
            this.Add_Reader_button.TabIndex = 0;
            this.Add_Reader_button.Text = "Добавить/редактировать читателя";
            this.Add_Reader_button.UseVisualStyleBackColor = true;
            this.Add_Reader_button.Click += new System.EventHandler(this.Add_Reader_button_Click);
            // 
            // Add_book_button
            // 
            this.Add_book_button.Location = new System.Drawing.Point(31, 67);
            this.Add_book_button.Name = "Add_book_button";
            this.Add_book_button.Size = new System.Drawing.Size(251, 32);
            this.Add_book_button.TabIndex = 1;
            this.Add_book_button.Text = "Добавить/редактировать книгу";
            this.Add_book_button.UseVisualStyleBackColor = true;
            this.Add_book_button.Click += new System.EventHandler(this.Add_book_button_Click);
            // 
            // Issuance_button
            // 
            this.Issuance_button.Location = new System.Drawing.Point(31, 111);
            this.Issuance_button.Name = "Issuance_button";
            this.Issuance_button.Size = new System.Drawing.Size(251, 32);
            this.Issuance_button.TabIndex = 2;
            this.Issuance_button.Text = "Оформить выдачу/прием книги";
            this.Issuance_button.UseVisualStyleBackColor = true;
            this.Issuance_button.Click += new System.EventHandler(this.Issuance_button_Click);
            // 
            // BookList_button
            // 
            this.BookList_button.Location = new System.Drawing.Point(31, 155);
            this.BookList_button.Name = "BookList_button";
            this.BookList_button.Size = new System.Drawing.Size(251, 32);
            this.BookList_button.TabIndex = 3;
            this.BookList_button.Text = "Список книг";
            this.BookList_button.UseVisualStyleBackColor = true;
            this.BookList_button.Click += new System.EventHandler(this.BookList_button_Click);
            // 
            // ShowDemand_button
            // 
            this.ShowDemand_button.Location = new System.Drawing.Point(31, 198);
            this.ShowDemand_button.Name = "ShowDemand_button";
            this.ShowDemand_button.Size = new System.Drawing.Size(251, 32);
            this.ShowDemand_button.TabIndex = 5;
            this.ShowDemand_button.Text = "Смотреть заявки";
            this.ShowDemand_button.UseVisualStyleBackColor = true;
            this.ShowDemand_button.Click += new System.EventHandler(this.ShowDemand_button_Click);
            // 
            // Menu_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 256);
            this.Controls.Add(this.ShowDemand_button);
            this.Controls.Add(this.BookList_button);
            this.Controls.Add(this.Issuance_button);
            this.Controls.Add(this.Add_book_button);
            this.Controls.Add(this.Add_Reader_button);
            this.Name = "Menu_Admin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Add_Reader_button;
        private System.Windows.Forms.Button Add_book_button;
        private System.Windows.Forms.Button Issuance_button;
        private System.Windows.Forms.Button BookList_button;
        private System.Windows.Forms.Button ShowDemand_button;
    }
}