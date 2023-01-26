namespace Shapes.Tests
{
    public class CircleClass_UnitTest
    {
        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, Math.PI)]
        [InlineData(2, 4 * Math.PI)]
        [InlineData(3, 9 * Math.PI)]
        public void CircleGetArea_IfRadiusIsPositive_ShouldReturnCircleArea(double radius, double expected_value)
        {
            Circle circle = new Circle(radius);

            double result = circle.GetArea();

            Assert.Equal(expected_value, result);
        }

        [Theory]
        [InlineData(-3)]
        [InlineData(-100)]
        [InlineData(-100000)]
        public void CircleGetArea_IfRadiusIsNegative_ShouldThrowArgumentException(double radius)
        {
            Action action = (() => new Circle(radius).GetArea());

            Assert.Throws<ArgumentException>(action);
        }

        [Theory]
        [InlineData(double.MaxValue)]
        [InlineData(double.MaxValue * 2)]
        public void CircleGetArea_IfResultIsTooBig_ShouldThrowOverflowExeptioin(double radius)
        {
            Action action = () => new Circle(radius).GetArea();

            Assert.Throws<OverflowException>(action);
        }
    }
}
