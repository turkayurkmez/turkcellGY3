// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*
 * Sayısal
 *   -Tam sayı
 *   -Ondalıklı Sayı
 * Sözel
 * Mantıksal
 */

byte enKucuk = 255;

sbyte eksiOlabilenByte = -128;

short onaltiBit = -32767;



ushort sadecePozitif = 65535;
ulong bayaabüyüktamsayi = 18446744073709551615;

//8 - 16 - 32 - 64
//s - u  - u - u
double pi = 3.14;

float piFloat = 3.14f;
decimal piDecimal = 3.145900000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000001M;


//Sözel:
char symbol = '!';
string name = "Türkay";
String word = "bilgisayar";


//mantıksal
bool olurMu = false;


byte x = 255;
int y = 1000;

try
{
    checked
    {
        byte result = (byte)y;
        Console.WriteLine(result);
    }
}
catch (OverflowException)
{

    Console.WriteLine("toplam değeri byte sınırlarından büyük!");
}

Console.WriteLine("Lütfen kilonuzu girin:");
int kilo = int.Parse(Console.ReadLine());
Console.WriteLine("Lütfen boyunuzu cm olarak girin");
double boy = Convert.ToDouble(Console.ReadLine());

double bmi = kilo / (boy * boy);
Console.WriteLine(bmi);




