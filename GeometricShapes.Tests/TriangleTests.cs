using FluentAssertions;
using GeometricShapes.Shapes;

namespace GeometricShapes.Tests
{
    public class TriangleTests
    {
        [Test]
        [TestCase(3, 4, 5, 6)]
        public void GetArea(double sideA, double sideB, double sideC, double expectedValue)
        {
            // Arrange
            var triangle = new Triangle(sideA, sideB, sideC);

            // Act
            var result = triangle.Area;

            // Assert
            result.Should().Be(expectedValue);
        }

        [Test]
        [TestCase(3, 4, 5)]
        [TestCase(4, 3, 5)]
        [TestCase(5, 4, 3)]
        public void IsRightTriangle_ShouldReturnTrue(double sideA, double sideB, double sideC)
        {
            // Arrange
            var triangle = new Triangle(sideA, sideB, sideC);

            // Act
            var result = triangle.IsRightAngled;

            // Assert
            result.Should().BeTrue();
        }

        [Test]
        [TestCase(3, 4, 6)]
        public void IsRightTriangle_ShouldReturnFalse(double sideA, double sideB, double sideC)
        {
            // Arrange
            var triangle = new Triangle(sideA, sideB, sideC);

            // Act
            var result = triangle.IsRightAngled;

            // Assert
            result.Should().BeFalse();
        }

        [Test]
        [TestCase(-3, 4, 6)]
        public void GetArea_WhenNegativeSides_ShouldThrowArgumentException(double sideA, double sideB, double sideC)
        {
            // Act
            Action act = () => { var triangle = new Triangle(sideA, sideB, sideC); };

            // Assert            
            act.Should().Throw<ArgumentException>();
        }

        [Test]
        [TestCase(3, 4, 10)]
        public void GetArea_WhenIncorrectSides_ShouldThrowArgumentException(double sideA, double sideB, double sideC)
        {
            // Act
            Action act = () => { var triangle = new Triangle(sideA, sideB, sideC); };

            // Assert            
            act.Should().Throw<ArgumentException>();
        }
    }
}