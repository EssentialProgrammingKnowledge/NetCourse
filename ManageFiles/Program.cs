using ManageFiles;
using System.Text;

static async Task SaveProductsToFile(string path, Product product)
{
    await File.AppendAllLinesAsync(path, new string[] { product.ToString() }, Encoding.UTF8);
}

static async Task<List<Product>> ReadProductsFromFile(string path)
{
    var products = new List<Product>();

    await foreach (var line in File.ReadLinesAsync(path, Encoding.UTF8))
    {
        if (string.IsNullOrWhiteSpace(line))
        {
            continue;
        }
        var lineSplited = line.Split(';');
        var idParsed = int.TryParse(lineSplited[0], out var id);
        var priceParsed = int.TryParse(lineSplited[0], out var price);

        if (!idParsed || !priceParsed)
        {
            continue;
        }
        products.Add(new Product { Id = id, Name = lineSplited[1], Price = price });
    }

    return products;
}

var currentDirectory = Environment.CurrentDirectory;
var projectDirectory = Directory.GetParent(currentDirectory)?.Parent?.Parent?.FullName;
var filePath = projectDirectory + Path.DirectorySeparatorChar + "file.csv";

var product = new Product { Id = 3, Name = "Product#3", Price = 300M };
await SaveProductsToFile(filePath, product);
var products = await ReadProductsFromFile(filePath);
foreach (var productFromFile in products)
{
    Console.WriteLine(productFromFile);
}
