// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// for, foreach, while, do while

// 0 - 9
for (int i = 0; i < 11; i++)
{
    if (i == 10)
    {
        break;
    }

    if (i == 0)
    {
        continue;
    }

    // break, continue, goto
    Console.WriteLine(i);
}
goto Test;

// silnia 5!=1*2*3*4*5

Test:
    Console.WriteLine("after goto");

int silnia = 5;
int result = 1;
for (int i = 1; i <= silnia; i++)
{
    result *= i;
}

Console.WriteLine(result);

int a = 0;
while(a < 2)
{
    a++;
    Console.WriteLine(a);
}

a = 0;
do
{
    Console.WriteLine("cokolwiek");
    a++;
}
while (a == 0);