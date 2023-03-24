// See https://aka.ms/new-console-template for more information
using AnonymousTypes;

var value = new { Name = "Türkay", Age = 42 };
var random = new Random();
var user = new { Info = value, RanomNumber = random.Next(1, 50) };
Console.WriteLine($"{user.Info.Name} isimli kullanıcının rastgele sayısı = {user.RanomNumber.ToString()}");


//Bir metodun, geriye döndürdüğü değer manüpile edilmiş bir koleksiyon veya bir tip olabilir. Bu sonucu yakalayabilmek için "var" keyword'ü kullanılır.
//
Console.WriteLine(value.Name);
var product = new Product() { Name = "Klavye", Price = 250, Id = 1, Description = "Geliştiriciler için klavye!" };
//product.Name = "Klavye";
//product.Price = 250;

//useAnonym(value);

//void useAnonym(object value)
//{
//   value.
//}