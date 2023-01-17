using Polymorphism;

PrintData printData = new();

printData.Print("1");
printData.Print(1);
printData.Print(1.0);
printData.Print(1, 1);

Employee employee = new ();
employee.Work();
Driver driver = new ();
driver.Work();

Car car = new();
car.Prepare();
car.Run();