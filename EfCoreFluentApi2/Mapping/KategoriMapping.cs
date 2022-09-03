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
    // Kategoriler sınıfı ile Categories tablosunun eşleştirilmesi
    // ilişkilendirme IEntityTypeConfiguration interfacesinden miras alınarak ve Configure metodu implement edilerek yapılır...
    public class KategoriMapping : IEntityTypeConfiguration<Kategoriler>
    {
        public void Configure(EntityTypeBuilder<Kategoriler> builder)
        {
            builder.Property(c => c.KategoriId).HasColumnName("CategoryId");
            builder.Property(c => c.KategoriAdi).HasColumnName("CategoryName");

            builder.HasKey(c => c.KategoriId);
            builder.ToTable("Categories");
        }
    }
}
