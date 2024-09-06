using System;

namespace AreaCalculator.Figures
{
    public class Circle : IFigure
    {
        public double Radius { get; private set; }

        public Circle(double radius)
        {
            Radius = radius;

            if (!IsValid()) throw new ArgumentException("Radius cannot be equal to ot less than 0");
        }

        public double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public bool IsValid()
        {
            return Radius > 0;
        }
    }
}
