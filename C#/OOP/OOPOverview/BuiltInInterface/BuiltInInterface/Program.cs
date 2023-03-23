// See https://aka.ms/new-console-template for more information
using BuiltInInterface;

Console.WriteLine("Hello, World!");


Product product = new Product() { Id = 1, Name = "Bisiklet", Price = 3500, Stock = 150 };
Product product2 = new Product() { Id = 2, Name = "Tenis Raketi", Price = 250, Stock = 1000 };
Product product3 = new Product() { Id = 3, Name = "Koşu bandı", Price = 15000, Stock = 100 };

ProductCollection productCollection = new ProductCollection();
productCollection.Add(product);
productCollection.Add(product2);
productCollection.Add(product3);

productCollection.SortProducts();

foreach (var productItem in productCollection)
{
    Console.WriteLine($"{productItem.Id}\t{productItem.Name}\t{productItem.Price}\t{productItem.Stock}");
}

string kelime = "endoplazmik";

foreach (var item in kelime)
{

}