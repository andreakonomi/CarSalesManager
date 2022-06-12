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
    }
}
