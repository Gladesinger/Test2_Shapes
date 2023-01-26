namespace Shapes.Validator
{
    internal static class MyValidator
    {
        public static void SetPositiveDoubleValue(double number_to_set, out double number)
        {
            if (number_to_set < 0)
                throw new ArgumentException("Argument can't be negative");

            if (number_to_set is double.PositiveInfinity or double.NegativeInfinity or double.NaN)
                throw new OverflowException("Value was out of range for double type");

            number = number_to_set;
        }
    }
}
