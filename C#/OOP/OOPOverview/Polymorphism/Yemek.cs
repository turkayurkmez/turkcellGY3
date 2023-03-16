namespace Polymorphism
{
    public class Yemek
    {
        public string Ad { get; set; }
        public virtual void SunumYap()
        {
            Console.WriteLine($"{Ad}, Pilav ile sunuldu");
        }
    }

    public class Baklava : Yemek
    {
        public override void SunumYap()
        {
            Console.WriteLine("Dondurma ile sunuldu");
        }
    }

    public class Kurufasulye : Yemek
    {

    }
}
