namespace DesignPatterns.FactoryMethod
{
    interface ICurrencyDownloaderFactory
    {
        ICurrencyDownloader CreateCurrencyDownloader(CurrencyWebsite currencyWebsite);
    }
}
