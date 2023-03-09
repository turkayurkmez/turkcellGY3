// See https://aka.ms/new-console-template for more information

int[] numbers = { 13, 46, 0, 1, 18, -9 };
for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);
}


string[] countries = { "Türkiye", "Almanya", "Hollanda", "İsveç", "Kıbrıs" };
Console.WriteLine("Bir ülke giriniz");
string country = Console.ReadLine();

bool isFind = false;

for (int i = 0; i < countries.Length; i++)
{
    if (countries[i] == country)
    {
        isFind = true;
    }
}

if (isFind)
{
    Console.WriteLine("Vardır");
}
else
{
    Console.WriteLine("Yoktur");
}


