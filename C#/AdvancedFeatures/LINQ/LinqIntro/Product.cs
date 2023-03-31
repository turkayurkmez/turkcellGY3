namespace LinqIntro
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public int Stock { get; set; }

        public Category Category { get; set; }


    }

    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class ProductService
    {
        private List<Product> products;
        private List<Category> categories;
        public ProductService()
        {
            categories = new()
            {
                new(){ Id=1, Name="Spor"},
                new(){ Id=2, Name="Giyim"},
                new(){ Id=3, Name="Kamp"}
            };

            products = new()
            {
                new(){ Id=1, Name="Bisiklet", Description="Spor amaçlı", Price=3000, Stock=150, Category=categories[0]},
                new(){ Id=2, Name="Dambıl set", Description="Spor amaçlı", Price=250, Stock=150, Category = categories[0]},

                new(){ Id=3, Name="Şort", Description="Giyim amaçlı", Price=570, Stock=150, Category = categories[1]},
                new(){ Id=4, Name="Tişört", Description="Spor amaçlı", Price=250, Stock=50, Category = categories[1]},
                new(){ Id=5, Name="Çadır", Description="Kampçılık amaçlı", Price=5000, Stock=150, Category = categories[2]},
                new(){ Id=6, Name="Olta", Description="Keyif amaçlı", Price=2500, Stock=15, Category = categories[2]},
                new(){ Id=7, Name="Eldiven", Description="Spor amaçlı", Price=250, Stock=520, Category=categories[1]},


            };
        }
        public List<Product> GetProducts()
        {
            return products;
        }

        public List<Category> GetCategories()
        {
            return categories;
        }

    }
}
