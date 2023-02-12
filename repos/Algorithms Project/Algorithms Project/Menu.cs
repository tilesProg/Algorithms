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
            Lab1_1 f = new Lab1_1();
            this.Hide();
            f.ShowDialog();
        }
    }
}
