using Shapes;

List<Shape> shapes = new List<Shape>()
{
    new Triangle(4,3,5),
    new Circle(3),
    new Square(3),
    new Square(100),
    new Triangle(7,24,23),
    new Circle(25),
    new Triangle(25,50),
    new Triangle(100)
};

foreach (var shape in shapes)
{
    Console.WriteLine(shape);
}

Console.ReadKey();