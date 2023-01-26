using Shapes.Validator;

namespace Shapes
{
    public class Triangle : Shape
    {
        private double a;
        public double A { get => a; init => MyValidator.SetPositiveDoubleValue(value, out a); }
        private double b;
        public double B { get => b; init => MyValidator.SetPositiveDoubleValue(value, out b); }
        private double c;
        public double C { get => c; init => MyValidator.SetPositiveDoubleValue(value, out c); }

        public bool IsRightAngled { get; init; }

        public override int Number_Of_Sides => 3;

        public Triangle(double a) : this(a, a) { }
        public Triangle(double a, double b) : this(a, a, b) { }
        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;

            IsRightAngled = IsTriangleRightAngled();
        }

        public override double GetArea()
        {
            MyValidator.SetPositiveDoubleValue((A + B + C) / 2, out double p);
            MyValidator.SetPositiveDoubleValue(Math.Sqrt(p * (p - A) * (p - B) * (p - C)), out double result);
            return result;
        }

        public override async Task<double> GetAreaAsync()
        {
            return await Task.Run(GetArea);
        }

        public override string ToString()
        {
            return $"The shape is a triangle with the area of {GetArea()}. Is it right-angled: {IsRightAngled}";
        }

        private bool IsTriangleRightAngled()
        {
            if (Math.Pow(A, 2) == (Math.Pow(B, 2) + Math.Pow(C, 2)) ||
                Math.Pow(B, 2) == (Math.Pow(A, 2) + Math.Pow(C, 2)) ||
                Math.Pow(C, 2) == (Math.Pow(A, 2) + Math.Pow(B, 2)))
                return true;

            return false;
        }
    }
}
