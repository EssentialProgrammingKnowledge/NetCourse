using Inheritance;

Car car = new ("BMW", 3200);
Motorcycle moto = new ("Honda", 600);

Console.WriteLine(car);
Console.WriteLine(moto);

StartVehicle(car);
StartVehicle(moto);

Console.WriteLine(car);
Console.WriteLine(moto);

static void StartVehicle(Vehicle vehicle)
{
    vehicle.Start();
}