using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSalesUI.Models
{
    /// <summary>
    /// Represents a car model.
    /// </summary>
    public class Car
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public double Price { get; set; }
    }
}
