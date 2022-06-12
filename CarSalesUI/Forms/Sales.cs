using CarSalesUI.Models;
using CarSalesUI.Processing;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CarSalesUI.Forms
{
    public partial class Sales : Form
    {
        List<Car> cars = new List<Car>();
        List<Car> filteredList;
        public bool CarSold;

        public Sales()
        {
            InitializeComponent();

            GetAvailableCars();

            // disable btn until we have a selection
            btnSell.Enabled = false;
        }

        private void GetAvailableCars()
        {
            cars = DbAccess.GetAllAvailableCars();

            if (cars is null)
            {
                MessageBox.Show("There was an error while retriving the cars from the database. Check connection info.");
                
                //initialzie list to avoid null exception going forward
                cars = new List<Car>();
            }

            BindListView(cars);
        }

        private void lsbCars_SelectedIndexChanged(object sender, EventArgs e)
        {
            Car selectedCar = lsbCars.SelectedItem as Car;

            PopulateFieldsWithCar(selectedCar);

            //enable sell btn only when a valid car is selected
            btnSell.Enabled = selectedCar != null;
        }

        private void PopulateFieldsWithCar(Car selectedCar)
        {
            if(selectedCar is null)
            {
                ClearInfoFields();
                return;
            }

            txtBrand.Text = selectedCar.Brand;
            txtModel.Text = selectedCar.Model;
            txtPrice.Text = selectedCar.Price.ToString();
            txtYear.Text = selectedCar.Year;
        }

        private void ClearInfoFields()
        {
            txtBrand.Text = txtModel.Text = txtPrice.Text = txtYear.Text = "";
        }

        private void ClearFilterFields()
        {
            txtFilterBrand.Text = txtFilterModel.Text = txtFilterPrice.Text = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            filteredList = new List<Car>(cars);

            //allow case insensitive search
            string brandFilter = txtFilterBrand.Text.ToLower();
            string modelFilter = txtFilterModel.Text.ToLower();
            string priceFilter = txtFilterPrice.Text;

            filteredList = filteredList.Where
                (
                    x => (string.IsNullOrWhiteSpace(brandFilter) || x.Brand.ToLower().Contains(brandFilter))
                    && (string.IsNullOrWhiteSpace(modelFilter) || x.Model.ToLower().Contains(modelFilter))
                    && (string.IsNullOrWhiteSpace(priceFilter) || x.Price.ToString() == priceFilter.ToString())
                ).ToList();

            BindListView(filteredList);

        }

        private void btnRemoveFilters_Click(object sender, EventArgs e)
        {
            ClearFilterFields();
            BindListView(cars);
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            Car selectedCar = lsbCars.SelectedItem as Car;

            if (selectedCar is null)
            {
                return;
            }

            SaleConfirm frmSaleConfirm = new SaleConfirm(selectedCar, this);
            frmSaleConfirm.ShowDialog();

            // check result of what happened and adjust accordingly, if not sold no need to remove car from memory inventory
            if (CarSold)
            {
                AdjustStateForSoldCar(selectedCar);

                //reset variable state for next sell
                CarSold = false;
            }
        }

        private void AdjustStateForSoldCar(Car selectedCar)
        {
            cars.Remove(selectedCar);

            // tell the listview to refresh its content
            BindListView(cars);

            ClearInfoFields();
            ClearFilterFields();
        }

        private void BindListView(List<Car> carsList)
        {
            lsbCars.DataSource = null;
            lsbCars.DataSource = carsList;
        }

        private void btnExportSales_Click(object sender, EventArgs e)
        {
            var folderBrowserDialog = new FolderBrowserDialog();
            List<SaleModel> sales;

            //Show the FodlerBrowserDialog
            DialogResult result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string pathToSave = folderBrowserDialog.SelectedPath;

                try
                {
                    sales = DbAccess.GetAllSales();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was an error while reading all sales. Check the database connection info.");
                    return;
                }

                try
                {
                    Helper.ExportSalesOnMarkdownFile(pathToSave, sales);
                    MessageBox.Show("Sales report has been exported successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was an error while creating the sales records file.");
                }         
            }
                
        }
    }
}
