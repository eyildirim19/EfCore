using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
    }

    //Default Class içerisinde eğer Id propertysi varsa bu pk'dır..
}
