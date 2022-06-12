using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSalesUI.Models
{
    public class SaleModel
    {
        public int Id { get; set; }
        public string Customer { get; set; }
        public string PhoneNo { get; set; }
        public string Address { get; set; }
        public string ZipCodeCity { get; set; }
        public DateTime DateSold{ get; set; }
        public string CarModel { get; set; }
        public double PriceSold { get; set; }
    }
}
