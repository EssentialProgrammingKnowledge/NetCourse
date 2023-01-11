using Conditions;

Item item = new Item();
int i = 0;

if (item is not null && i == 1)
{
    Console.WriteLine("Non null");
}
else if (i == 0)
{
    Console.WriteLine("i == 0");
}
else
{
    Console.WriteLine("null");
}

i = 1;
string text = i == 0 ? "i=0" : $"i={i}";
Console.WriteLine(text);

switch (i)
{
    case 1: // i == 1
        Console.WriteLine("abc");
        break;
    default:
        Console.WriteLine("default");
        break;
}

i = 0;
text = i switch
{
    1 => "text213",
    _ => "default"
};

Console.WriteLine(text);