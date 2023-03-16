namespace CounterStrike
{
    public class Silah
    {
        public int Menzil { get; set; }
        public int Hasar { get; set; } = 5;
        public int Agirlik { get; set; }

        public string Ad { get; set; }

        public void Saldir()
        {
            Console.WriteLine($"Düşmana saldırılıyor, {Ad} ile {Hasar} kadar hasar verildi.");
        }

        public virtual void AtakHazirla()
        {
            Console.WriteLine("Bıçağı dik konuma getir");
        }
    }

    public class AtesliSilah : Silah
    {
        public int MermiSayisi { get; set; } = 8;
        public int MaksimumSarjor { get; set; } = 4;
        public double SekmeOrani { get; set; } = 0.1;

        public virtual void SarjorDegistir()
        {
            Console.WriteLine("Tabanca görüntüsü oynatıldı");
        }

        public override void AtakHazirla()
        {
            Console.WriteLine("Tabanca ile nişan alındı");
        }

    }

    public class Tabanca : AtesliSilah
    {
        public bool SusturucuVarMi { get; set; }
    }

    public class DesertEagle : Tabanca
    {
        public DesertEagle()
        {
            Ad = "Desert Eagle";
            Hasar = 20;
        }
        public int Sayisi { get; set; }
    }

    public class Tufek : AtesliSilah
    {
        public bool DurbunVarmi { get; set; }
        public override void SarjorDegistir()
        {
            Console.WriteLine("Tüfek görüntüsü oynatıldı");
        }
        public override void AtakHazirla()
        {
            Console.WriteLine("Dürbünden bakarak nişan al");
        }
    }

    public class Ak47 : Tufek
    {
        public Ak47()
        {
            Hasar = 40;
        }
        public string SarjorTipi { get; set; }
    }

}

