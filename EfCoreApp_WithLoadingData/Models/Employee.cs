using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreApp_WithLoadingData.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Title { get; set; }

        public string FullName
        {
            get
            {
                return $"{Title} {FirstName} {LastName}";
            }
        }

        public virtual List<Order> Orders { get; set; }
    }
}