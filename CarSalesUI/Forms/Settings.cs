using CarSalesUI.Models;
using CsvHelper;
using Dapper;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarSalesUI.Forms
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void btnImportCSV_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse Csv file",
                //Filter = "csv files (*.csv)|*.txt",
                CheckFileExists = true,
                CheckPathExists = true
            };

            if(dialog.ShowDialog() == DialogResult.OK)
            {
                ProcessCsvFile(dialog.FileName);
            }
        }

        private void ProcessCsvFile(string fileName)
        {
            List<CarImportModel> carsImported = null;

            try
            {
                carsImported = ReadCsvFile(fileName);
            }
            catch (Exception)
            {
                MessageBox.Show("There was an error while reading the csv file, check the format of the file.");
                return;
            }

            try
            {
                UpdateInventoryOnDatabase(carsImported);

            }
            catch (Exception)
            {
                MessageBox.Show("There was an error while inserting records to the database, check the database connection info.");
                return;
            }

            MessageBox.Show($"{carsImported.Count} cars imported successfully!");
        }

        /// <summary>
        /// Reads the csv file specified and returns a list with the data read from the file.
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        private List<CarImportModel> ReadCsvFile(string fileName)
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

        private void UpdateInventoryOnDatabase(List<CarImportModel> carsImported)
        {
            using(IDbConnection conn = new SqlConnection(Helper.GetConnectionString("CarStoreDb")))
            {
                conn.Query<dynamic>("delete from dbo.Inventory");

                foreach (CarImportModel car in carsImported)
                {
                    conn.Query<dynamic>("insertNewInventoryCar", new { car.Brand, car.Model, car.Year, car.Price },
                        commandType: CommandType.StoredProcedure);
                }
            }
        }

        private static void MapReadLineToCarImportModel(string[] fields, CarImportModel car)
        {
            car.Brand = fields[0];
            car.Model = fields[1];
            car.Year = fields[2];

            double.TryParse(fields[3], out double priceFound);
            car.Price = priceFound;
        }

        private void btnClearDb_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to reset the database of the application?", "Confimartion"
                , MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (res == DialogResult.OK)
            {
                ClearDatabase();
            }
        }

        private void ClearDatabase()
        {
            try
            {
                using (IDbConnection conn = new SqlConnection(Helper.GetConnectionString("CarStoreDb")))
                {
                    conn.Query<dynamic>("delete from dbo.Inventory");
                    conn.Query<dynamic>("delete from dbo.Sales");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("There was an error while reseting the database, please check the database connection info!");
            }        
        }
    }
}
