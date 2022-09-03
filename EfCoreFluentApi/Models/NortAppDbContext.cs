using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreFluentApi.Models
{

    //Fluent Api => uygulama varlıkları ile veritabanı varlıkları arasında eşleştirme yapmak için kullanılır..EfCore varsayılan ayarlamaları devre dışı bırakmak için kullanılır..
    public class NortAppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\mssqlexpress;Database=Northwind;uid=sa;pwd=123");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Mapping
            modelBuilder.Entity<Kategoriler>().ToTable("Categories"); // Kategoriler sınıfı ile Categories tablosunu eşleştir
            modelBuilder.Entity<Urunler>().ToTable("Products"); // Urunler sınıfı ile Products tablosunu eşleştir


            //Categories Configuration...
            modelBuilder.Entity<Kategoriler>().HasKey(c => c.KategoriId); //PK
            modelBuilder.Entity<Kategoriler>().Property(c => c.KategoriId).HasColumnName("CategoryId");
            modelBuilder.Entity<Kategoriler>().Property(c => c.KategoriAdi).HasColumnName("CategoryName");
            

            //Product Configuration...
            modelBuilder.Entity<Urunler>().HasKey(c => c.UrunId); //PK
            modelBuilder.Entity<Urunler>().Property(c => c.UrunId).HasColumnName("ProductId");
            modelBuilder.Entity<Urunler>().Property(c => c.UrunAdi).HasColumnName("ProductName");
            modelBuilder.Entity<Urunler>().Property(c => c.Fiyat).HasColumnName("UnitPrice");
            modelBuilder.Entity<Urunler>().Property(c => c.Stok).HasColumnName("UnitsInStock");
        }

        public DbSet<Kategoriler> Kategoris { get; set; }
        public DbSet<Urunler> Uruns { get; set; }
    }
}
