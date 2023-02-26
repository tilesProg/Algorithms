namespace Algorithms_Project
{
    partial class Lab1
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
            this.Calculate = new System.Windows.Forms.Button();
            this.Output1 = new System.Windows.Forms.TextBox();
            this.Output2 = new System.Windows.Forms.TextBox();
            this.Output3 = new System.Windows.Forms.TextBox();
            this.GiveX = new System.Windows.Forms.TextBox();
            this.Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(137, 129);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(75, 23);
            this.Calculate.TabIndex = 0;
            this.Calculate.Text = "Расчет";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // Output1
            // 
            this.Output1.Location = new System.Drawing.Point(123, 172);
            this.Output1.Name = "Output1";
            this.Output1.ReadOnly = true;
            this.Output1.Size = new System.Drawing.Size(100, 20);
            this.Output1.TabIndex = 3;
            // 
            // Output2
            // 
            this.Output2.Location = new System.Drawing.Point(123, 221);
            this.Output2.Name = "Output2";
            this.Output2.ReadOnly = true;
            this.Output2.Size = new System.Drawing.Size(100, 20);
            this.Output2.TabIndex = 4;
            // 
            // Output3
            // 
            this.Output3.Location = new System.Drawing.Point(123, 262);
            this.Output3.Name = "Output3";
            this.Output3.ReadOnly = true;
            this.Output3.Size = new System.Drawing.Size(100, 20);
            this.Output3.TabIndex = 5;
            // 
            // GiveX
            // 
            this.GiveX.Location = new System.Drawing.Point(123, 103);
            this.GiveX.Name = "GiveX";
            this.GiveX.Size = new System.Drawing.Size(100, 20);
            this.GiveX.TabIndex = 6;
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(13, 299);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 7;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Lab1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 334);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.GiveX);
            this.Controls.Add(this.Output3);
            this.Controls.Add(this.Output2);
            this.Controls.Add(this.Output1);
            this.Controls.Add(this.Calculate);
            this.Name = "Lab1";
            this.Text = "Лабораторная работа №1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.TextBox Output1;
        private System.Windows.Forms.TextBox Output2;
        private System.Windows.Forms.TextBox Output3;
        private System.Windows.Forms.TextBox GiveX;
        private System.Windows.Forms.Button Back;
    }
}