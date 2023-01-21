namespace AbstractClassAndInterface
{
    public interface IProductService
    {
        void Update(Product product);
        static abstract string GetProductName();

        int Add(Product product)
        {
            return 0;
        }
    }
}
