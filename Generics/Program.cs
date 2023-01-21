using Generics;

var repository = new Repository<IEntity<int>, int>();
repository.Add(new Product { Id = 20, Name = "Product#1" });
repository.Add(new Product { Id = 20, Name = "Product#2" });
repository.Add(new Drink { Id = 20, Name = "Product#3" });

Console.WriteLine(repository.Get<Drink>(20)?.Id.ToString() ?? "null drink");
Console.WriteLine(repository.Get<Drink>(1)?.Id.ToString() ?? "null drink");
Console.WriteLine(repository.Get<Product>(2)?.Id.ToString() ?? "null product");