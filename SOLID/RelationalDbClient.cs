namespace SOLID
{
    public class RelationalDbClient : IDbClient
    {
        public T? Query<T>(string query)
        {
            Console.WriteLine(query);
            return default;
        }
    }
}
