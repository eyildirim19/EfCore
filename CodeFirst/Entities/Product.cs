using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        public string? ProductName { get; set; }
        public decimal? Price { get; set; }
        public short? Stock { get; set; }
        public bool? IsEnable { get; set; }

    }
    // Default olarak eğer sınıf içrisinde SinifNameId varsa bu pk'dır..
}
