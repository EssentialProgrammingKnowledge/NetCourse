// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int? a = null;
Console.WriteLine(a.GetValueOrDefault());

Program? program = null;

program!.ToString();