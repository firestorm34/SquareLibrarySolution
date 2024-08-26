using ShapeLIbrary;

namespace ShapeLibrary.Tests
{
    public class CircleTests
    {
        [Theory]
        [InlineData(3.0,28.27)]
        [InlineData(4.0, 50.27)]
        [InlineData(5.0, 78.54)]

        public void GetSquare_Theory(double radius, double expectedSquare)
        { 
            Circle circle = new Circle(radius);
            double square = circle.GetSquare();

            Assert.Equal(expectedSquare, square,0.01);
        }

        [Fact] void CircleConstructor_RadiusIsNegative_ThrowsOutOfRangeException()
        {
            Action act = ()=> new Circle(-1.0);
            Assert.Throws<ArgumentOutOfRangeException>(act);
        }
    }
}