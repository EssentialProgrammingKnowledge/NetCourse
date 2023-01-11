namespace ConstAndVariables
{
    class Program
    {
        const int NEXT_YEAR = 2023;

        public static void Main(string[] args)
        {
            // See https://aka.ms/new-console-template for more information
            Console.WriteLine("Hello, World!");
            int nextYear = 2023;
            Console.WriteLine(NEXT_YEAR);
            Console.WriteLine(nextYear);
            nextYear = 2024;
            Console.WriteLine(nextYear);
            Console.WriteLine("From Test()");
            Test();
            Console.WriteLine("Enter next year");
            string? yearString = Console.ReadLine();
            bool isValid = int.TryParse(yearString, out nextYear);
            Console.WriteLine($"Did it parse {isValid}");
            Console.WriteLine($"Next year {nextYear}");
            SetNextYear(out nextYear);
        }

        private static void SetNextYear(out int year)
        {
            year = 2040;
        }

        private static void Test()
        {
            Console.WriteLine(NEXT_YEAR);
        }
    }
}