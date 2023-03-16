// See https://aka.ms/new-console-template for more information
using CounterStrike;

Console.WriteLine("Hello, World!");


Oyuncu oyuncu = new Oyuncu();
Ak47 ak47 = new Ak47 { Ad = "Ak 47" };
DesertEagle desertEagle = new DesertEagle();



oyuncu.OyuncununSilahi = new Silah { Ad = "Ekmek Bıçağı", Hasar = 5 };
oyuncu.SagTikla();

oyuncu.OyuncununSilahi = desertEagle;

oyuncu.SagTikla();
oyuncu.Saldir();
oyuncu.SarjorDegistir();


oyuncu.OyuncununSilahi = ak47;



oyuncu.SagTikla();
oyuncu.Saldir();
oyuncu.SarjorDegistir();
