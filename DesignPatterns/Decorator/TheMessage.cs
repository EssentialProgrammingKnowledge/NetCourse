namespace DesignPatterns.Decorator
{
    class TheMessage : IMessage
    {
        public IDictionary<string, string> Header { get; set; } = new Dictionary<string, string>();
        public string Body { get; set; } = nameof(TheMessage);
    }
}
