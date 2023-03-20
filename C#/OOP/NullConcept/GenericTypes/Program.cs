// See https://aka.ms/new-console-template for more information
using System.Collections;

Console.WriteLine("Hello, World!");
ArrayList words = new ArrayList
{
    15
};
//demek ki boxing ve unboxing sadece MECBUR OLUNCA kullanılmalı.

GenericPoint<decimal> genericPoint = new GenericPoint<decimal>();
string kelime = "naber?";
//var output = GetTypeOfGeneric(kelime,5);
//Console.WriteLine(output);

string a = "Türkay";
string b = " Ürkmez";

Console.WriteLine($"{a} {b}");
Swap(ref a, ref b);
Console.WriteLine($"{a} {b}");


List<string> items = new List<string>();
//Generic Interface'de varyant kavramını araştırınız.... 




T GetTypeOfGeneric<T, W>(T type, W type2) where T : class, new()
                                              where W : class, new()
{
    var t = new T();
    return t;
}


void Swap<T>(ref T t1, ref T t2)
{
    T temp;
    temp = t2;
    t2 = t1;
    t1 = temp;

}


public class Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public void Reset()
    {
        X = 0;
        Y = 0;
    }
}

public class DoublePoint
{
    public double X { get; set; }
    public double Y { get; set; }

    public void Reset()
    {
        X = 0.0;
        Y = 0.0;
    }
}

public class ObjectPoint
{
    public object X { get; set; }
    public object Y { get; set; }
}

public class GenericPoint<T> where T : struct
{
    public T X { get; set; }
    public T Y { get; set; }

    public void Reset()
    {
        X = default(T);
        Y = default(T);
    }

}

