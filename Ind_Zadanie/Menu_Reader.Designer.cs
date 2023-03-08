namespace Ind_Zadanie
{
    partial class Menu_Reader
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
            this.BookList_button = new System.Windows.Forms.Button();
            this.Book_demand_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BookList_button
            // 
            this.BookList_button.Location = new System.Drawing.Point(33, 53);
            this.BookList_button.Name = "BookList_button";
            this.BookList_button.Size = new System.Drawing.Size(243, 44);
            this.BookList_button.TabIndex = 0;
            this.BookList_button.Text = "Список книг";
            this.BookList_button.UseVisualStyleBackColor = true;
            this.BookList_button.Click += new System.EventHandler(this.BookList_button_Click);
            // 
            // Book_demand_button
            // 
            this.Book_demand_button.Location = new System.Drawing.Point(33, 154);
            this.Book_demand_button.Name = "Book_demand_button";
            this.Book_demand_button.Size = new System.Drawing.Size(243, 44);
            this.Book_demand_button.TabIndex = 2;
            this.Book_demand_button.Text = "Оставить заявку на книгу";
            this.Book_demand_button.UseVisualStyleBackColor = true;
            this.Book_demand_button.Click += new System.EventHandler(this.Book_demand_button_Click);
            // 
            // Menu_Reader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 256);
            this.Controls.Add(this.Book_demand_button);
            this.Controls.Add(this.BookList_button);
            this.Name = "Menu_Reader";
            this.Text = "Menu_Reader";
            this.Load += new System.EventHandler(this.Menu_Reader_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BookList_button;
        private System.Windows.Forms.Button Book_demand_button;
    }
}