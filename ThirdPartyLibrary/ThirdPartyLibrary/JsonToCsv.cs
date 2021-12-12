using CsvHelper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace ThirdPartyLibrary
{
    public class JsonToCsv
    {
        public void ImplementJsonToCsv()
        {
            string importFilePath = @"D:\Third Party\Third-Party-Library\ThirdPartyLibrary\ThirdPartyLibrary\Utility\export.json";
            string exportFilePath = @"D:\Third Party\Third-Party-Library\ThirdPartyLibrary\ThirdPartyLibrary\Utility\JsonData.csv";

            IList<AddressData> addressData = JsonConvert.DeserializeObject<IList<AddressData>>(File.ReadAllText(importFilePath));

            Console.WriteLine("\n Read data succesfully from addresses Json ");
            
            using (var writer = new StreamWriter(exportFilePath))
            using (var exportCSV = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                exportCSV.WriteRecords(addressData);

            }
        }
    }
}
