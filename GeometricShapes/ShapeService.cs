using GeometricShapes.Shapes;

namespace GeometricShapes
{
    public class ShapeService : IShapeService
    {
        public double GetArea(IShape shape) => shape.Area;
    }
}
