// See https://aka.ms/new-console-template for more information

try
{
    Console.WriteLine("Bir sayı giriniz");
    var sayi1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Bir sayı daha1 giriniz");
    int sayi2 = Convert.ToInt32(Console.ReadLine());
    int bolum = sayi1 / sayi2;
    Console.WriteLine($"Bölme işleminin sonucu: {bolum}");

}
catch (FormatException)
{
    Console.WriteLine("Lan ergen sayı diyoruz!");

}
catch (DivideByZeroException)
{
    Console.WriteLine("Tam sayılar 0'a bölünemez!");
}
catch (Exception ex)
{
    Console.WriteLine($"Bir hata oluştu: {ex.Message}");
}
finally
{
    Console.WriteLine("Burası mutlaka çalışması gereken bir satırsa? ");
}



