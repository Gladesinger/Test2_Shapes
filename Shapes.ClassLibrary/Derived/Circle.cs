using Shapes.Validator;

namespace Shapes
{
    public class Circle : Shape
    {
        private double _radius;
        public double Radius { get => _radius; init => MyValidator.SetPositiveDoubleValue(value, out _radius); }

        public override int Number_Of_Sides => 0;

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            MyValidator.SetPositiveDoubleValue(Math.PI * Math.Pow(Radius, 2), out double res);
            return res;
        }

        public override async Task<double> GetAreaAsync()
        {
            return await Task.Run(GetArea);
        }

        public override string ToString()
        {
            return $"The shape is a circle with the area of {GetArea()}";
        }
    }
}
