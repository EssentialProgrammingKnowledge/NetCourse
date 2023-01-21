namespace Generics
{
    public class Product : IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
    }
}
