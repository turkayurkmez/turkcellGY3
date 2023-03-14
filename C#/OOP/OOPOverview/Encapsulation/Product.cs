namespace Encapsulation
{
    public class Product
    {
        private double price;

        //private readonly int test = 5;
        public void SetPrice(double value)
        {
            //test = 8;
            if (value > 0)
            {
                price = value;

            }

            throw new ArgumentException($"{value} değeri kabul edilemez");
        }

        public double GetPrice()
        {
            return price;
        }

        public string Name { get; set; }

        public int Stock { get; set; }

        public bool IsInStock
        {
            get
            {
                return Stock > 50;

            }
        }

        public float Discount { get; set; }




    }
}
