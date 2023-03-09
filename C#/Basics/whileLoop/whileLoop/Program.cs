// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Sayı bulmaca oyunu.
//Bilgisayar bir sayı tutsun.
//2. Adım Kullanıcı tahmin etsin.
//Tahmin ile sayı aynı olana dek; 2. Adım tekrarlansın.

Random randomNumberGenerator = new Random();

int puzzle = randomNumberGenerator.Next(0, 100);
bool isWin = false;
while (!isWin)
{
    Console.WriteLine("Lütfen tahmininizi girin:");
    int suggest = Convert.ToInt32(Console.ReadLine());
    if (suggest < puzzle)
    {
        Console.WriteLine("Yukarı!");
    }
    else if (suggest > puzzle)
    {
        Console.WriteLine("Aşağı");
    }
    else
    {
        Console.WriteLine("Bildiniz");
        isWin = true;
    }
}

int[] numbers = { 13, 46, 0, 1, 18, -9 };


Console.WriteLine(numbers[0]);
Console.WriteLine(numbers[1]);
Console.WriteLine(numbers[2]);
Console.WriteLine(numbers[3]);
Console.WriteLine(numbers[4]);
Console.WriteLine(numbers[5]);
/*
 * index değeri numbers array'inin eleman sayısından az olduğu sürece
 * number arrayinin her index'indeki değeri ekranda göster
 * ardından index değerini arttır.
 */
int index = 0;
while (index < numbers.Length)
{
    Console.WriteLine(numbers[index++]);

}

