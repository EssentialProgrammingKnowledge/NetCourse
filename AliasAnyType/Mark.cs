namespace AliasAnyType
{
    internal class Mark(int value)
    {
        public int Value { get; set; } = value;

        public override string ToString()
        {
            return $"{Value}";
        }
    }
}
