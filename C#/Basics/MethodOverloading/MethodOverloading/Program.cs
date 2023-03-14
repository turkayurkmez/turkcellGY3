// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Geometry geometry = new Geometry();
var areaOfCircle = geometry.GetArea(5, "Daire");
var areaOfTriangle = geometry.GetArea(3, 10, "Üçgen");


int triangleUnit = 3;
int triangleHeight = 15;
string geo = "Üçgen";


var optionalSquare = geometry.AlternativeGetArea(5);
var optionalCircle = geometry.AlternativeGetArea(3, geometry: "Daire");
var optionalTriangle = geometry.AlternativeGetArea(3, unit2: 20, geometry: "Üçgen");
var optionalTriangle2 = geometry.AlternativeGetArea(unit1: 3,
                                                   geometry: "Üçgen",
                                                   unit2: 15);

var optional3 = geometry.AlternativeGetArea(triangleUnit, triangleHeight, geo);



public class Geometry
{
    //Kare, Daire, Üçgen, Dikdörtgen 

    /// <summary>
    /// Kare ya da Daire şekillerinin alanlarını hesaplamak için kullanılır.
    /// </summary>
    /// <param name="unit1">Karenin birim uzunluğu veya dairenin yarı çapı</param>
    /// <param name="geometry">Kare veya Daire kelimelerinden biri!</param>
    /// <returns></returns>
    public double GetArea(double unit1, string geometry)
    {
        double result = 0;
        switch (geometry)
        {
            case "Kare":
                result = unit1 * unit1;
                break;
            case "Daire":
                result = Math.Pow(unit1, 2) * Math.PI;
                break;
            default:
                break;
        }

        return result;
    }


    /// <summary>
    /// Üçgen ya da Dikdörtgen şekillerinin alanlarını hesaplamak için kullanılır.
    /// </summary>
    /// <param name="unit1">Didörtgenin eni veya üçgenin tabanı</param>
    /// <param name="unit2">Boy ya da hipotenüs</param>
    /// <param name="geometry">Üçgen veya Dikdörtgen</param>
    /// <returns></returns>
    public double GetArea(double unit1, double unit2, string geometry)
    {
        double result = 0;
        switch (geometry)
        {
            case "Üçgen":
                result = unit1 * unit2 / 2;
                break;
            case "Dikdörtgen":
                result = unit1 * unit2;
                break;
            default:
                break;
        }

        return result;
    }



    /// <summary>
    /// Optional parametrelere sahip Alan hesaplama metodu
    /// </summary>
    /// <param name="unit1">[ZORUNLU] birim uzunluğu girin</param>
    /// <param name="unit2">[OPSİYONEL] birim 2</param>
    /// <param name="geometry">[OPSİYONEL] Geometrik şekil</param>
    /// <returns></returns>
    public double AlternativeGetArea(double unit1, double unit2 = 1, string geometry = "Kare")
    {
        double result = 0.0;
        switch (geometry)
        {
            case "Kare":
                result = unit1 * unit1;
                break;
            case "Daire":
                result = Math.Pow(unit1, 2) * Math.PI;
                break;
            case "Üçgen":
                result = unit1 * unit2 / 2;
                break;
            case "Dikdörtgen":
                result = unit1 * unit2;
                break;
            default:
                break;
        }

        return result;
    }


}