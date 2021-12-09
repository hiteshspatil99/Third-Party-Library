using CsvHelper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace ThirdPartyLibrary
{
    public class CsvHandler
    {

        public static void ImplementCSVdatHandling()
        {
            string importFilePath = @"D:\third party\ThirdPartyLibrary\ThirdPartyLibrary\Utility\addresses.csv";
            string exportFilePath = @"D:\third party\ThirdPartyLibrary\ThirdPartyLibrary\Utility\export.csv";

            using (var reader = new StreamReader(importFilePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<AddressData>().ToList();
                Console.WriteLine("Read data succesfully fromaddresses csv");
                foreach (AddressData addressData in records)

                {
                    Console.WriteLine(addressData.firstname);
                    Console.WriteLine(addressData.lastname);
                    Console.WriteLine(addressData.address);
                    Console.WriteLine(addressData.city);
                    Console.WriteLine(addressData.state);
                    Console.WriteLine("\t" + addressData.code);
                    Console.Write("\n");
                }

                Console.WriteLine("\n  now reading from csv file & write to csv file");

                using (var writer = new StreamWriter(exportFilePath))
                using (var CsvExport = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    CsvExport.WriteRecords(records);
                }
            }
        }


    }
}
