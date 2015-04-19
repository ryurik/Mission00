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

        private double _A, _B, _C;

        public double A 
        {
            get { return _A; } 
            set { _A = value; }
        }

        public double B
        {
            get { return _B; }
            set { _B = value; }
        }

        public double C
        {
            get { return _C; }
            set { _C = value; }
        }

        public bool CanModificate = false; // by default the tiangle can't be modificated

        public TriangleTypes TriangleType = TriangleTypes.NonValid;

        public static bool SortSides(ref double inA, ref double inB, ref double inC)
        {
            if (IsValid(inA, inB, inC))
            {
                double a = (inA <= inB) && (inA <= inC) ? inA : (inB <= inA) && (inB <= inC) ? inB : inC; // min
                double b = (inA <= inB) && (inB <= inC) ? inB : (inB <= inA) && (inA <= inC) ? inB : inC; // average
                double c = (inA >= inB) && (inA >= inC) ? inA : (inB >= inA) && (inB >= inC) ? inB : inC; // max
                inA = a;
                inB = b;
                inC = c;
                return true;
            }
            inA = inB = inC = 0;
            return false;
        }

        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;

            TriangleType = (SortSides(ref _A, ref _B, ref _C)) ? GetTriangleTypes(A, B, C) : TriangleTypes.NonValid;
            CanModificate = TriangleType != TriangleTypes.NonValid;
        }

        public static bool IsValid(double a, double b, double c)
        {
            return (((a < b + c) && (a > b - c) && (b < a + c) && (b > a - c) && (c < a + b) && (c > a - b)) &&
                    (a > 0) && (b > 0) && (c > 0));
        }

        public static TriangleTypes GetTriangleTypes(double a, double b, double c)
        {
            if (IsValid(a,b,c))
                return TriangleTypes.NonValid;
            SortSides(ref a, ref b, ref c);
            // todo: get Triangle Type
            return TriangleTypes.AcuteAngled;
        }
    }
}



