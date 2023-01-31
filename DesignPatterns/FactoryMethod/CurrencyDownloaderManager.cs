namespace DesignPatterns.FactoryMethod
{
    class CurrencyDownloaderManager
    {
        public void DownloadCurrency(CurrencyWebsite currencyWebsite, Currency currency)
        {
            ICurrencyDownloaderFactory currencyDownloaderFactory = new CurrencyDownloaderFactory();
            var downloader = currencyDownloaderFactory.CreateCurrencyDownloader(currencyWebsite);
            downloader.Download(currency);
        }
    }
}
