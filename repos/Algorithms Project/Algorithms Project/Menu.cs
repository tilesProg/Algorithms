using System;
using System.Windows.Forms;

namespace Algorithms_Project
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Lab1_Click(object sender, EventArgs e)
        {
            Lab1 f = new Lab1();
            this.Hide();
            f.ShowDialog();
        }

        private void about_Click(object sender, EventArgs e)
        {
            About f = new About();
            this.Hide();
            f.ShowDialog();
        }

        private void Lab2_Click(object sender, EventArgs e)
        {
            Lab2 f = new Lab2();
            this.Hide();
            f.ShowDialog();
        }
    }
}
