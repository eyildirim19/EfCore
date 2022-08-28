using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Entities
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // AppDb veritabanı henüz oluşturulmadı...
            optionsBuilder.UseSqlServer(@"Server=.\mssqlexpress; Database=AppDb;uid=sa;pwd=123");
        }

        //NOT: eğer belirtmezsek efcore default olarak dbset property isminde tablo oluşturur...
        public DbSet<Category> Category { get; set; }
        public DbSet<Product> Urunler { get; set; }
        public DbSet<Customer> Firms { get; set; }

        public DbSet<Shippers> Shippers { get; set; }
    }
}