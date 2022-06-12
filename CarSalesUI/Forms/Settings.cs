using CarSalesUI.Models;
using CarSalesUI.Processing;
using System;
using System.Collections.Generic;
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
                Filter = "CSV Files (*.csv)|*.csv",
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
                carsImported = Helper.ReadCsvFile(fileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error while reading the csv file, check the format of the file.");
                return;
            }

            try
            {
                DbAccess.UpdateInventoryOnDatabase(carsImported);
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error while inserting records to the database, check the database connection info.");
                return;
            }

            MessageBox.Show($"{carsImported.Count} cars imported successfully!");
        }


        private void btnClearDb_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to reset the database of the application?", "Confimartion"
                , MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (res == DialogResult.OK)
            {
                try
                {
                    DbAccess.ClearDatabase();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was an error while reseting the database, please check the database connection info!");
                }            
            }
        }

    }
}
