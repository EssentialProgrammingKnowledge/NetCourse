namespace Generics
{
    internal class Repository<TEntity, TPrimaryKey> : IRepository<TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
        where TPrimaryKey : struct
    {
        private readonly Dictionary<string, List<TEntity>> _collections = new();

        public TPrimaryKey Add(TEntity entity)
        {
            var type = entity.GetType();
            var containsList = _collections.TryGetValue(type.Name, out var list);

            if (!containsList)
            {
                list = new List<TEntity>();
                entity.Id = GetNextId(list);
                list.Add(entity);
                _collections.Add(type.Name, list);
                return entity.Id;
            }

            entity.Id = GetNextId(list!);
            list!.Add(entity);

            return entity.Id;
        }

        public TEntity? Get<T>(TPrimaryKey key)
            where T : class, IEntity<TPrimaryKey>
        {
            var type = typeof(T);
            var containsList = _collections.TryGetValue(type.Name, out var list);
            if (!containsList)
            {
                return null;
            }

            foreach(var entity in list!)
            {
                if (entity.Id.Equals(key))
                {
                    return entity;
                }
            }

            return null;
        }

        private TPrimaryKey GetNextId(List<TEntity> entities)
        {
            if (entities.Count == 0)
            {
                return GetNextValue(default);
            }

            return GetNextValue(entities[entities.Count - 1].Id);
        }

        private TPrimaryKey GetNextValue(TPrimaryKey key)
        {
            var type = key.GetType();

            if (type == typeof(int)) 
            {
                object value = key;
                object nextValue = ((int)value) + 1;
                return (TPrimaryKey)nextValue;
            }
            if (type == typeof(long))
            {
                object value = key;
                object nextValue = ((long)value) + 1;
                return (TPrimaryKey)nextValue;
            }
            if (type == typeof(Guid)) 
            {
                object nextValue = Guid.NewGuid();
                return (TPrimaryKey)nextValue;
            }
            else
            {
                return default;
            }
        }
    }
}
