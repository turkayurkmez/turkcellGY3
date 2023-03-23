using System.Collections;

namespace BuiltInInterface
{
    public class Product : IComparable<Product>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }

        public int CompareTo(Product? other)
        {
            if (Price > other?.Price)
            {
                return 1;
            }
            else if (Price < other?.Price)
            {
                return -1;

            }
            return 0;
        }
    }

    public class ProductCollection : IEnumerable<Product>
    {
        private List<Product> products = new List<Product>();
        public void Add(Product product)
        {
            products.Add(product);
        }

        public void Clear()
        {
            products.Clear();
        }
        public List<Product> GetAll()
        {
            return products;
        }

        public IEnumerator<Product> GetEnumerator()
        {
            foreach (var product in products)
            {
                yield return product;
            }
        }

        public void SortProducts()
        {
            products.Sort();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

}
