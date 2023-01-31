namespace DesignPatterns.FactoryMethod
{
    class IbanCurrencyDownloader : ICurrencyDownloader
    {
        public void Download(Currency currency)
        {
            Console.WriteLine($"{DateTime.UtcNow} IBAN Currency downloaded {currency.Code} Rate: {new Random().Next(1, 5)}");
        }
    }
}
