// See https://aka.ms/new-console-template for more information


using LiskovSubstution;

Console.WriteLine("Hello, World!");

/*
 * Liskov diyor ki:
 *  Bir sınıf bir başkasına miras veriyorsa; bu sınıflar BİRBİRLERİNİN YERİNE KULLANILABİLİR olmalı.
 *  Bir sınıf miras aldığı sınıfın özelliklerini AYNEN KULLANMAK ZORUNDADIR
 *  
 *  
 */
//Rectangle rectangle = new Rectangle() { Width = 5, Height = 4 };
//Console.WriteLine($"Rect: {rectangle.GetArea()}");
//Square square = new Square() { Width = 10 };
//Console.WriteLine($"SQ: {square.GetArea()}");

//var rectangle2 = GeometryLibrary.RectangleFactory();
//rectangle2.Width = 10;
//rectangle2.Height = 5;

//Console.WriteLine($"rect2: {rectangle2.GetArea()}");

var rect = GeometryLibrary.RectangleFactory(5);
Console.WriteLine($"Dörtgen alanı: {rect.GetArea()}");



