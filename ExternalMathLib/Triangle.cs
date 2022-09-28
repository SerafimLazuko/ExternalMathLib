namespace ExternalMathLib
{
    public class Triangle : IFigure
    {
        private int side1;
        private int side2;
        private int side3;

        public int Side1 { get => side1; private set => side1 = value; }
        public int Side2 { get => side2; private set => side2 = value; }
        public int Side3 { get => side3; private set => side3 = value; }

        public Triangle(int side1, int side2, int side3)
        {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }

        public double ExecuteArea()
        {
            var hl = (side1 + side2 + side3) / 2;

            return Math.Sqrt(hl * (hl - side1) * (hl - side2) * (hl - side3));
        }

        public bool IsTriangleRightAngled()
        {
            if ((side1 > side2) && (side1 > side3)) return Math.Pow(side1, 2.0) == (Math.Pow(side2, 2.0) + Math.Pow(side3, 2.0));

            if ((side2 > side1) && (side2 > side3)) return Math.Pow(side2, 2.0) == (Math.Pow(side1, 2.0) + Math.Pow(side3, 2.0));

            if ((side3 > side1) && (side3 > side2)) return Math.Pow(side3, 2.0) == (Math.Pow(side1, 2.0) + Math.Pow(side2, 2.0));

            return false;
        }
    }
}
