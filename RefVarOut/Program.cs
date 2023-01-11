static void SetTwoRef(ref int i)
{
    i = 2;
}

static void SetTwoOut(out int i)
{
    i = 2;
}

int number = 0;
SetTwoRef(ref number);
Console.WriteLine($"number {number}");

int number2;
SetTwoOut(out number2);
Console.WriteLine($"number {number2}");

var intNumber = 20M;
Console.WriteLine(intNumber);