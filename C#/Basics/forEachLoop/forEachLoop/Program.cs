string[] products = { "A", "B", "C" };

Array.Resize(ref products, products.Length + 1);
List<string> productList = new List<string> { "TV", "SoundBar", "XBOX One" };

List<string> shoppingCart = new List<string>();




foreach (var product in productList)
{
    shoppingCart.Add(product);
    productList.Remove(product);
}

