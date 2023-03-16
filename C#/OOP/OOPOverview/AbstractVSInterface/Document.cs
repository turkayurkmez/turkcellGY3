namespace AbstractVSInterface
{
    public abstract class Document
    {
        public abstract void Save();
        public abstract void Open();

        public abstract void Print();

        public void Copy(string from, string to)
        {
            Console.WriteLine($"{from} adresinden {to} adresine kopyalandı");
        }

        public string Title { get; set; }
        public string Owner { get; set; }
    }

    public class PdfDocument : Document
    {
        public override void Open()
        {
            Console.WriteLine("Pdf açılıyor");
        }

        public override void Print()
        {
            Console.WriteLine("Pdf çıktısı alındı");
        }

        public override void Save()
        {
            Console.WriteLine("Pdf kaydedildi");

        }
    }

    public class ExcelDocument : Document
    {
        public override void Open()
        {
            Console.WriteLine("Excel açılıyor");

        }

        public override void Print()
        {
            Console.WriteLine("Excel çıktısı alındı");

        }

        public override void Save()
        {
            Console.WriteLine("Excel kaydedildi");

        }
    }

    public class WordDocument : Document
    {
        public override void Open()
        {
            Console.WriteLine("Word açılıyor");

        }

        public override void Print()
        {
            Console.WriteLine("Word çıktısı alındı");

        }

        public override void Save()
        {
            Console.WriteLine("Word kaydedildi");


        }
    }



}
