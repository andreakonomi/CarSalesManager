using CarSalesUI.Models;
using CarSalesUI.Processing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarSalesUI.Forms
{
    public partial class Sales : Form
    {
        List<Car> cars = new List<Car>();
        List<Car> filteredList;

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

            //bind the data to the display control
            lsbCars.DataSource = cars;
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

            lsbCars.DataSource = null;
            lsbCars.DataSource = filteredList;
        }

        private void btnRemoveFilters_Click(object sender, EventArgs e)
        {
            ClearFilterFields();

            lsbCars.DataSource = null;
            lsbCars.DataSource = cars;
        }
    }
}
