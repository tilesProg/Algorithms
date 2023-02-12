using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algorithms_Project
{
    public partial class Lab1_1 : Form
    {
        public Lab1_1()
        {
            InitializeComponent();
        }

        private void Lab1_1_Load(object sender, EventArgs e)
        {

        }

        private void Lab1_Click(object sender, EventArgs e)
        {
            Lab1_2 f = new Lab1_2();
            this.Hide();
            f.ShowDialog();
        }
    }
}
