using System.Text;

string appendCharacter = "text";

int[] samples = new int[2] { 100000, 1000000 };

foreach (int sample in samples)
{
    var startTime = DateTime.UtcNow;
    TestAppendString(sample, "", appendCharacter);
    var endTime = DateTime.UtcNow;
    Console.WriteLine($"Time: {endTime.Subtract(startTime)}");
    startTime = DateTime.UtcNow;
    TestAppendStringBuilder(sample, new StringBuilder(), appendCharacter);
    Console.WriteLine($"Time: {endTime.Subtract(startTime)}");
    endTime = DateTime.UtcNow;
}

static void TestAppendString(int n, string str, string appendCharacter)
{
    for (int i = 1; i <= n; i++)
    {
        str += appendCharacter;
    }
}

static void TestAppendStringBuilder(int n, StringBuilder str, string appendCharacter)
{
    for (int i = 1; i <= n; i++)
    {
        str.Append(appendCharacter);
    }
}