namespace Shapes
{
    public abstract class Shape
    {
        public abstract int Number_Of_Sides { get; }

        public abstract double GetArea();
        public abstract Task<double> GetAreaAsync();
    }
}
