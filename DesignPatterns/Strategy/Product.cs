namespace DesignPatterns.Strategy
{
    class Product
    {
        public Guid Id => Guid.NewGuid();
        public string Name { get; set; }
    }
}
