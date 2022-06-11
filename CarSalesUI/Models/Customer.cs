using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSalesUI.Models
{
    /// <summary>
    /// Represents a customer model.
    /// </summary>
    public class Customer
    {
        public string CustomerName { get; set; }
        public string PhoneNo { get; set; }
        public string Address { get; set; }
        public string ZipCodeCity { get; set; }
    }
}
