using EfCoreMigrationandConfiguration.EntityConfiration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreMigrationandConfiguration.Models
{
    public class OkulDbContex : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\mssqlexpress; Database=OkulDb; uid=sa;pwd=123");
        }

        // Ogrenci sınıfı Table atrribute ile işaretlendiği için vt tarafında Ogrenci olarak belirtildi. App tarafında dbset ile Ogrencis olarak belirtildi...


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new NotConfiguration());
        }


        public DbSet<Ogrenci> Ogrencis { get; set; }

    }
}
