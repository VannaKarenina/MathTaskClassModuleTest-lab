using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathTaskClassModule
{
    public class Geometry
    {
        public double[] Sqrt(double a, double b, double c)
        {
            double d = Math.Pow(b, 2) - 4 * a * c;
            double res1 = (-b + Math.Sqrt(d)) / (2 * a);
            double res2 = (-b - Math.Sqrt(d)) / (2 * a);
            double[] arr = new double[2];
            arr[0] = res1;
            arr[1] = res2; 


            return arr;
        }
    }
}
