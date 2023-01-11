// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] marks = new int[] { 1, 2, 3, 4, 5 };
// 1 element indeks 0
marks[0] = 5;
marks[4] = 4;

for (int i = 0; i < 5; i++)
{
    marks[i] = 5 - i;
}

for (int i = 0; i < 5; i++)
{
    Console.WriteLine(marks[i]);
}

Console.WriteLine($"length: {marks.Length}");
Console.WriteLine($"last element: {marks[marks.Length - 1]}");

Console.WriteLine(Array.IndexOf(marks, 3));

Array.Sort(marks);


for (int i = 0; i < marks.Length; i++)
{
    Console.WriteLine(marks[i]);
}

int[,] numbers = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6, } };

Console.WriteLine(numbers.Length);

for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        Console.Write(numbers[i, j]);
    }
    Console.WriteLine();
}

List<int> numbers2 = new List<int>();
numbers2.Add(1000);
numbers2.Add(2);
numbers2.Add(5);
numbers2.Add(10);
Console.WriteLine(numbers2[0]);

foreach(int i in numbers2)
{
    Console.WriteLine(i);
}

numbers2.Sort();
Console.WriteLine();