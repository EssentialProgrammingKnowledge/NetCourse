using Reflections;
using System.Reflection;

var car = Car.Create("Porsche");
var type = car.GetType();
Console.WriteLine($"Car {type.Name}");
var methods = type.GetMethods();
foreach (var method in methods)
{
    Console.WriteLine($"{method.Name}");
}
car.ChangeName("Tester");
Console.WriteLine(car);
var changeNameMethod = type.GetMethod(nameof(Car.ChangeName));
changeNameMethod!.Invoke(car, new object[] { "BMW" });
Console.WriteLine(car);
var runCarMethod = type.GetMethod(nameof(Car.RunCar));
runCarMethod!.Invoke(car, null);
Console.WriteLine(car);
var idField = type.GetField($"<{nameof(Car.Id)}>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance);
idField.SetValue(car, Guid.NewGuid());
Console.WriteLine(car);
Console.ReadKey();