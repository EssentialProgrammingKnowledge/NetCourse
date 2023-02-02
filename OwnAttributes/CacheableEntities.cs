using System.Reflection;

namespace OwnAttributes
{
    internal class CacheableEntities : ICacheableEntities
    {
        private readonly IList<Type> _cacheableEntities = new List<Type>();

        public CacheableEntities()
        {
            var assembly = Assembly.GetExecutingAssembly();
            _cacheableEntities = assembly.GetTypes()
                .Where(type => Attribute.IsDefined(type, typeof(Cacheable))).ToList();
        }

        public IEnumerable<Type> GetCacheableEntities()
        {
            return _cacheableEntities;
        }
    }
}
