namespace GeometricShapes.Shapes
{
    public class Triangle : IShape
    {        
        public double SideA { get; init; }
        public double SideB { get; init; }
        public double SideC { get; init; }

        public double Area
        {
            get
            {
                // TODO Здесь можно проверять является ли треугольник прямоугольным и вычислять площадь по катетам.
                var semiperimeter = (SideA + SideB + SideC) / 2;
                return Math.Sqrt(semiperimeter * (semiperimeter - SideA) * (semiperimeter - SideB) * (semiperimeter - SideC));
            }
        }

        /// <summary>
        /// Returns an indication whether the triangle is a right angled.
        /// </summary>
        public bool IsRightAngled
        {
            get
            {
                var sides = new List<double> { SideA, SideB, SideC };
                sides.Sort();
                if (sides is [var baseSide, var altitude, var hypotenuse])
                {
                    // TODO Тут возможна неточность, если переданы числа с плавающей точкой. Можно сравнить не через равно, а с небольшой погрешностью, например, 1e-10.
                    return hypotenuse * hypotenuse == baseSide * baseSide + altitude * altitude;
                }
                return false;
            }
        }

        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                throw new ArgumentException("Sides of the triangle must be positive numbers");
            }
            else if (sideA + sideB <= sideC
                     || sideA + sideC <= sideB
                     || sideC + sideB <= sideA)
            {
                throw new ArgumentException("The sum of any two sides of a triangle must be greater than the third side.");
            }

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }
    }
}
