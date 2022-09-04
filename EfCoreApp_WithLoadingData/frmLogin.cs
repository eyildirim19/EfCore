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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            AppDbContext dbContext = new AppDbContext();
            if (rbCalisan.Checked)
            {
                int EmployeeId = Convert.ToInt32(txtAppID.Text);
                // EmployeID vt'de pk olduğu için tek bir kayıt aranıp tek bir kayıt dönecektir...
                // First=> bulunan ilk kaydı tekil döner.Eğer kayıt yoksa hata fırlatır..
                //Employee employee = dbContext.Employees.First(c => c.EmployeeId == EmployeeId);
                Employee employee = dbContext.Employees.FirstOrDefault(c => c.EmployeeId == EmployeeId);
                if (employee == null)
                {
                    MessageBox.Show("Kullanıcı Bulunamadı");
                    return; // metodu sonlandır...
                }

                frmEmployee frm = new frmEmployee();
                frm.EmployeeId = employee.EmployeeId; // calisanID'yi diğer forma gönderiyoruz...
                frm.Show();
            }
            else if (rbMusteri.Checked)
            {
                Customer customer = dbContext.Customers.FirstOrDefault(c => c.CustomerID == txtAppID.Text);
                if (customer == null)
                {
                    MessageBox.Show("Müşteri Bulunamadı...");
                    return;
                }
                frmCustomer frm = new frmCustomer();
                frm.CustomerID = customer.CustomerID; // müşteriID'yi diğer forma gönderiyoruz....
                frm.Show();
            }
        }
    }
}