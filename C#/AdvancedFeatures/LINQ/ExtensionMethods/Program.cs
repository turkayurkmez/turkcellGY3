// See https://aka.ms/new-console-template for more information
using ExtensionMethods;

Console.WriteLine("Hello, World!");
int number = 8;
Console.WriteLine(number.GetSquare());
string name = "Order Details";
Console.WriteLine(name.MergeWords());
string password = "123";
Console.WriteLine(password.GetPasswordStrength());

Console.WriteLine(new Random().NextWord(6));