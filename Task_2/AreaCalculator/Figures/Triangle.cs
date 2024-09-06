using System;

namespace AreaCalculator.Figures
{
    public class Triangle : IFigure
    {
        public double SideA {  get; private set; }
        public double SideB { get; private set; }
        public double SideC { get; private set; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;

            if(!IsValid()) throw new ArgumentException("Invalid tringle sides");
        }

        public double GetArea()
        {
            double semiPerimeter = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - SideA) * (semiPerimeter - SideB) * (semiPerimeter - SideC));
        }

        public bool IsRightAngled()
        {
            double[] sides = { SideA, SideB, SideC };
            Array.Sort(sides);
            var b = Math.Pow(sides[2], 2) - (Math.Pow(sides[1], 2) + Math.Pow(sides[0], 2));
            return Math.Abs(b) < 1e-4;
        }

        public bool IsValid()
        {
            if( SideA<=0 || SideB<=0 || SideC<=0 ) return false;
            else if(SideA + SideB <= SideC || SideB + SideC <= SideA || SideC + SideA <= SideB ) return false;
            return true;
        }
    }
}
