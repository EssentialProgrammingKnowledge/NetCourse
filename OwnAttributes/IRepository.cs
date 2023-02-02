namespace OwnAttributes
{
    internal interface IRepository<T>
    {
        void Add(T entity);
        IEnumerable<T> GetAll();
    }
}
