// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//boxing: Bir kutunun içerisine bir değer koymaktır. 
object o = "Bir nesne";
o = 9;
o = false;
o = new Random();

Random random = new Random();
object empty = new object();

int x = 0;
int y = 0;

Console.WriteLine(x == y);
Console.WriteLine(x.Equals(y));
Console.WriteLine(o.Equals(empty));

//== referans
//Equals: Değer

Address address1 = new Address() { City = "Hatay" };
Address address2 = new Address() { City = "Hatay" };
Address address3 = address1;

Console.WriteLine($"address1==address2 sonucu: {address1 == address2}");
Console.WriteLine($"address1.Equals(address2) sonucu: {address1.Equals(address2)} Çünkü: {address1.City} = {address2.City} ");
Console.WriteLine($"address1==address3 sonucu: {address1 == address3}");
Console.WriteLine("Bu da refenceEquals " + object.ReferenceEquals(address1, address2));


string deney1 = "TURKCELL";
string deney2 = "TURKCELL";
string deney3 = "TURKCELLx".Substring(0, 8);
object deney4 = deney3;



Console.WriteLine($"deney ==  deney2 ile: {deney1 == deney2}");
Console.WriteLine($"deney1 Equals deney2  ile: {deney1.Equals(deney2)}");


Console.WriteLine($"deney1 {deney1.GetHashCode()} ve deney3 {deney3.GetHashCode()}  == ile: {deney1 == deney3}");
Console.WriteLine($"deney1 ve deney3 Equals ile: {deney1.Equals(deney3)}");


Console.WriteLine($"deney1 {deney1.GetHashCode()} ve deney4 {deney4.GetHashCode()}  == ile: {deney1 == deney4}");
Console.WriteLine($"deney1 ve deney4  equals ile: {deney1.Equals(deney4)}");



Address address = null;// new Address { City = "Van" };
Console.WriteLine(address ?? new Address { City = "Burdur" });
Console.WriteLine(address?.City);


public class Address
{
    public string City { get; set; }

    public override bool Equals(object? obj)
    {
        Address? that = (Address?)obj;
        return City.Equals(that?.City);
    }

    public override string ToString()
    {
        return $"Bu adres, {City} şehrinde bulunuyor";
    }

}
