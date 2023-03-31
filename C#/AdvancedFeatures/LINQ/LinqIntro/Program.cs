// See https://aka.ms/new-console-template for more information
using LinqIntro;
using System.Diagnostics;

Console.WriteLine("Hello, World!");
//LINQ: Language INtegrated Query
//Bir koleksiyon ile kolayca iş yapabilmek.
var service = new ProductService();
var products = service.GetProducts();
var x = 5;

var anonymousType = new { Name = "Türkay", Age = 42 };

var nameAndPriceList = from p in products
                       where p.Price < 1000
                       select new { Ad = p.Name, Fiyat = p.Price };


nameAndPriceList.ToList().ForEach(x => Console.WriteLine($"......{x.Ad}\t{x.Fiyat}"));

var stopWatch = Stopwatch.StartNew();

var sameResultWithExt = products.Where(p => p.Price < 1000)
                                .Select(p => new { Ad = p.Name, Fiyat = p.Price })
                                .ToList();
stopWatch.Stop();
Console.WriteLine($"1. sorgunun süresi: {stopWatch.ElapsedMilliseconds.ToString()}");


Console.WriteLine("Ext 1");
sameResultWithExt.ForEach(x => Console.WriteLine($"......{x.Ad}\t{x.Fiyat}"));

stopWatch.Restart();

var same = products.ToList()
                   .Where(p => p.Price < 1000)
                   .Select(p => new { Ad = p.Name, Fiyat = p.Price });

stopWatch.Stop();
Console.WriteLine($"2. sorgunun süresi: {stopWatch.ElapsedMilliseconds.ToString()}");

Console.WriteLine();
Console.WriteLine("Ext 2");
same.ToList().ForEach(x => Console.WriteLine($"......{x.Ad}\t{x.Fiyat}"));

Console.WriteLine("-------- FirstOrDefault ---------------");
var product = products?.FirstOrDefault(p => p.Id == 6);

Console.WriteLine($"6 no'lu ürün {product?.Name}");

//hata verir! Kritere uyan birden fazla satır var:
//var sportProduct = products.SingleOrDefault(p => p.Description.Contains("Spor"));

var ordered1 = products.OrderBy(p => p.Price)
                       .ThenByDescending(st => st.Stock)

                       .ToList();
Console.WriteLine();
Console.WriteLine("---- Fiyata göre <...>");
ordered1.ForEach(orderedProduct => Console.WriteLine($"{orderedProduct.Name} {orderedProduct.Price} {orderedProduct.Stock}"));


var averagePrice = products.Average(p => p.Price);
var totalItem = products.Count(p => p.Description.Contains("Spor"));
Console.WriteLine($"ortalama: {averagePrice}, toplam: {products.Sum(p => p.Price)}, içinde spor geçenlerin sayısı: {totalItem}");


//en pahalı ürün:
var expensiveProduct = products.FirstOrDefault(p => p.Price == products.Max(pr => pr.Price));

Console.WriteLine($"en pahalı ürün: {expensiveProduct.Name} {expensiveProduct.Price} TL");

//JOIN
/* 
     Products           
     Id       Name        CatId                                   
    ---------------------------------
     1         A           1
     2         B           3 


     Categories
     Id       Name 
     --------------------------------
     1         X
     2         Y
     3         Z 

     Output
     1        A          X
     2        B          Z
     

 */


var categories = service.GetCategories();
var joinQuery = categories.Join(products,
                                category => category,
                                product => product.Category,
                                (category, product) => new { KategoriAdi = category.Name, Urun = product.Name }
                               )
                          .ToList();

Console.WriteLine();
Console.WriteLine("---- Join ----");
joinQuery.ForEach(res => Console.WriteLine($"{res.Urun} {res.KategoriAdi}"));

Console.WriteLine();
Console.WriteLine("Alternatif join");
var join2 = products.Select(pr => new { UrunAdi = pr.Name, Kategorisi = pr.Category?.Name }).ToList();

join2.ForEach(res => Console.WriteLine($"{res.UrunAdi} {res.Kategorisi}"));
//Group by

var group = products.GroupBy(pr => pr.Category?.Name,
                             result => new { result.Name, result.Price },
                             (category, products) => new
                             {
                                 Key = category,
                                 Adet = products.Count(),
                                 EnUcuz = products.Min(x => x.Price),
                                 EnPahali = products.Max(x => x.Price)
                             });

Console.WriteLine();
Console.WriteLine("-------------------- Group by ------------------");

foreach (var item in group)
{
    Console.WriteLine($"Kategori: {item.Key}");
    Console.WriteLine($"Adet : {item.Adet}");
    Console.WriteLine($"En ucuz ürün fiyatı: {item.EnUcuz}");
    Console.WriteLine($"En pahalı ürün fiyatı: {item.EnPahali}");



}

