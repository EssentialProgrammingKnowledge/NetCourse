namespace DesignPatterns.Strategy
{
    class MongoClient : IMongoClient
    {
        public void Connect()
        {
            Console.WriteLine("Connecting...");
            Console.WriteLine("Connected");
        }
    }

}
