using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Proxies;

namespace EfCoreApp_WithLoadingData.Models
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\mssqlexpress;Database=Northwind;uid=sa;pwd=123");


          //optionsBuilder.UseLazyLoadingProxies();// lazy loaindg aktif edilir...
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderDetails>().HasKey(c => new { c.OrderId,c.ProductId });
            modelBuilder.Entity<OrderDetails>().ToTable("Order Details");
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
    }
}
