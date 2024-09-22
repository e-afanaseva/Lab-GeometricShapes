using FluentAssertions;
using GeometricShapes.Shapes;

namespace GeometricShapes.Tests
{
    internal class CircleTests
    {
        [Test]
        [TestCase(3, 9 * Math.PI)]
        [TestCase(0.1, 0.01 * Math.PI)]
        public void GetArea_ShouldReturnValue(double radius, double expected)
        {
            // Arrange
            var circle = new Circle(radius);

            // Act
            var result = circle.Area;

            // Assert
            result.Should().Be(expected);
        }

        [Test]
        [TestCase(-100)]
        public void GetArea_WhenNegativeRadius_ShouldThrowArgumentException(double radius)
        {
            // Act
            Action act = () => { var circle = new Circle(radius); };

            // Assert            
            act.Should().Throw<ArgumentException>();
        }


        [Test]
        [TestCase(double.MaxValue)]
        public void GetArea_ShouldThrowOverflowException(double radius)
        {
            // Arrange
            var circle = new Circle(radius);

            // Act
            Action act = () => { var area = circle.Area; };

            // Assert            
            act.Should().Throw<OverflowException>();
        }
    }
}
