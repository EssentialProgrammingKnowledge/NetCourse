using SOLID;

var square = new Square() { Side = 20 };

var calculator = new PerimeterCalculator();
Console.WriteLine($"Square perimeter: ${calculator.Calculate(square)}");
var animals = new List<Animal>() { new Dog(), new Fish() };

foreach (var animal in animals)
{
    animal.Run();
}