using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class LinearFunction
    {
        public double A { get; set; }


        public double B { get; set; }

        public double Y(double x) { return A * x + B; }
        public double Y(double a, double b, double x)
        {
            A = a;
            B = b;
            return Y(x); 
        }

    }
}
