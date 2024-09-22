using FluentAssertions;
using GeometricShapes.Shapes;

namespace GeometricShapes.Tests
{
    internal class ShapeServiceTests
    {
        private readonly IShapeService _shapeService;

        public ShapeServiceTests()
        {
            _shapeService = new ShapeService();
        }

        [Test]
        [TestCaseSource(nameof(Shapes))]
        public void GetArea_ShouldReturnValue(IShape shape, double expected)
        {
            // Act
            var result = _shapeService.GetArea(shape);

            // Assert
            result.Should().Be(expected);
        }

        public static object[] Shapes =
        [
            new object[] { new Circle(3), 9 * Math.PI },
            new object[] { new Triangle(3, 4, 5), 6 },
        ];
    }
}