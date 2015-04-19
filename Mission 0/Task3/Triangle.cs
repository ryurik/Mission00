using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Triangle
    {
        public enum TriangleTypes
        {
            NonValid, // не валидный
            AcuteAngled, // остроугольный
            ObtuseAngled, // тупоугольный
            RightAngled // прямоугольный
        };

        private static readonly string[] TriangleTypesNames = {"Не существует", "Остроугольный", "Тупоугольный", "Прямоугольный"};
        public static int CalculatePrecision = 10; // точность вычисления

        private double _a, _b, _c;

        public double A 
        {
            get { return _a; } 
            set { _a = value; }
        }

        public double B
        {
            get { return _b; }
            set { _b = value; }
        }

        public double C
        {
            get { return _c; }
            set { _c = value; }
        }

        public TriangleTypes TriangleType;
      
        /// constructors

        public Triangle()
        {
            InitTriangleData(0, 0, 0);
        }

        public Triangle(double a, double b, double c)
        {
            InitTriangleData(a, b, c);
        }
  
        public string ShowTriangleType()
        {
            return TriangleTypesNames[(int) TriangleType];
        }

        public static bool SortSides(ref double inA, ref double inB, ref double inC)
        {
            if (IsValid(inA, inB, inC))
            {
                double a = (inA <= inB) && (inA <= inC) ? inA : (inB <= inA) && (inB <= inC) ? inB : inC; // min
                double c = (inA >= inB) && (inA >= inC) ? inA : (inB >= inA) && (inB >= inC) ? inB : inC; // max
                double b = (a < inB) && (inB < c) ? inB : (a < inA) && (inA < c) ? inA : inC; // average
                inA = a;
                inB = b;
                inC = c;
                return true;
            }
            // inA = inB = inC = 0; не информативно, если треугольник не существует
            return false;
        }

        private void InitTriangleData(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;

            TriangleType = (SortSides(ref _a, ref _b, ref _c)) ? GetTriangleTypes(A, B, C) : TriangleTypes.NonValid; 
        }


        public static bool IsValid(double a, double b, double c)
        {
            return (((a < b + c) && (a > b - c) && (b < a + c) && (b > a - c) && (c < a + b) && (c > a - b)) &&
                    (a > 0) && (b > 0) && (c > 0));
        }

        public static TriangleTypes GetTriangleTypes(double a, double b, double c)
        {
            if (!SortSides(ref a, ref b, ref c))
                return TriangleTypes.NonValid;

            double cosA = (a*a + b*b - c*c)/ (2 * b *c); // нужен 0 (c определенной точностью) -прямоуголный, или знак <0 - тупой, >0 - острый
            return (Math.Round(Math.Abs(cosA), CalculatePrecision, MidpointRounding.AwayFromZero) == 0) ? TriangleTypes.RightAngled
                : (cosA < 0) ? TriangleTypes.ObtuseAngled : TriangleTypes.AcuteAngled;
        }

        public bool ChangeSides(double a, double b, double c)
        {
            //if (!IsValid(a, b, c)) 
            //    return false;

            InitTriangleData(a, b, c);
            return (TriangleType != TriangleTypes.NonValid);
        }
    }
}



