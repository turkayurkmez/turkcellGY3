// See https://aka.ms/new-console-template for more information
using DbFirstSample.Data;
using Microsoft.EntityFrameworkCore;

var products = new NorthwindContext().Products.Include(p => p.Category).ToList();
products.ForEach(p => Console.WriteLine(@$"{p.ProductName}......{p.UnitPrice}"));

Console.WriteLine("------------------------------------------------------");
var productAndCategoryName = products.Select(p => new { p.ProductName, p.UnitPrice, p.Category?.CategoryName }).ToList();

productAndCategoryName.ForEach(p => Console.WriteLine(@$"{p.ProductName}......{p.CategoryName}"));
