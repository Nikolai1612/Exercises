using AreaCalculator.Figures;

namespace AreaCalculator.Tests
{
    [TestFixture]
    public class TriangleTests
    {
        private AreaCalculator calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new AreaCalculator();
        }

        [TestCase(3, 4, 5, 6)]
        [TestCase(2, 5, 4, 3.799671)]
        [TestCase(0.1, 0.45, 0.37, 0.012208)]
        public void CalculateArea_ShouldReturnCorrectArea_ForValidTriangle(double a, double b, double c, double expectedArea)
        {
            Assert.That(calculator.GetArea(new Triangle(a, b, c)), Is.EqualTo(expectedArea).Within(0.00001));
        }

        [TestCase(0, 1, 1)]
        [TestCase(1, 0, 1)]
        [TestCase(1, 1, 0)]
        public void Triangle_ThrowArgumentException_ForZeroSides(double a, double b, double c)
        {
            Assert.Throws<ArgumentException>(()=>new Triangle(a, b, c));
        }

        [TestCase(2, 2, -1)]
        [TestCase(-2, 3, 1)]
        [TestCase(3, -1, 4)]
        public void Triangle_ThrowArgumentException_ForNegativeSides(double a, double b, double c)
        {
            Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
        }

        [TestCase(1, 2, 4)]
        [TestCase(6, 3, 2)]
        [TestCase(1, 10, 4)]
        public void Triangle_ThrowArgumentException_ForInvalidSides(double a, double b, double c)
        {
            Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
        }

        [TestCase(3, 4, 5)]
        [TestCase(5, 7, 8.60232)]
        public void Triangle_ShouldReturnTrue_IsRightAngled(double a, double b, double c)
        {
            var triangle = new Triangle(a, b, c);
            var isRightAngled = triangle.IsRightAngled();
            Assert.IsTrue(isRightAngled);
        }

        [TestCase(3, 3, 3)]
        [TestCase(5, 7, 10)]
        public void Triangle_ShouldReturnFalse_IsNotRightAngled(double a, double b, double c)
        {
            var triangle = new Triangle(a, b, c);
            var isRightAngled = triangle.IsRightAngled();
            Assert.IsFalse(isRightAngled);
        }


    }
}