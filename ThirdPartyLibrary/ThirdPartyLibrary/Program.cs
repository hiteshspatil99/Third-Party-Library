using System;

namespace ThirdPartyLibrary
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("# Read data from CSV & Write data in CSv");
            CsvHandler exportCSV = new CsvHandler();
            exportCSV.ImplementCSVdatHandling();
            Console.WriteLine("# Read data from CSV & Write data to Json");
            CsvToJson json = new CsvToJson();
            json.ImplementCsvToJson();

        }

    }
}
