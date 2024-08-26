using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLIbrary
{
    public class Circle : IShape
    {
        private double radius;
        public Circle(double radius)
        {
            if(radius < 0d)
            {
                throw new ArgumentOutOfRangeException("Radius can't be negative");
            }
            this.radius = radius;
        }
        public double GetSquare()
        {
            return Math.Round(Math.PI*radius*radius,2);
        }

    }
}
