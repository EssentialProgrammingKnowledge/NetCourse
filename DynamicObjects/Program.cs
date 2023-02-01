using DynamicObjects;

var provider = new Provider();
provider.Add<ITest, Test>();
provider.Add<ISender, Sender>();
provider.Add<ISendManager, SendManager>();
provider.Add<OnlyImplementation>();
var sendManager = provider.ConstructObject<ISendManager>();
sendManager.SendMessage();

class SendManager : ISendManager
{
    private readonly ISender _sender;
    public SendManager(ISender sender)
    {
        _sender = sender;
    }

    public void SendMessage()
    {
        Console.WriteLine("Sending message");
        _sender.Send();
        Console.WriteLine("Sent message");
    }
}

interface ISendManager
{
    void SendMessage();
}

class Sender : ISender
{
    public Sender(ITest test)
    {
        Console.WriteLine($"Init Sender with params {test.GetType().FullName}");
    }

    public void Send()
    {
        Console.WriteLine("Sending message");
    }
}

interface ISender
{
    void Send();
}

class OnlyImplementation
{
    public OnlyImplementation()
    {
        Console.WriteLine("Init OnlyImplementation");
    }
}

class Test : ITest
{
    public Test(OnlyImplementation onlyImplementation)
    {
        Console.WriteLine($"Init Test with params {onlyImplementation.GetType().FullName}");
    }
}

interface ITest
{

}