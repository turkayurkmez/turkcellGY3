namespace LiskovSubstution
{
    public static class GeometryLibrary
    {
        //public static Rectangle RectangleFactory()
        //{
        //    //bir biçimde, Square döndürmeye karar verdiniz...
        //    return new Square();
        //}

        public static IAreaCalcutable RectangleFactory(int unit1, int? unit2 = null)
        {
            if (unit2.HasValue)
            {
                return new Rectangle() { Width = unit1, Height = unit2.Value };
            }
            else
            {
                return new Square() { EdgeLength = unit1 };
            }
        }
    }
    public interface IAreaCalcutable
    {
        int GetArea();
    }
    public class Rectangle : IAreaCalcutable
    {
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }

        public int GetArea()
        {
            //if (this is Square)
            //{
            //    throw new Exception
            //}
            return Width * Height;
        }
    }

    public class Square : IAreaCalcutable //: Rectangle
    {
        //public override int Height { get => base.Height; set { base.Width = value; base.Height = value; } }
        //public override int Width { get => base.Width; set { base.Width = value; base.Height = value; } }
        public int EdgeLength { get; set; }

        public int GetArea()
        {
            return EdgeLength * EdgeLength;
        }
    }

}
