// See https://aka.ms/new-console-template for more information
using LinqIntro;

Console.WriteLine("Hello, World!");
//LINQ: Language INtegrated Query
//Bir koleksiyon ile kolayca iş yapabilmek.

var products = new ProductService().GetProducts();
var x = 5;

var anonymousType = new { Name = "Türkay", Age = 42 };

var nameAndPriceList = from p in products
                       where p.Price < 1000
                       select new { Ad = p.Name, Fiyat = p.Price };


nameAndPriceList.ToList().ForEach(x => Console.WriteLine($"......{x.Ad}\t{x.Fiyat}"));

