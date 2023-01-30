namespace LINQBasics
{
    internal class Item
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = nameof(Item);
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
