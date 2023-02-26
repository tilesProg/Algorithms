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
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Menu f = new Menu();
            this.Hide();
            f.ShowDialog();
        }
    }
}
