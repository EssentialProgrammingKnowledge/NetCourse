namespace SOLID
{
    public interface IDbClient
    {
        T? Query<T>(string query);
    }
}
