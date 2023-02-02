namespace OwnAttributes
{
    internal interface ICacheableEntities
    {
        IEnumerable<Type> GetCacheableEntities();
    }
}
