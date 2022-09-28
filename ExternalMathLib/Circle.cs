namespace ExternalMathLib
{
    public class Circle : IFigure
    {
        private double radius;

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Radius { get => radius; private set => radius = value; }

        public double ExecuteArea()
        {
            return Math.Pow(Radius, 2) * Math.PI;
        }
    }
}
