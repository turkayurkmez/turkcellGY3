// See https://aka.ms/new-console-template for more information
Console.WriteLine("Kullanıcı adını giriniz");
string name = Console.ReadLine();
Console.WriteLine("Şifrenizi girin");
string password = Console.ReadLine();


if (name == "turkay" && password == "1234")
{
    Console.WriteLine("Ooo hoşgeldin");
}
else if (name == "mustafa" && password == "4321")
{
    Console.WriteLine("Yılmaz idi değil mi?");
}
else
{
    Console.WriteLine("Kimsin sen?");
}

Console.WriteLine("Hangi aydasın");
string month = Console.ReadLine();
if (month == "Mart" || month == "Nisan" || month == "Mayıs")
{
    Console.WriteLine("İlkbahar mevsimindesiniz...");
}

Console.WriteLine("Bir sayı giriniz");
int number = Convert.ToInt32(Console.ReadLine());
string message = string.Empty;

if (number % 2 == 0)
{
    message = "Çifttir";
}
else
{
    message = "Tektir";
}

string message2 = number % 2 == 0 ? "Çift" : "Tek";
string greetings = DateTime.Now.Hour <= 16 ? "İyi günler" : "İyi akşamlar";

Console.WriteLine(message2);
Console.WriteLine(greetings);



