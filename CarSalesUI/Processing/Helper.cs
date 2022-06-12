using CarSalesUI.Models;
using Microsoft.VisualBasic.FileIO;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Text;

namespace CarSalesUI
{
    public static class Helper
    {
        public static string GetConnectionString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

        /// <summary>
        /// Reads the csv file specified and returns a list with the data read from the file.
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static List<CarImportModel> ReadCsvFile(string fileName)
        {
            List<CarImportModel> carsFound = new List<CarImportModel>();

            using (TextFieldParser parser = new TextFieldParser(fileName))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");
                while (!parser.EndOfData)
                {
                    string[] fields = parser.ReadFields();

                    if (parser.LineNumber < 3) continue;

                    CarImportModel car = new CarImportModel();

                    MapReadLineToCarImportModel(fields, car);

                    carsFound.Add(car);
                }
            }

            return carsFound;
        }

        private static void MapReadLineToCarImportModel(string[] fields, CarImportModel car)
        {
            car.Brand = fields[0];
            car.Model = fields[1];
            car.Year = fields[2];

            double.TryParse(fields[3], out double priceFound);
            car.Price = priceFound;
        }

        public static void ExportSalesOnMarkdownFile(string filePath, List<SaleModel> sales)
        {
            // add name of the file to create
            filePath += "\\SalesRecords.md";
            StringBuilder builder = new StringBuilder();

            // create all the text to be written
            foreach (SaleModel sale in sales)
            {
                builder.AppendLine($"# {sale.DateSold:dd MMMM yyyy} | {sale.CarModel}");
                builder.AppendLine();
                builder.AppendLine($"- *Price*: {sale.PriceSold}");
                builder.AppendLine($"- *Customer*: {sale.Customer}");
                builder.AppendLine($"- *Phone no.*: {sale.PhoneNo}");
                builder.AppendLine($"- *Address*: {sale.Address}");
                builder.AppendLine($"- *Zip code & city*: {sale.ZipCodeCity}");
                builder.AppendLine();
                builder.AppendLine("---");
                builder.AppendLine();
            }

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine(builder.ToString());
            }
        }

    }
}
