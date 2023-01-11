namespace ValueTypes
{
    class Program
    {
        public static void Main(string[] args)
        {
            // See https://aka.ms/new-console-template for more information
            Console.WriteLine("Hello, World!");
            int value = 2;
            float number2 = 12.2f;
            double number3 = 12.2;
            decimal number4 = 12.123M;
            char character = 'a';
            bool isValid = true;
            Price price = new Price();
        }

        enum Type
        {
            LOW, HIGH, MEDIUM
        }

        struct Price
        {
            public int ValueDecimal;
            public int ValuePointer;

            public Price(int valueDecimal, int valuePointer)
            {
                ValueDecimal = valueDecimal;
                ValuePointer = valuePointer;
            }
        }
    }
}