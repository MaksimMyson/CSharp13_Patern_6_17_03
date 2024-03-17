namespace CSharp13_Patern_6_17_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Console.WriteLine("Імпорт даних з Excel:");
            DataImporter excelImporter = new ExcelDataImporter();
            excelImporter.ImportData();

            Console.WriteLine();

            Console.WriteLine("Імпорт даних з CSV:");
            DataImporter csvImporter = new CsvDataImporter();
            csvImporter.ImportData();
        }
    }
}
