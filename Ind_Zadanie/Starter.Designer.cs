namespace Ind_Zadanie
{
    partial class Starter
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
            this.AdminEnter_button = new System.Windows.Forms.Button();
            this.ReaderEnter_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AdminEnter_button
            // 
            this.AdminEnter_button.Location = new System.Drawing.Point(73, 28);
            this.AdminEnter_button.Name = "AdminEnter_button";
            this.AdminEnter_button.Size = new System.Drawing.Size(140, 23);
            this.AdminEnter_button.TabIndex = 0;
            this.AdminEnter_button.Text = "Администратор";
            this.AdminEnter_button.UseVisualStyleBackColor = true;
            this.AdminEnter_button.Click += new System.EventHandler(this.AdminEnter_button_Click);
            // 
            // ReaderEnter_button
            // 
            this.ReaderEnter_button.Location = new System.Drawing.Point(73, 80);
            this.ReaderEnter_button.Name = "ReaderEnter_button";
            this.ReaderEnter_button.Size = new System.Drawing.Size(140, 23);
            this.ReaderEnter_button.TabIndex = 1;
            this.ReaderEnter_button.Text = "Читатель";
            this.ReaderEnter_button.UseVisualStyleBackColor = true;
            this.ReaderEnter_button.Click += new System.EventHandler(this.ReaderEnter_button_Click);
            // 
            // Starter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 142);
            this.Controls.Add(this.ReaderEnter_button);
            this.Controls.Add(this.AdminEnter_button);
            this.Name = "Starter";
            this.Text = "Войти";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AdminEnter_button;
        private System.Windows.Forms.Button ReaderEnter_button;
    }
}