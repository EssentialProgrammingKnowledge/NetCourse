// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int variable = 0;

bool isTrue = ((variable != 1 || variable <= 10) && (variable == 10)); // and, or
Console.WriteLine(isTrue);

Console.WriteLine("-------------------------------");

double firstNumber = 4;
double secondNumber = 2;

double result = firstNumber + secondNumber; // 6
Console.WriteLine(result);

result = firstNumber - secondNumber; // 2
Console.WriteLine(result);

result = firstNumber * secondNumber; // 8
Console.WriteLine(result);

result = firstNumber / secondNumber; // 2
Console.WriteLine(result);

Console.WriteLine("--------------------------");

int i = 0;
Console.WriteLine(i); // 0
i = i + 1;
Console.WriteLine(i); // 1
i += 1;
Console.WriteLine(i); // 2
i++;
Console.WriteLine(i); // 3

i--;
Console.WriteLine(i); // 2
i = i - 1;
Console.WriteLine(i); // 1
i -= 1;
Console.WriteLine(i); // 0

string text = "this is simple text";
string nextText = " not only text";
string concatedString = text + nextText;
Console.WriteLine(concatedString);