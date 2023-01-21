namespace Generics
{
    public class Drink : IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public int Capacity { get; set; } = 500;
    }
}
