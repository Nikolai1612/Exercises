using AreaCalculator.Figures;

namespace AreaCalculator
{
    public class AreaCalculator
    {
        public double GetArea(IFigure figure)
        {
            return figure.GetArea();
        }
    }
}
