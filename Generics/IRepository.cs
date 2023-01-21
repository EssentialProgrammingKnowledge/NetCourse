namespace Generics
{
    public interface IRepository<TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
        where TPrimaryKey : struct
    {
        TPrimaryKey Add(TEntity entity);
        TEntity? Get<T>(TPrimaryKey key)
            where T : class, IEntity<TPrimaryKey>;
    }
}
