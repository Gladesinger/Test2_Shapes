namespace Shapes.Tests
{
    public class TriangleClass_UnitTest
    {
        [Theory]
        [InlineData(3, 4, 5, 6)]
        [InlineData(13, 14, 15, 84)]
        public void TriangleGetArea_IfSidesArePositive_ShouldReturnTrinagleArea(double a, double b, double c, double expected_value)
        {
            Triangle triangle = new Triangle(a, b, c);

            double result = triangle.GetArea();

            Assert.Equal(expected_value, result);
        }

        [Theory]
        [InlineData(3.5, 5, 6.123724356957945)]
        [InlineData(5, 6, 12)]
        public void IsoscelesTriangleGetArea_IfSidesArePositive_ShouldReturnTrinagleArea(double a, double b, double expected_value)
        {
            Triangle triangle = new Triangle(a, b);

            double result = triangle.GetArea();

            Assert.Equal(expected_value, result);
        }

        [Theory]
        [InlineData(3.5, 5.304405598179687)]
        [InlineData(100, 4330.127018922193)]
        public void EquilateralTriangleGetArea_IfSidesArePositive_ShouldReturnTrinagleArea(double a, double expected_value)
        {
            Triangle triangle = new Triangle(a);

            double result = triangle.GetArea();

            Assert.Equal(expected_value, result);
        }

        [Theory]
        [InlineData(-2, 0, 5)]
        [InlineData(5, 2, -5)]
        [InlineData(7, -7, 12)]
        public void TriangleGetArea_IfSideIsNegative_ShouldThrowArgumentException(double a, double b, double c)
        {
            Action action = () => new Triangle(a, b, c).GetArea();

            Assert.Throws<ArgumentException>(action);
        }

        [Theory]
        [InlineData(double.MaxValue, 5 ,10)]
        [InlineData(double.MaxValue * 2, double.MaxValue, 5)]
        public void TriangleGetArea_IfResultIsTooBig_ShouldThrowOverflowException(double a, double b, double c)
        {
            Action action = () => new Triangle(a, b, c).GetArea();
            
            Assert.Throws<OverflowException>(action);
        }
    }
}