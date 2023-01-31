namespace DesignPatterns.Strategy
{
    class InMemoryDatabase<T> : IRepository<T>
    {
        public Database Database => Database.InMemory;

        public void Add(T entity)
        {
            var type = typeof(T);
            var name = GetType().Name;
            Console.WriteLine($"Adding {name} entity {type}...");
            Console.WriteLine($"Added {name} entity {type}");
        }
    }
}
