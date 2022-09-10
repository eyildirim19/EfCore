using EfCoreApp_WithLoadingData.Models;
using Microsoft.EntityFrameworkCore;
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
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();
        }

        public string CustomerID { get; internal set; }

        AppDbContext dbContex = new AppDbContext();
        private void frmCustomer_Load(object sender, EventArgs e)
        {
            //Egear Loding => sorgu esnasında ilişkili kayıtlarında çekilmesidir...sorguya Include metodu ile işkili nesne belirtilir..

            //dbContex.Customers.Include(c=> c.Orders); // Customer ile Orders

            Customer customer = dbContex.Customers.Include(c => c.Orders).FirstOrDefault(c => c.CustomerID == CustomerID);

            //List<Order> orderList = dbContex.Orders.Where(c => c.CustomerId == CustomerID).ToList();

            List<Order> orderList = customer.Orders;
            dgwOrders.DataSource = orderList;


        }

        private void dgwOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //MessageBox.Show(e.RowIndex.ToString());
            //MessageBox.Show(e.ColumnIndex.ToString());
            // veri hücrelerinin dışndaki hücrelere tıklandıysa
            if (e.RowIndex == -1 || e.ColumnIndex == -1)
                return;

            // rows[tiklanansatirindexi].cells[0kolon].degerinin OrderId'ye ata..
            int OrderId = (int)dgwOrders.Rows[e.RowIndex].Cells[0].Value;

            List<OrderDetails> orderDetails = dbContex.OrderDetails.Where(c => c.OrderId == OrderId).ToList();

            dgwOrderDetails.DataSource = orderDetails;
        }
    }
}