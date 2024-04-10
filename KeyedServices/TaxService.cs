namespace KeyedServices
{
    internal class TaxService : ITaxService
    {
        public decimal CalculateGrossPrice(decimal price)
        {
            return price * 1.23M;
        }
    }
}
