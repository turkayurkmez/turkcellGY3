// See https://aka.ms/new-console-template for more information
using ExtensionMethods;

Console.WriteLine("Hello, World!");

int number = 8;
Console.WriteLine(number.GetSquare());
Console.WriteLine(DateTime.Now.TotalWorkDays());

Random random = new Random();
for (int i = 0; i < 10; i++)
{
    int length = random.Next(3, 6);
    Console.Write(random.NextString(length) + " ");
}
