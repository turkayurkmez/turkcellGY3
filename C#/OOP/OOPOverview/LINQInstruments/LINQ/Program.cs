// See https://aka.ms/new-console-template for more information
using LINQ;

Console.WriteLine("Hello, World!");

var productService = new ProductService();
var products = productService.GetProducts();

//ürünlerin sadece ad ve fiyatları
//:
var result = from product in products
             where product.Description.Contains("Android")
             orderby product.Name
             select new { UrunAdi = product.Name, Fiyat = product.Price };


result.ToList().ForEach(x => Console.WriteLine($"{x.UrunAdi}\t{x.Fiyat}"));

var sameResult = products.Where(p => p.Description.Contains("Android"))
                         .Select(pr => new { UrunAdi = pr.Name, Fiyat = pr.Price })
                         .OrderBy(opr => opr.UrunAdi)
                         .ToList();

sameResult.ForEach(x => Console.WriteLine(x));

//var sameResult2 = products.ToList()
//                          .Where(p => p.Description.Contains("Android"))
//                         .Select(pr => new { UrunAdi = pr.Name, Fiyat = pr.Price })
//                         .OrderBy(opr => opr.UrunAdi)
//                         .ToList();


//sameResult2.ForEach(x => Console.WriteLine(x));

var findingProduct = products.FirstOrDefault(p => p.Id == 3);
Console.WriteLine($"Bulunan ürün: {findingProduct?.Name}");

//Find:
var ios = products.Find(p => p.Id == 4);

var orderByRating = products.OrderByDescending(p => p.Rating)
                            .ThenBy(p => p.Name)
                            .ToList();

orderByRating.ForEach(p => Console.WriteLine($"{p.Name} - {p.Description} - {p.Rating}"));

var totalPrice = products.Sum(p => p.Price);
var averagePrice = products.Average(p => p.Price);
var productsWithNotStock = products.Count(p => !p.IsInStock);
var maxPrice = products.Max(p => p.Price);

var expensiveProducts = products.Where(p => p.Price == maxPrice).ToList();

expensiveProducts.ForEach(p => Console.WriteLine($"En pahalı ürün: {p.Name} {p.Price}"));
//Console.WriteLine($"{expensiveProduct.}");

/*
 *   Products
 *   Id        Name       CategoryId
 *   ---------------------------------------------
 *   1       Xiaomi         1 -- FK 
 *   2       Dell           2
 *   3       Pantolon       3
 *   
 *   
 *   Categories
 *   Id     Name
 *   ---------------------------------------------
 *  PK <-- 1     Telefon
 *   2     Laptop
 *   3     Giyim
 *   4     Kozmetik
 *   
 *   
 */
var products2 = productService.GetProducts();
List<Category> categories = productService.GetCategories();
Console.WriteLine();
Console.WriteLine("---- join ----");

//Ürün ad ve fiyatı ile bu ürünün kategori adını ekranda göstermek istiyoruz.
var joinQuery = categories.Join(products2,
                                category => category,
                                product => product.Category,
                                (category, product) => new { Ad = product.Name, Fiyat = product.Price, Kategorisi = category.Name })
                .ToList();


joinQuery.ForEach(pr => Console.WriteLine($"{pr.Ad} {pr.Fiyat} {pr.Kategorisi}"));

var sameWithJoin = products.Select(p => new { Ad = p.Name, Fiyat = p.Price, Kategorisi = p.Category?.Name })
                           .ToList();

Console.WriteLine("Join alternatif:");
sameWithJoin.ForEach(pr => Console.WriteLine($"{pr.Ad} {pr.Fiyat} {pr.Kategorisi}"));


var group = products.GroupBy(product => product.Category.Name,
                             product => new { product.Name, product.Price, product.Rating },
                             (cname, products) => new
                             {
                                 Key = cname,
                                 Count = products.Count(),
                                 Min = products.Min(x => x.Price),
                                 Max = products.Max(x => x.Price),
                                 AverageRating = products.Average(x => x.Rating)
                             }


                            ).ToList();

Console.WriteLine("KategoriAdi    \tAdet\tMin\tMaks\tOrtalama");
Console.WriteLine("-------------------------------------------------");
group.ForEach(x =>
{
    Console.WriteLine($"{x.Key}   \t{x.Count}\t{x.Min}\t{x.Max}\t{x.AverageRating}");
});

string message = products.Any(p => p.Id == 9) ? "Vardır" : "Yoktur";

products.Skip(1).Take(3);









