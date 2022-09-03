using EfCoreMigrationandConfiguration.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreMigrationandConfiguration.EntityConfiration
{
    // ismi Congiugaration verdik ancak bir önce projemizde Mapping olarak belirtmiştik. 

    public class NotConfiguration : IEntityTypeConfiguration<Not>
    {
        public void Configure(EntityTypeBuilder<Not> builder)
        {
            builder.Property(c => c.NotAdi)
                .HasMaxLength(10)
                .HasColumnType("varchar")
                .IsRequired(false); // vt tarafı null

            builder.Property(c => c.Vize)
                .HasColumnType("decimal")
                .HasPrecision(5, 2); 
            //.IsRequired(false); // tip notnull olduğu için property'de nullable yapılması yeterlidir. 

            builder.Property(c => c.Final)
                .HasColumnType("decimal")
                .HasPrecision(5,2);

            builder.Ignore(c => c.Ortalama); // mapping yapılmaz (NotMapped)


            builder.ToTable("Not");
        }
    }
}
