using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSalesUI.Models
{
    public class CarImportModel
    {
        [Name("brand")]
        public string Brand { get; set; }
        [Name("model")]
        public string Model { get; set; }
        [Name("year")]
        public string Year { get; set; }
        [Name("price")]
        public double Price { get; set; }
    }
}
