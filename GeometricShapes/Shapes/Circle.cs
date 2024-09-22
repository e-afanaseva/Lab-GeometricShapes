namespace GeometricShapes.Shapes
{
    /// <summary>
    /// Circle
    /// </summary>
    public class Circle : IShape
    {
        public double Radius { get; init; }
        public double Area { get => GetArea(); }

        /// <summary>
        /// Initializes a new instance Circle
        /// </summary>
        /// <param name="radius">The radius of the circle</param>
        /// <exception cref="ArgumentException">Thrown when the radius is not positive number</exception>
        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Radius must be positive number", nameof(radius));
            }
            Radius = radius;
        }


        private double GetArea()
        {
            var area = Math.PI * Radius * Radius;

            if (double.IsInfinity(area))
                throw new OverflowException("Value of the area was either too large for a Double.");

            return area;
        }

    }
}
