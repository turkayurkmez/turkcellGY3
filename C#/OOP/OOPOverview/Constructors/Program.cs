// See https://aka.ms/new-console-template for more information
using Constructors;

Console.WriteLine("Hello, World!");
ReportGenerator reportGenerator = new ReportGenerator("C:\\data.txt");

Console.WriteLine(reportGenerator.ReportFormat);

ReportGenerator report2 = new ReportGenerator(readingPath: "C:\\data.xml");

Ekmek ekmek = new Ekmek("kepek", 2);
