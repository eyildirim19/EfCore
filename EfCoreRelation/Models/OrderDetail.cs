using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreRelation.Models
{
    public class OrderDetail
    {
        public int OrderNumber { get; set; }
        public int ProductId { get; set; }


        public Product Product { get; set; }
        public Order Order { get; set; }
    }
}
