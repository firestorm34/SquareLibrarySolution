using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLIbrary
{
    public class Triangle : IShape
    {

        private double firstSide;
        private double secondSide;
        private double thirdSide;
        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            if (IsValid(firstSide, secondSide, thirdSide)){ 
            this.firstSide = firstSide;
            this.secondSide = secondSide;
            this.thirdSide = thirdSide;
            }
        }
        private bool IsValid(double first, double second, double third)
        {
            if (first < 0d || second < 0d || third < 0d)
            {
                throw new ArgumentOutOfRangeException("Triangle with set sides doesn't exist: side(s) is less than zero!)");
            }

            if (first > (second + third) || second > (first + third) || third > (first + second))
            {
                throw new Exception("Triangle with set sides doesn't exist: one of sides is more than 2 others combined!");
            }
            return true;
        }

        public bool IsStraight() { 

                bool isStraight = (firstSide == Math.Sqrt(Math.Pow(secondSide, 2) + Math.Pow(thirdSide, 2))
                                   || secondSide == Math.Sqrt(Math.Pow(firstSide, 2) + Math.Pow(thirdSide, 2))
                                   || thirdSide == Math.Sqrt(Math.Pow(firstSide, 2) + Math.Pow(secondSide, 2)));
                return isStraight;
            }
        public double GetSquare()
        {
            double p = (firstSide + secondSide + thirdSide) / 2d;
            return Math.Sqrt(p * (p - firstSide) * (p - secondSide) * (p - thirdSide));
        }
    }
}
