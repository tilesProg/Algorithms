namespace Algorithms_Project
{
    partial class Lab1_1
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
            this.Lab1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Лабораторная работа №1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(509, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "\"Программирование арифметических выражений на языке Visual C# с использованием ме" +
    "тодов\"";
            // 
            // Lab1
            // 
            this.Lab1.AutoSize = true;
            this.Lab1.Location = new System.Drawing.Point(201, 173);
            this.Lab1.Name = "Lab1";
            this.Lab1.Size = new System.Drawing.Size(107, 23);
            this.Lab1.TabIndex = 2;
            this.Lab1.Text = "Перейти к работе";
            this.Lab1.UseVisualStyleBackColor = true;
            this.Lab1.Click += new System.EventHandler(this.Lab1_Click);
            // 
            // Lab1_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 239);
            this.Controls.Add(this.Lab1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Lab1_1";
            this.Text = "Лабораторная работа №1 - титульный лист";
            this.Load += new System.EventHandler(this.Lab1_1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Lab1;
    }
}