namespace LINQ
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public double Rating { get; set; }
        public bool IsInStock { get; set; }
        public Category Category { get; set; }

    }

    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }


    public class ProductService
    {
        private List<Product> products = new List<Product>();

        private List<Category> categories = new List<Category>();


        public ProductService()
        {

            Category phoneCategory = new Category() { Id = 1, Name = "Telefon" };
            Category laptopCategory = new Category() { Id = 2, Name = "Laptop" };

            categories = new List<Category>() { phoneCategory, laptopCategory };

            products = new()
            {
                new(){ Id=1, Name="Samsung A51", Description="Android", IsInStock=true, Price=8000, Rating=4.6, Category=phoneCategory},
                new(){ Id=2, Name="Xiaomi", Description="Android", IsInStock=true, Price=6000, Rating=4.8, Category = phoneCategory},
                new(){ Id=3, Name="Huawei", Description="Android", IsInStock=true, Price=6500, Rating=4.5, Category = phoneCategory},
                new(){ Id=4, Name="IPhone XV", Description="IoS", IsInStock=false, Price=80000, Rating=5, Category = phoneCategory},
                new(){ Id=5, Name="Dell XPS 15", Description="Dell Laptop", IsInStock=true, Price=35000, Rating=4.2, Category = laptopCategory},
                new(){ Id=6, Name="Dell XPS 13", Description="Dell Laptop", IsInStock=true, Price=36000, Rating=4.2, Category = laptopCategory},
                new(){ Id=7, Name="Dell ", Description="Dell Laptop", IsInStock=false, Price=35000, Rating=4.2, Category = laptopCategory},

            };
        }
        public List<Product> GetProducts()
        {
            return products;
        }
        public List<Category> GetCategories() => categories;
    }

}
