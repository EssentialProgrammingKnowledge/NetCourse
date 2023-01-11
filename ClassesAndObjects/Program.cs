// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Vehicle? vehicle = new () { Name = "Vehicle#1", EngineCapacity = 1000 };
Console.WriteLine($"Vehicle1= {vehicle}");
vehicle = null;
Vehicle vehicle2 = vehicle ?? new ("Vehicle#2", 2000);
vehicle2.Start();
Console.WriteLine($"Vehicle2= {vehicle2}");