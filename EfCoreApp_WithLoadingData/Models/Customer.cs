using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreApp_WithLoadingData.Models
{
    public class Customer
    {
        public string CustomerID { get; set; } 

        public string CompanyName { get; set; }

        public string ContactName { get; set; }

        public List<Order> Orders { get; set; }
    }
}