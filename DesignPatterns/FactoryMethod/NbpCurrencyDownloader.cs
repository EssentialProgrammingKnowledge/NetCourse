namespace DesignPatterns.FactoryMethod
{
    class NbpCurrencyDownloader : ICurrencyDownloader
    {
        public void Download(Currency currency)
        {
            Console.WriteLine($"{DateTime.UtcNow} NBP Currency downloaded {currency.Code} Rate: {new Random().Next(1, 5)}");
        }
    }
}
