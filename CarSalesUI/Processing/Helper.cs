using CarSalesUI.Models;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}
