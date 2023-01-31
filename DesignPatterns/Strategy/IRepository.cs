namespace DesignPatterns.Strategy
{

    interface IRepository<T>
    {
        Database Database { get; }
        void Add(T entity);
    }
}
