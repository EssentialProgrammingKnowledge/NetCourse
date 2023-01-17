namespace Polymorphism
{
    public class PrintData
    {
        public void Print(int a)
        {
            Console.WriteLine("Print number: {0}", a);
        }

        public void Print(int a, int b)
        {
            Console.WriteLine("Print number: {0} {1}", a, b);
        }

        public void Print(double a)
        {
            Console.WriteLine("Print number: {0}", a);
        }

        public void Print(long a)
        {
            Console.WriteLine("Print number: {0}", a);
        }

        public void Print(string a)
        {
            Console.WriteLine("Print number: {0}", a);
        }
    }
}
