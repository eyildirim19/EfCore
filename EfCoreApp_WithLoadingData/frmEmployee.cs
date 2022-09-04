using EfCoreApp_WithLoadingData.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EfCoreApp_WithLoadingData
{
    public partial class frmEmployee : Form
    {
        public frmEmployee()
        {
            InitializeComponent();
        }

        public int EmployeeId { get; internal set; }

        AppDbContext dbContex = new AppDbContext();
        // Formun yüklenme olayı...
        private void frmEmployee_Load(object sender, EventArgs e)
        {
            // Önce gidip empyee bilgilerine erişip emplyee bilgilerini aldık...
            Employee employee = dbContex.Employees.FirstOrDefault(c => c.EmployeeId == EmployeeId);
            this.Text = $"Hoş Geldin {employee.FullName}";



            // Kayıtları lazy loding yöntemi ile alıyoruz... (Lazy Loading) => ilişkili  kayıtların ihtiyaç duyulması halinde yüklenmesi demektir..
            // Lazy LOaind kayapbilmrk için ;
            //1 navigation propertyler virual olarak işaretleninr
            //2 EntityFrameworkCore.Proxies package indirilir...
            //3 DbContext sınıfında LazyLoading aktif edilir

            // Order bilgilerini employeeeId'ye göre çektik...
            //List<Order> orderList = dbContex.Orders.Where(c => c.EmployeeId == EmployeeId).ToList();

            // örnek;
            // tam burada vt'e sorgu atılarak emplooeye ile ilişkili kayıtlar çekilir...
            List<Order> orderList = employee.Orders;

            dgwOrders.DataSource = orderList;
        }
    }
}