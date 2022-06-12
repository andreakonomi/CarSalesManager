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

        public static void UpdateInventoryOnDatabase(List<CarImportModel> carsImported)
        {
            using (IDbConnection conn = new SqlConnection(Helper.GetConnectionString("CarStoreDb")))
            {
                conn.Query<dynamic>("delete from dbo.Inventory");

                foreach (CarImportModel car in carsImported)
                {
                    conn.Query<dynamic>("insertNewInventoryCar", new { car.Brand, car.Model, car.Year, car.Price },
                        commandType: CommandType.StoredProcedure);
                }
            }
        }

        /// <summary>
        /// Resets the database.
        /// </summary>
        public static void ClearDatabase()
        {
            using (IDbConnection conn = new SqlConnection(Helper.GetConnectionString("CarStoreDb")))
            {
                conn.Query<dynamic>("delete from dbo.Inventory");
                conn.Query<dynamic>("delete from dbo.Sales");
            }
        }


        public static List<Car> GetAllAvailableCars()
        {
            List<Car> carsFound = new List<Car>();

            try
            {
                using (IDbConnection conn = new SqlConnection(_connString))
                {
                    carsFound = conn.Query<Car>("select * from dbo.Inventory").ToList();
                }

                return carsFound;
            }
            catch (Exception ex)
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
            catch (Exception ex)
            {
                return false;
            }        
        }

        public static List<SaleModel> GetAllSales()
        {
            using (IDbConnection conn = new SqlConnection(_connString))
            {
                List<SaleModel> sales = conn.Query<SaleModel>("select * from dbo.Sales").ToList();

                return sales;
            }
        }
    }
}
