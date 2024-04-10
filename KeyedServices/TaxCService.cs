namespace KeyedServices
{
    internal class TaxCService : ITaxService
    {
        public decimal CalculateGrossPrice(decimal price)
        {
            return price * 1.05M;
        }
    }
}
