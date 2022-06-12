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
    public partial class SaleConfirm : Form
    {
        Car _carToSell;
        Sales _parentForm;

        public SaleConfirm(Car carToSell, Sales parentForm)
        {
            InitializeComponent();

            if (carToSell is null)
            {
                MessageBox.Show("You need to select a valid car to sell");
                _parentForm.CarSold = false;
                Close();
            }

            _parentForm = parentForm;
            _carToSell = carToSell;
            FillFieldsWithCarInfo();
        }

        private void FillFieldsWithCarInfo()
        {
            txtBrand.Text = _carToSell.Brand;
            txtModel.Text = _carToSell.Model;
            txtYear.Text = _carToSell.Year;
            txtPrice.Text = _carToSell.Price.ToString();
        }

        private void btnConfirmSale_Click(object sender, EventArgs e)
        {
            //check input fields
            // remove from db
            // update on db
            // prompt successful interaction
            bool fieldsValid = CheckCustomerInputFields();
            if (!fieldsValid)
            {
                MessageBox.Show("Please fill all customer information before proceeding.");
                return;
            }

            Customer customer = CreateCustomer();

            bool saleDone = DbAccess.SellCarToCustomer(_carToSell, customer);
            if (!saleDone)
            {
                MessageBox.Show("There was a problem while finalizing the sale, check database connection or data.");
                return;
            }

            MessageBox.Show("Car was successfull sold to the customer.");

            _parentForm.CarSold = true;
            this.Close();
        }

        /// <summary>
        /// Creates the cusomter object with all the data provided by the ui.
        /// </summary>
        private Customer CreateCustomer()
        {
            Customer customer = new Customer
            {
                CustomerName = txtCustomer.Text,
                Address = txtAddress.Text,
                PhoneNo = txtPhoneNo.Text,
                ZipCodeCity = txtZip.Text
            };

            return customer;
        }

        private bool CheckCustomerInputFields()
        {
            if (string.IsNullOrWhiteSpace(txtCustomer.Text))
            {
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPhoneNo.Text))
            {
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtZip.Text))
            {
                return false;
            }

            return true;
        }

        private void btnCancelSale_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
