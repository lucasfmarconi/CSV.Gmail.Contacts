using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using CsvHelper;

namespace CSV.Gmail.Contacts.Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            var recordsToWrite = new List<Contact>();
            int lengthRawFile = 0;
            string[] prefixesToReplace = new string[]{
                "68","82","96","92","71","73","74","75","77","85","88","61","27","28","62","64","98","99","65","66","67","31","32","33","34","35","37","38","91","93","94","83","41","42","43","44","45","46","81","87","86","89","21","22","24","84","54","55","51","53","69","95","47","48","49","11","12","13","14","15","16","17","18","19","79","63"
            };
            using (var reader = new StreamReader("contacts.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Context.RegisterClassMap<ContactMap>();
                var records = csv.GetRecords<Contact>().ToList();
                lengthRawFile = records.Count();
                foreach (var record in records)
                {
                    foreach (var ddd in prefixesToReplace)
                    {
                        record.Phone1_Value = CellphoneNumberFormater.FormatNumber(record.Phone1_Value, ddd, $"+55{ddd}");
                        record.Phone2_Value = CellphoneNumberFormater.FormatNumber(record.Phone2_Value, ddd, $"+55{ddd}");
                        record.Phone3_Value = CellphoneNumberFormater.FormatNumber(record.Phone3_Value, ddd, $"+55{ddd}");
                        record.Phone4_Value = CellphoneNumberFormater.FormatNumber(record.Phone4_Value, ddd, $"+55{ddd}");
                    }

                    recordsToWrite.Add(record);
                }
            }

            if (recordsToWrite.Count == lengthRawFile)
            {
                using (var writer = new StreamWriter("contacts-new.csv"))
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv.Flush();
                    csv.WriteRecords(recordsToWrite);
                }
            }
        }
    }
}