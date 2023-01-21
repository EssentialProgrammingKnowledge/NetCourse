using AbstractClassAndInterface;

var service = new ProductService();
((IProductService)service).Add(new Product());
service.Add(new Product());
Console.WriteLine(ProductService.GetProductName());