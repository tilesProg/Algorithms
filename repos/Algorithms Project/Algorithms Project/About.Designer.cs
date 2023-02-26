namespace Algorithms_Project
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.about1 = new System.Windows.Forms.Label();
            this.about2 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // about1
            // 
            this.about1.AutoSize = true;
            this.about1.Location = new System.Drawing.Point(207, 64);
            this.about1.Name = "about1";
            this.about1.Size = new System.Drawing.Size(386, 130);
            this.about1.TabIndex = 0;
            this.about1.Text = resources.GetString("about1.Text");
            this.about1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // about2
            // 
            this.about2.AutoSize = true;
            this.about2.Location = new System.Drawing.Point(625, 363);
            this.about2.Name = "about2";
            this.about2.Size = new System.Drawing.Size(163, 78);
            this.about2.TabIndex = 1;
            this.about2.Text = "Выполнил(а):\r\nстудент группы БФИ2203\r\nЧекулаев А. Е.\r\nПроверил:\r\nдоц. кафедры «Ин" +
    "форматика»\r\nГуриков С. Р.";
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(12, 415);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 2;
            this.back.Text = "Назад";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back);
            this.Controls.Add(this.about2);
            this.Controls.Add(this.about1);
            this.Name = "About";
            this.Text = "Титульный лист";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label about1;
        private System.Windows.Forms.Label about2;
        private System.Windows.Forms.Button back;
    }
}