namespace Algorithms_Project
{
    partial class Menu
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
            this.Exit = new System.Windows.Forms.Button();
            this.Lab1 = new System.Windows.Forms.Button();
            this.about = new System.Windows.Forms.Button();
            this.Lab2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(610, 322);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 0;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Lab1
            // 
            this.Lab1.AutoSize = true;
            this.Lab1.Location = new System.Drawing.Point(12, 95);
            this.Lab1.Name = "Lab1";
            this.Lab1.Size = new System.Drawing.Size(148, 23);
            this.Lab1.TabIndex = 1;
            this.Lab1.Text = "Лабораторная работа №1";
            this.Lab1.UseVisualStyleBackColor = true;
            this.Lab1.Click += new System.EventHandler(this.Lab1_Click);
            // 
            // about
            // 
            this.about.AutoSize = true;
            this.about.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.about.Location = new System.Drawing.Point(268, 36);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(98, 23);
            this.about.TabIndex = 2;
            this.about.Text = "Титульный лист";
            this.about.UseVisualStyleBackColor = true;
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // Lab2
            // 
            this.Lab2.AutoSize = true;
            this.Lab2.Location = new System.Drawing.Point(13, 146);
            this.Lab2.Name = "Lab2";
            this.Lab2.Size = new System.Drawing.Size(148, 23);
            this.Lab2.TabIndex = 3;
            this.Lab2.Text = "Лабораторная работа №2";
            this.Lab2.UseVisualStyleBackColor = true;
            this.Lab2.Click += new System.EventHandler(this.Lab2_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 357);
            this.Controls.Add(this.Lab2);
            this.Controls.Add(this.about);
            this.Controls.Add(this.Lab1);
            this.Controls.Add(this.Exit);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Lab1;
        private System.Windows.Forms.Button about;
        private System.Windows.Forms.Button Lab2;
    }
}