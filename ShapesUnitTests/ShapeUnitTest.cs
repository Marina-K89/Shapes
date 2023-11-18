using System;
using Shapes;
using Xunit;

namespace ShapesUnitTests
{
    public class ShapeUnitTest
    {
        [Fact]
        public void TestTriangle()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            bool expectedRight = true;
            double expectedSquare = 6;

            bool actualRight = triangle.IsRigthAngled();
            double actualSquare = triangle.Square();

            Assert.Equal(expectedRight, actualRight);
            Assert.Equal(expectedSquare, actualSquare);
        }

        [Fact]
        public void TestCircle()
        {
            Circle circle = new Circle(5);
            double expectedSquare = 78.53981633974483;
            double actualSquare = circle.Square();

            Assert.Equal(expectedSquare, actualSquare);
        }
    }
}
