using System;
using System.Collections.Generic;
using System.IO;
using CsvHelper;
using Microsoft.Extensions.Configuration;

namespace Finance_Project
{
    public class Finance
    {
        private readonly IConfiguration _configuration;

        public Finance(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void Execute()
        {
            List<DataRecord> CheckRecords = new List<DataRecord>();
            IEnumerable<DataRecord> records;

            var file =  @"C:\Users\richa\OneDrive\Documents\Personal\Financial\CreditCard1.csv";
            using (var sr = new StreamReader(file))
            {
                var reader = new CsvReader(sr);

                //CSVReader will now read the whole file into an enumerable
                records = reader.GetRecords<DataRecord>();

                //First 5 records in CSV file will be printed to the Output Window
                var filecat = new FileCategorizor();
                foreach (DataRecord record in records)
                {
                    var result = filecat.Execute(record);
                    CheckRecords.Add(result);

                    Console.WriteLine("{0} {1}, {2}, {3}", record.Date, record.Charge, record.Category, record.CreditCard);
                }

                using (TextWriter writer = new StreamWriter(@"C:\Users\richa\OneDrive\Documents\Personal\Financial\Clean.csv", true, System.Text.Encoding.UTF8))
                {
                    var csv = new CsvWriter(writer);
                    csv.WriteRecords(CheckRecords); // where values implements IEnumerable
                }
            }


        }
    }


}
