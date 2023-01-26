using Shapes.Validator;

namespace Shapes
{
    public class Square : Shape
    {
        private double _length;
        public double Length { get => _length; init => MyValidator.SetPositiveDoubleValue(value, out _length); }

        public override int Number_Of_Sides => 4;

        public Square(double length)
        {
            Length = length;
        }

        public override double GetArea()
        {
            MyValidator.SetPositiveDoubleValue(Math.Pow(Length, 2), out double result);
            return result;
        }

        public override async Task<double> GetAreaAsync()
        {
            return await Task.Run(GetArea);
        }

        public override string ToString()
        {
            return $"The shape is a square with the area of {GetArea()}";
        }
    }
}
