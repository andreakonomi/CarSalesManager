using CarSalesUI.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSalesUI.Processing
{
    public static class DbAccess
    {
        private static string _connString = Helper.GetConnectionString("CarStoreDb");

        public static List<Car> GetAllAvailableCars()
        {
            List<Car> carsFound = new List<Car>();

            try
            {
                using (IDbConnection conn = new SqlConnection(_connString))
                {
                    carsFound = conn.Query<Car>("select * from Inventory").ToList();
                }

                return carsFound;
            }
            catch (Exception)
            {
                return null;
            }

        }

        /// <summary>
        /// Inserts the sale record and removes the car from the inventory.
        /// </summary>
        public static bool SellCarToCustomer(Car car, Customer customer)
        {
            try
            {
                using (IDbConnection conn = new SqlConnection(_connString))
                {
                    conn.Query("dbo.AddSaleRecord",
                        new
                        {
                            customerName = customer.CustomerName,
                            phoneNo = customer.PhoneNo,
                            address = customer.Address,
                            zipCodeCity = customer.ZipCodeCity,
                            carFullModel = $"{car.Brand} {car.Model} ({car.Year})",
                            priceSold = car.Price
                        },
                        commandType: CommandType.StoredProcedure);

                    conn.Query("dbo.RemoveCarFromInventory", new { carId = car.Id }, commandType: CommandType.StoredProcedure);
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }        
        }
    }
}
