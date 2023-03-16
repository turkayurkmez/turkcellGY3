// See https://aka.ms/new-console-template for more information
using Polymorphism;

Console.WriteLine("Hello, World!");

Kurufasulye kurufasulye = new Kurufasulye() { Ad = "Kuru fasülye" };
kurufasulye.SunumYap();

Baklava baklava = new Baklava() { Ad = "Baklava" };
baklava.SunumYap();

Console.WriteLine("Aşçıya emir veriliyor:");
Asci asci = new Asci();
asci.Pisir(kurufasulye);

asci.Pisir(baklava);