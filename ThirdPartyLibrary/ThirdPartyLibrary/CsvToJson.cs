using CsvHelper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace ThirdPartyLibrary
{
    public class CsvToJson
    {
        public void ImplementCsvToJson()
        {
            string importFilePath = @"D:\Third Party\Third-Party-Library\ThirdPartyLibrary\ThirdPartyLibrary\Utility\addresses.csv";
            string exportFilePath = @"D:\Third Party\Third-Party-Library\ThirdPartyLibrary\ThirdPartyLibrary\Utility\export.json";

            using (var reader = new StreamReader(importFilePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<AddressData>().ToList();
                Console.WriteLine("Read data succesfully from addresses csv");
                foreach (AddressData addressData in records)
                {
                    Console.WriteLine(addressData.firstname);
                    Console.WriteLine(addressData.lastname);
                    Console.WriteLine(addressData.address);
                    Console.WriteLine(addressData.city);
                    Console.WriteLine(addressData.state);
                    Console.WriteLine(addressData.code);
                    Console.Write("\n");
                }
                Console.WriteLine("Now reading from Csv File and Writing to Json file");
                JsonSerializer serializer = new JsonSerializer();
                using (StreamWriter sw = new StreamWriter(exportFilePath))
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    serializer.Serialize(writer, records);
                }
            }

        }
    }
}
