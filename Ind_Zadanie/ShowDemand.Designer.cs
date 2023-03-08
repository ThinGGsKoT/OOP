namespace Ind_Zadanie
{
    partial class ShowDemand
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
            this.Showalld_button = new System.Windows.Forms.Button();
            this.Searchd_button = new System.Windows.Forms.Button();
            this.DID_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(32, 108);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(551, 303);
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
            // Showalld_button
            // 
            this.Showalld_button.Location = new System.Drawing.Point(32, 59);
            this.Showalld_button.Name = "Showalld_button";
            this.Showalld_button.Size = new System.Drawing.Size(155, 23);
            this.Showalld_button.TabIndex = 19;
            this.Showalld_button.Text = "Просмотреть все заявки";
            this.Showalld_button.UseVisualStyleBackColor = true;
            this.Showalld_button.Click += new System.EventHandler(this.Showalld_button_Click);
            // 
            // Searchd_button
            // 
            this.Searchd_button.Location = new System.Drawing.Point(213, 59);
            this.Searchd_button.Name = "Searchd_button";
            this.Searchd_button.Size = new System.Drawing.Size(155, 23);
            this.Searchd_button.TabIndex = 20;
            this.Searchd_button.Text = "Искать заявку по ID";
            this.Searchd_button.UseVisualStyleBackColor = true;
            this.Searchd_button.Click += new System.EventHandler(this.Searchd_button_Click);
            // 
            // DID_textBox
            // 
            this.DID_textBox.Location = new System.Drawing.Point(268, 33);
            this.DID_textBox.Name = "DID_textBox";
            this.DID_textBox.Size = new System.Drawing.Size(100, 20);
            this.DID_textBox.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "ID заявки:";
            // 
            // ShowDemand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DID_textBox);
            this.Controls.Add(this.Searchd_button);
            this.Controls.Add(this.Showalld_button);
            this.Controls.Add(this.Back_button);
            this.Controls.Add(this.listBox1);
            this.Name = "ShowDemand";
            this.Text = "ShowDemand";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.Button Showalld_button;
        private System.Windows.Forms.Button Searchd_button;
        private System.Windows.Forms.TextBox DID_textBox;
        private System.Windows.Forms.Label label1;
    }
}