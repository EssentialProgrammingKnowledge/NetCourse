namespace DelegateAnnonymousFunctionsLambda;

delegate string ChangeText(string text);

public class Program
{
    private static string text = "abc";

    public static string AddText(string i)
    {
        text += i;
        return text;
    }

    public static string GetText()
    {
        return text;
    }

    public static void Main(string[] args)
    {
        ChangeText changeText = new (AddText);
        changeText(" abc123");
        Console.WriteLine("Wartość tekstu: {0}", GetText());
        changeText += changeText;
        changeText(" test 123");
        Console.WriteLine("Wartość tekstu: {0}", GetText());
        Func<string, string> func = delegate (string t) { text += t; return text; };
        func(" from Func<>()");
        Console.WriteLine("Wartość tekstu: {0}", GetText());
        Func<int, int, int> func2 = (a, b) => a + b;
        ShowResult(Add(1, 2));
        ShowResult(func2(1, 2));
        Action<int> action = delegate (int result) { Console.WriteLine(result); };
        Action<int> action2 = (result) => Console.WriteLine(result);
        action(Add(3, 4));
        action2(Add(3, 4));
        Console.ReadKey();
    }

    public static void ShowResult(int result) => Console.WriteLine(result);

    public static int Add(int a, int b)
    {
        return a + b;
    }
}