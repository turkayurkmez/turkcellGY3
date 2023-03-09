// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//1. Yol: Kaç elemandan oluşacağını biliyorum ama değerleri bilmiyorum.
string[] books = new string[8];
//2. Yol  Kaç elemandan oluşacağını da değerlini de biliyorum!
string[] seasons = new string[] { "İlkbahar", "Yaz", "Sonbahar", "Kış", "Başka" };

books[0] = "Yüzüklerin Efiendisi";
books[7] = "Otostopçunun Galaksi Rehberi";

Console.WriteLine(seasons[1]);
Console.WriteLine(seasons[seasons.Length - 1]);


/*
 * 42
 * Kırk iki
 * 
 * 52418
 * 
 * 13.695.598
 * 
 */
string[] onlar = { "", "on", "yirmi", "otuz", "kırk", "elli", "altmış", "yetmiş", "seksen", "doksan" };
string[] birler = { "", "bir", "iki", "üç", "dört", "beş", "altı", "yedi", "sekiz", "dokuz" };

Console.WriteLine("İki basamaklı bir sayı giriniz");
int number = Convert.ToInt32(Console.ReadLine());

int onlarBasamagindakiDeger = number / 10;
int birlerBasamagindakiDeger = number % 10;

Console.WriteLine($"{onlar[onlarBasamagindakiDeger]} {birler[birlerBasamagindakiDeger]}");

