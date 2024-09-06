using AreaCalculator.Figures;

namespace AreaCalculator.Tests
{
    [TestFixture]
    public class CircleTests
    {
        private AreaCalculator calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new AreaCalculator();
        }

        [TestCase(5, Math.PI * 25)]
        [TestCase(10, Math.PI * 100)]
        [TestCase(0.45, Math.PI * 0.2025)]
        public void CalculateArea_ShouldReturnCorrectArea_ForValidRadius(double radius, double expectedArea)
        {
            Assert.That(calculator.GetArea(new Circle(radius)), Is.EqualTo(expectedArea).Within(0.00001));
        }

        [TestCase(-1)]
        [TestCase(-10)]
        [TestCase(-0.6)]
        [TestCase(0)]
        public void Circle_ThrowArgumentException_ForNegativeOrZeroRadius(double radius)
        {
            Assert.Throws<ArgumentException>(()=>new Circle(radius));
        }
    }
}