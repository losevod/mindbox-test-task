using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesLibrary
{
    public class Circle : IShape
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            if (radius < 0)
            {
                throw new ArgumentException("The radius cannot be negative!");
            }
            Radius = radius;
        }

        public double CalculateArea() => Radius * Radius * Math.PI;

    }
    
}
