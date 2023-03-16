namespace CounterStrike
{
    public class Oyuncu
    {
        public string Ad { get; set; }
        public string Ikon { get; set; }

        public Silah OyuncununSilahi { get; set; }

        public void Saldir()
        {
            OyuncununSilahi.Saldir();
        }

        public void SarjorDegistir()
        {
            //OyuncununSilahi
            //if (OyuncununSilahi is AtesliSilah)
            //{
            //    ((AtesliSilah)OyuncununSilahi).SarjorDegistir();
            //}
        }

        public void SagTikla()
        {
            OyuncununSilahi.AtakHazirla();
        }
    }
}
