namespace Constructors
{
    public class ReportGenerator
    {
        public string ReportFormat { get; set; }
        public string SavedPath { get; set; }
        public string ReadingDataPath { get; set; }


        //public ReportGenerator()
        //{
        //    ReportFormat = "PDF";
        //}



        //public ReportGenerator(string reportFormat)
        //{
        //    ReportFormat = reportFormat;
        //}

        public ReportGenerator(string readingPath)
        {
            ReadingDataPath = readingPath;
        }




    }
}
