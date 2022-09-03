using EfCoreFluentApi2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreFluentApi2.Mapping
{
    public class UrunMapping : IEntityTypeConfiguration<Urunler>
    {
        public void Configure(EntityTypeBuilder<Urunler> builder)
        {
            builder.Property(c => c.UrunId).HasColumnName("ProductId");
            builder.Property(c => c.UrunAdi).HasColumnName("ProductName");
            builder.Property(c => c.Fiyat).HasColumnName("UnitPrice");
            builder.Property(c => c.Stok).HasColumnName("UnitsInStock");

            builder.HasKey(c => c.UrunId);
            builder.ToTable("Products");
        }
    }
}