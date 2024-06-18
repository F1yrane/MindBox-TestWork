namespace GeometryLibrary
{
    public class Triangle : IShape
    {
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            // проверка валидности треугольника
            if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
                throw new ArgumentException("Invalid sides for triangle");

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        // площадь треугольника по формуле герона
        public double CalculateArea()
        {
            double s = (SideA + SideB + SideC) / 2; // полупериметр

            return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
        }

        public bool IsRight()
        {
            double a = Math.Pow(SideA, 2);
            double b = Math.Pow(SideB, 2);
            double c = Math.Pow(SideC, 2);

            //проверка по теореме пифагора
            return a + b == c || a + c == b || b + c == a;
        }
    }
}
