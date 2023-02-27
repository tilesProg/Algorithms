using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Algorithms_Library;

namespace Algorithms_Project
{
    public partial class Lab2 : Form
    {
        public Lab2()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Menu f = new Menu();
            this.Hide();
            f.ShowDialog();
        }

        private void Lab2_Load(object sender, EventArgs e)
        {

        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            double x = Algoritms.Input(Input1);
            double y = Algoritms.Input(Input2);
            double a = Algoritms.Input(Input3);
            double c = Algoritms.Input(Input4);
            double res = Algoritms.CalculateLab2(x, y, a, c);
            Algoritms.Output(Result, res);
        }
    }
}
