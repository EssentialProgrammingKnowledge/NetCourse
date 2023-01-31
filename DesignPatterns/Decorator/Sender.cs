using System.Text.Json;

namespace DesignPatterns.Decorator
{
    class Sender : ISender
    {
        public void Send(IMessage message)
        {
            var jsonString = JsonSerializer.Serialize(message);
            Console.WriteLine($"Sent! Serialized message:\n{jsonString}");
        }
    }
}
