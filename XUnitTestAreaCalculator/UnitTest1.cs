using System;
using AreaCalculator;
using Xunit;

namespace XUnitTestAreaCalculator
{
    public class UnitTest1
    {
        [Fact]
        public void TestAreaOfCircle()
        {
            Assert.Equal(50.27, Math.Round(new Circle(4.0).CalculateArea(), 2));
        }
        [Fact]
        public void TestAreaOfRectangle()
        {
            Assert.Equal(26, Math.Round(new Rectangle(4.0, 6.5).CalculateArea(), 2));
        }
        [Fact]
        public void TestAreaOfSquare()
        {
            Assert.Equal(23.04, Math.Round(new Square(4.8).CalculateArea(), 2));
        }
        [Fact]
        public void TestAreaOfTriangle()
        {
            Assert.Equal(12.26, Math.Round(new Triangle(4.3, 5.7).CalculateArea(), 2));
        }
    }
}
