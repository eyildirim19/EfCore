using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreRelation.Models
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\mssqlexpress;Database=DbApp; uid=sa;pwd=123");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserDetail>()
                .HasOne(c => c.Users)
                .WithOne(c => c.UserDetay)
                .HasForeignKey<UserDetail>(c => c.UserId);

            modelBuilder.Entity<Order>()
                .HasKey(c => c.OrderNumber); // OrderNumber PK olarak tanımla...


            // OrderNumber ve ProductId alanlarını tek bir key (composit key) olarak tanımlıyoruz..
            modelBuilder.Entity<OrderDetail>()
                .HasKey(c => new { c.OrderNumber, c.ProductId });

            modelBuilder.Entity<Order>()
                .HasOne(c => c.User)
                .WithMany(c => c.Order)
                .HasForeignKey(c => c.UserId); //Order.UsreId

            modelBuilder.Entity<OrderDetail>()
                .HasOne(c => c.Product)
                .WithMany(c => c.OrderDetails)
                .HasForeignKey(c => c.ProductId);

            modelBuilder.Entity<OrderDetail>()
                .HasOne(c => c.Order)
                .WithMany(c => c.OrderDetails)
                .HasForeignKey(c => c.OrderNumber);
        }

        public DbSet<User> User { get; set; }
        public DbSet<UserDetail> UserDetail { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }

    }
}