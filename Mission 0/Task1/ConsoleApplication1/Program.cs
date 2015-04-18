using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    
    class Program
    {
        static void Main(string[] args)
        {
            LinearFunction linearFunction = new LinearFunction(){A = 10, B = 10};
            double x = 4.5;

            Console.WriteLine("A={0} B={1}  Y={0}*{2}+{1}={3}", linearFunction.A, linearFunction.B, x, linearFunction.Y(x));
            Console.ReadKey();
        }
    }
}
