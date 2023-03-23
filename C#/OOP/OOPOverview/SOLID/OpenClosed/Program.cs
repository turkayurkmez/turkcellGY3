// See https://aka.ms/new-console-template for more information
Customer customer = new Customer { Name = "Türkay", Cart = CartType.Gold };
OrderManager orderManager = new OrderManager() { Customer = customer };


var price = orderManager.GetDiscountedPrice(1000);
Console.WriteLine(price);

Console.WriteLine("Hello, World!");
//Open/Closed Principle: Bir nesne gelişime AÇIK değişime KAPALI olmalıdır.

//Senaryo:
//public enum CartType
//{
//    Standard,
//    Silver,
//    Gold,
//    Premium
//}

public interface ICartType
{
    public double GetDiscounted(double totalPrice);

}

public class Standart : ICartType
{
    public double GetDiscounted(double totalPrice)
    {
        return totalPrice * .95;
    }
}

public class Silver : ICartType
{
    public double GetDiscounted(double totalPrice)
    {
        return totalPrice * .9;
    }
}
public class Gold : ICartType
{
    public double GetDiscounted(double totalPrice)
    {
        return totalPrice * .85;
    }
}



public class Customer
{
    public string Name { get; set; }
    public ICartType Cart { get; set; }
}

public class OrderManager
{
    public Customer Customer { get; set; }
    public double GetDiscountedPrice(double total)
    {
        return Customer.Cart.GetDiscounted(total);
        //switch (Customer.Cart)
        //{
        //    case CartType.Standard:
        //        return total * .95;
        //    case CartType.Silver:

        //        return total * .9;
        //    case CartType.Gold:
        //        return total * .85;

        //    default:
        //        return total;
        //}
    }
}