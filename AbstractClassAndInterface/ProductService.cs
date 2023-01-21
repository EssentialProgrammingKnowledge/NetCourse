namespace AbstractClassAndInterface
{
    internal class ProductService : IProductService
    {
        public static string GetProductName() => nameof(Product);

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }

        public int Add(Product product)
        {
            return 1;
        }
    }
}
