namespace Algorithms_Project
{
    partial class Lab2
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
            this.Back = new System.Windows.Forms.Button();
            this.Input1 = new System.Windows.Forms.TextBox();
            this.Input2 = new System.Windows.Forms.TextBox();
            this.Input3 = new System.Windows.Forms.TextBox();
            this.Input4 = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.TextBox();
            this.Calculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(12, 227);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 0;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Input1
            // 
            this.Input1.Location = new System.Drawing.Point(12, 52);
            this.Input1.Name = "Input1";
            this.Input1.Size = new System.Drawing.Size(100, 20);
            this.Input1.TabIndex = 1;
            // 
            // Input2
            // 
            this.Input2.Location = new System.Drawing.Point(118, 52);
            this.Input2.Name = "Input2";
            this.Input2.Size = new System.Drawing.Size(100, 20);
            this.Input2.TabIndex = 2;
            // 
            // Input3
            // 
            this.Input3.Location = new System.Drawing.Point(224, 52);
            this.Input3.Name = "Input3";
            this.Input3.Size = new System.Drawing.Size(100, 20);
            this.Input3.TabIndex = 3;
            // 
            // Input4
            // 
            this.Input4.Location = new System.Drawing.Point(330, 52);
            this.Input4.Name = "Input4";
            this.Input4.Size = new System.Drawing.Size(100, 20);
            this.Input4.TabIndex = 4;
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(330, 132);
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            this.Result.Size = new System.Drawing.Size(100, 20);
            this.Result.TabIndex = 5;
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(342, 92);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(75, 23);
            this.Calculate.TabIndex = 6;
            this.Calculate.Text = "Посчитать";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // Lab2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 262);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Input4);
            this.Controls.Add(this.Input3);
            this.Controls.Add(this.Input2);
            this.Controls.Add(this.Input1);
            this.Controls.Add(this.Back);
            this.Name = "Lab2";
            this.Text = "Lab2";
            this.Load += new System.EventHandler(this.Lab2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.TextBox Input1;
        private System.Windows.Forms.TextBox Input2;
        private System.Windows.Forms.TextBox Input3;
        private System.Windows.Forms.TextBox Input4;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Button Calculate;
    }
}