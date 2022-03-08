using Xunit;
using AreaCalculator.Parameters;
using System.Collections.Generic;

namespace AreaCalculator
{
    public class AreaCalculatorTests
    {
        [Fact]
        public void ItShouldBeCalculateCircleSquare()
        {
            
            const double expectedValue = 19.634954084936208;

            var parameters = new Dictionary<string, object>
            {
                {CircleParameter.Radius, 2.5}
            };

            var sut = new Circle(parameters);
            var result = sut.OnCalculate();

            Assert.Equal(expectedValue, result);
        }

        [Fact]
        public void ItShouldBeCalculateTriangleSquare()
        {
            const double expectedValue = 9.9215674164922145;

            var parameters = new Dictionary<string, object>
            {
                {TriangleParameter.Triangle, new TriangleParameter(4, 5, 6)}
            };

            var sut = new Triangle(parameters);
            var result = sut.OnCalculate();

            Assert.Equal(expectedValue, result);
        }

        [Fact]
        public void ItShouldBeRightTriangle()
        {
            const double expectedValue = 6;

            var parameters = new Dictionary<string, object>
            {
                {TriangleParameter.Triangle, new TriangleParameter(4, 5, 3)}
            };

            var sut = new Triangle(parameters);
            var result = sut.OnCalculate();
            var isRight = sut.IsRight;

            Assert.Equal(expectedValue, result);
            Assert.True(isRight);
        }
    }
}