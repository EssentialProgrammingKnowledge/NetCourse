namespace SOLID
{
    internal class NonRelationDbClient : IDbClient
    {
        public T? Query<T>(string query)
        {
            Console.WriteLine(query);
            return default;
        }
    }
}
