namespace DesignPatterns.Decorator
{
    interface IMessage
    {
        public IDictionary<string, string> Header { get; set; }
        public string Body { get; set; }
    }
}
