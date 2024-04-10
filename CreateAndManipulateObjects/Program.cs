using CreateAndManipulateObjects;

var carWithPrimaryConstructor = new CarWithPrimaryConstructor("first", 10)
{
    Color = "Green"
};
Console.WriteLine(carWithPrimaryConstructor);
var carWithPrimaryConstructor2 = new CarWithPrimaryConstructor("second", 10, "Green");
Console.WriteLine(carWithPrimaryConstructor2);
Console.WriteLine("----------");

var carList = new List<Car>()
{
    new ("test", 10),
    new ("test2", 12),
};

List<Car> carList2 =
[
    new Car("test", 10),
    new Car("test2", 12),
];

List<Car> carList3 =
[.. carList, .. carList2, new Car("test3", 14) ];

string[] marks1 = ["5", "4", "3", "2", "1"];
string[] marks2 = ["1", "2", "3", "4", "5", "6", "5", "5", "4", "2",
                       "2", "4", "6", "3", "3", "1", "5", "2", "5", "3"];
string[] marks3 = [.. marks1, .. marks2, "4"];

Console.WriteLine("---- carList ----");
carList.ForEach(Console.WriteLine);
Console.WriteLine("---- carList2 ----");
carList2.ForEach(Console.WriteLine);
Console.WriteLine("---- carList3 ----");
carList3.ForEach(Console.WriteLine);
Console.WriteLine("---- marks1 ----");
Array.ForEach(marks1, Console.WriteLine);
Console.WriteLine("---- marks2 ----");
Array.ForEach(marks2, Console.WriteLine);
Console.WriteLine("---- marks3 ----");
Array.ForEach(marks3, Console.WriteLine);
