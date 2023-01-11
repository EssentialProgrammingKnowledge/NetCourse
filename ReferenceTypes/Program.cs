// See https://aka.ms/new-console-template for more information
using ReferenceTypes;

Console.WriteLine("Hello, World!");

int firstNumber = 20;
int secondNumber = firstNumber;

Console.WriteLine(firstNumber);   // 20
Console.WriteLine(secondNumber);  // 20

secondNumber = 25;

Console.WriteLine(firstNumber); // 20
Console.WriteLine(secondNumber); // 25

var price23 = new Price();
Price price = new Price();
price.Value = 10;
Price price2 = price;
Console.WriteLine("--------------------------------");
Console.WriteLine(price.Value); // 10
Console.WriteLine(price2.Value); // 10
price2.Value = 300;
Console.WriteLine(price.Value); // 10
Console.WriteLine(price2.Value); // 300

string characters = $"wartosc {price.Value}";
Console.WriteLine(characters);
Console.WriteLine("           ciag znakow");
Console.Write("           \r");
Console.WriteLine("ciag znakow");