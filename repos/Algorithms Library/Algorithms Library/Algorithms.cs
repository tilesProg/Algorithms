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
            double min(double m, double n)
            {
                if (m < n) 
                    return m; 
                else 
                    return n;
            }
            double max(double m, double n, double k)
            {
                if (m > n && m > k)
                    return m;
                else if (k > n && k > m)
                    return k;
                else
                    return n;
            }
            if (x >= 2 && x <= 3)
                return Math.Tan(x);
            else if (a > 3 && x > 3)
            {
                double ms = min(a, x);
                return Math.Exp(ms);
            }
               
            else
            {
                double ms = min(x, y * y);
                double res = max(ms, Math.Sqrt(x), Math.Sqrt(y) + c);
                return res;
            }
        }
    }
}
