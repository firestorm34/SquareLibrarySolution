using ShapeLIbrary;
using System.Collections.Generic;
using Xunit;

namespace ShapeLibrary.Tests
{
    public class TriangleTests
    {
        [Theory]
        [InlineData(4.5,5.5,6.6, 12.25)]
        [InlineData(3.5,4.5,5.2, 7.75)]

        public void GetSquare_Theory(double first, double second, double third, double expectedSquare)
        { 
            Triangle triangle = new Triangle(first,second,third);
            double square = triangle.GetSquare();

            Assert.Equal(expectedSquare, square,0.01);
        }

        [Theory]
        [InlineData(4.5, 5.5, 6.6, false)]
        [InlineData(3.0, 4.0, 5.0, true)]
        public void IsStraight_Theory(double first, double second, double third, bool expectedIsStraight)
        {
            Triangle triangle = new Triangle(first, second, third);
            bool isStraight= triangle.IsStraight();

            Assert.Equal(expectedIsStraight, isStraight);
        }

        [Fact]
        void TriangleConstructor_OneSideIsNegative_ThrowsOutOfRangeException()
        {
            Action act = ()=> new Triangle(-1.0, 2.0, 2.2);

            Assert.Throws<ArgumentOutOfRangeException>(act);

        }

        [Fact]
        void TriangleConstructor_OneSideIsMoreThanOthersCombined_ThrowsException()
        {
            Action act = () => new Triangle(1.0, 2.0, 4.2);

            Assert.Throws<Exception>(act);

        }

        [Fact]
        public void GetSquare_RadiusIsNegative_ThrowsOutOfRangeException()
        {
            Action act = ()=> new Circle(-1.0);
            Assert.Throws<ArgumentOutOfRangeException>(act);
        }
    }
}