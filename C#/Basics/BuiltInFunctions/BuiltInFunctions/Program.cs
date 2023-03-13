// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string word = "bilgisayari";
Console.WriteLine(word.ToUpper());
Console.WriteLine(word.Substring(5));

int index = word.IndexOf('i', 2);
Console.WriteLine(index);

/*
 * harf bulamaz ise -1 döndürüyor.
 * belirli bir noktadan aramaya başlayabiliyor.
 * İlk karşılaştığı index değerini veriyor.
 * 
 *  -1 sonucu almadığı sürece
 *     Bir başlangıç noktasından harfi ara
 *     Başlangıç noktasını bulunandan bir fazlası yap
 */

int startIndex = 0;
bool isFind = word.IndexOf('i', startIndex) != -1;
while (isFind)
{
    int findingIndex = word.IndexOf('i', startIndex);
    startIndex = findingIndex + 1;
    Console.WriteLine($"i  harfinin indexi: {findingIndex}");
    isFind = word.IndexOf('i', startIndex) != -1;
}



/*
 *  1. En az 6 karakter
 *  2. Sadece harf ya da sadece sayı ise ZAYIF ya da sadece alfanümerik olmayan ise
 *  3. Hem harf hem sayı ise ORTA
 *  4. Hem sayı, hem harf hem de alfanümerik olmayan bir karakter varsa GÜÇLÜ şifre desin.
 *  
 *  İpucu: 
 *  char(.)
 */

