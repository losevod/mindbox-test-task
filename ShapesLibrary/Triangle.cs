using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesLibrary
{
    public class Triangle: IShape
    {
        public double A { get; }
        public double B { get; }
        public double C { get; }

        public Triangle(double a, double b, double c)
        {
            if (a < 0 || b < 0 || c < 0)
            {
                throw new ArgumentException("The sides cannot be negative!");
            }

            if (!(a < b + c && b < a + c && c < b + a))
            {
                throw new ArgumentException("It's not a triangle!");
            }

            A = a;
            B = b;
            C = c;

        }
        public bool IsRightTriangle()
        {
            return (A == Math.Sqrt(B * B + C * C) || B == Math.Sqrt(A * A + C * C) || C == Math.Sqrt(B * B + A * A));
        }

        public double CalculateArea()
        {
            var p = (A + B + C) / 2;

            return Math.Sqrt(p * (p-A) * (p-B) * (p-C));
        }
    }
}
