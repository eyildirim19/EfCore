using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreApp_WithLoadingData.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int EmployeeId { get; set; }
        public string CustomerId { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? ShippedDate { get; set; }
        public string ShipName { get; set; }
        public string ShipAddress { get; set; }

        public virtual Employee Employee { get; set; }
        public Customer Customer { get; set; }
        public List<OrderDetails> OrderDetails { get; set; }
    }
}
