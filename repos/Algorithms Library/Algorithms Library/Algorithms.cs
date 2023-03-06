using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algorithms_Library
{
    public class Algoritms
    {
        public static double Input(TextBox t)
        {
            return Convert.ToDouble(t.Text);
        }
        public static void Output(TextBox t, double sum)
        {
            t.Text = sum.ToString();
        }
        public static double Calculate1(double x)
        {
            return Math.Exp(5 - 2 * x) / (x - (19.0 / 8.0)) + Math.Abs(Math.Log(9.1 * x + 0.1) + Math.Sin(x / 3));
        }
        public static void Calculate2(double x, out double y)
        {
            y = Math.Exp(5 - 2 * x) / (x - (19.0 / 8.0)) + Math.Abs(Math.Log(9.1 * x + 0.1) + Math.Sin(x / 3));
        }
        public static void Calculate3(double x, ref double y)
        {
            y = Math.Exp(5 - 2 * x) / (x - (19.0 / 8.0)) + Math.Abs(Math.Log(9.1 * x + 0.1) + Math.Sin(x / 3));
        }
        public static double CalculateLab2(double x, double y, double a, double c)
        {
            double k;
            if (x >= 2 && x <= 3)
                k = Math.Tan(x);
            else if (a > 3 && x > 3)
            {
                if (a < x)
                    k = Math.Exp(a);
                else
                    k = Math.Exp(x);
            }
            else
            {
                if (x < y * y)
                    k = x;
                else
                    k = y * y;
                if (k > Math.Sqrt(x))
                    k = Math.Sqrt(x);
                if (Math.Sqrt(y) + c > k)
                    k = Math.Sqrt(y) + c;


            }
            return k;
        }
    }
}
