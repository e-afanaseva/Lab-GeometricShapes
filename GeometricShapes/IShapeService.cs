using GeometricShapes.Shapes;

namespace GeometricShapes
{
    /// <summary>
    /// Service for working with shapes.
    /// </summary>
    public interface IShapeService
    {
        /// <summary>
        /// Get area of the shape
        /// </summary>
        /// <param name="shape">Shape</param>
        /// <returns>Value of the area</returns>
        double GetArea(IShape shape);
    }
}