namespace Ind_Zadanie
{
    partial class Issuance
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
            this.Bookid_textBox = new System.Windows.Forms.TextBox();
            this.readid_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.VbID_button = new System.Windows.Forms.Button();
            this.Vozvr_button = new System.Windows.Forms.Button();
            this.Back_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Bookid_textBox
            // 
            this.Bookid_textBox.Location = new System.Drawing.Point(68, 59);
            this.Bookid_textBox.Name = "Bookid_textBox";
            this.Bookid_textBox.Size = new System.Drawing.Size(100, 20);
            this.Bookid_textBox.TabIndex = 0;
            // 
            // readid_textBox
            // 
            this.readid_textBox.Location = new System.Drawing.Point(258, 59);
            this.readid_textBox.Name = "readid_textBox";
            this.readid_textBox.Size = new System.Drawing.Size(100, 20);
            this.readid_textBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Каталожный номер книги (B-ID)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Номер читательского билета (R-ID)";
            // 
            // VbID_button
            // 
            this.VbID_button.Location = new System.Drawing.Point(68, 120);
            this.VbID_button.Name = "VbID_button";
            this.VbID_button.Size = new System.Drawing.Size(100, 23);
            this.VbID_button.TabIndex = 4;
            this.VbID_button.Text = "Выдача книги";
            this.VbID_button.UseVisualStyleBackColor = true;
            this.VbID_button.Click += new System.EventHandler(this.VbID_button_Click);
            // 
            // Vozvr_button
            // 
            this.Vozvr_button.Location = new System.Drawing.Point(258, 120);
            this.Vozvr_button.Name = "Vozvr_button";
            this.Vozvr_button.Size = new System.Drawing.Size(100, 23);
            this.Vozvr_button.TabIndex = 5;
            this.Vozvr_button.Text = "Возврат книги";
            this.Vozvr_button.UseVisualStyleBackColor = true;
            this.Vozvr_button.Click += new System.EventHandler(this.Vozvr_button_Click);
            // 
            // Back_button
            // 
            this.Back_button.Location = new System.Drawing.Point(379, 213);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(50, 22);
            this.Back_button.TabIndex = 19;
            this.Back_button.Text = "Назад";
            this.Back_button.UseVisualStyleBackColor = true;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // Issuance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 247);
            this.Controls.Add(this.Back_button);
            this.Controls.Add(this.Vozvr_button);
            this.Controls.Add(this.VbID_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.readid_textBox);
            this.Controls.Add(this.Bookid_textBox);
            this.Name = "Issuance";
            this.Text = "Issuance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Bookid_textBox;
        private System.Windows.Forms.TextBox readid_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button VbID_button;
        private System.Windows.Forms.Button Vozvr_button;
        private System.Windows.Forms.Button Back_button;
    }
}