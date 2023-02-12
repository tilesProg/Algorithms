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
    public partial class Lab1_2 : Form
    {
        public Lab1_2()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            double a = Algoritms.Input(GiveX);
            double b = Algoritms.Calculate1(a);
            Algoritms.Output(Output1, b);
            Algoritms.Calculate2(a, out double rez);
            Algoritms.Output(Output2, rez);
            double c = 0;
            Algoritms.Calculate3(a, ref c);
            Algoritms.Output(Output3, c);
        }
    }
}
