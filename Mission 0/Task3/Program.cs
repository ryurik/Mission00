using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle();
            Console.WriteLine("Тип треугольника со сторонами А={0} B={1} C={2} -- {3}", triangle.A, triangle.B, triangle.C, triangle.ShowTriangleType());
            
            triangle.ChangeSides(100, 100, 100);
            Console.WriteLine("Тип треугольника со сторонами А={0} B={1} C={2} -- {3}", triangle.A, triangle.B, triangle.C, triangle.ShowTriangleType());
            
            triangle.ChangeSides(200.00, 173.20508075689, 100.00);
            Console.WriteLine("Тип треугольника со сторонами А={0} B={1} C={2} -- {3}", triangle.A, triangle.B, triangle.C, triangle.ShowTriangleType());
            
            triangle.ChangeSides(50.00, 60.00, 100.00);
            Console.WriteLine("Тип треугольника со сторонами А={0} B={1} C={2} -- {3}", triangle.A, triangle.B, triangle.C, triangle.ShowTriangleType());
           
            triangle.ChangeSides(91.93, 86.60, 100.00);
            Console.WriteLine("Тип треугольника со сторонами А={0} B={1} C={2} -- {3}", triangle.A, triangle.B, triangle.C, triangle.ShowTriangleType());

            triangle.ChangeSides(-91.93, -86.60, -100.00);
            Console.WriteLine("Тип треугольника со сторонами А={0} B={1} C={2} -- {3}", triangle.A, triangle.B, triangle.C, triangle.ShowTriangleType());

            Console.ReadKey();
         }
    }
}
