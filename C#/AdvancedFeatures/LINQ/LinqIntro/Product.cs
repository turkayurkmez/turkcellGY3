namespace LinqIntro
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public int Stock { get; set; }



    }

    public class ProductService
    {
        private List<Product> products;
        public ProductService()
        {
            products = new()
            {
                new(){ Id=1, Name="Bisiklet", Description="Spor amaçlı", Price=3000, Stock=150},
                new(){ Id=2, Name="Dambıl set", Description="Spor amaçlı", Price=250, Stock=150},

                new(){ Id=3, Name="Şort", Description="Giyim amaçlı", Price=570, Stock=150},
                new(){ Id=4, Name="Tişört", Description="Spor amaçlı", Price=150, Stock=50},
                new(){ Id=5, Name="Çadır", Description="Kampçılık amaçlı", Price=5000, Stock=150},
                new(){ Id=6, Name="Olta", Description="Keyif amaçlı", Price=2500, Stock=15},
                new(){ Id=7, Name="Eldiven", Description="Spor amaçlı", Price=500, Stock=150},


            };
        }
        public List<Product> GetProducts()
        {
            return products;
        }

    }
}
