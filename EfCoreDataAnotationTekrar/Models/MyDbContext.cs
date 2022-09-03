using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreDataAnotationTekrar.Models
{
    // DbContext => Microsoft.EntityFrameworkCore
    // UseSqlServer => Microsoft.EntityFrameworkCore.SqlServer (provider)
    // AddMigration,UpdateDatabese vs.. => Microsoft.EntityFrameworkCore.Tools

    public class MyDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\mssqlexpress;database=northwind;uid=sa;pwd=123");
        }

        public DbSet<Siparis> Sips { get; set; }
    }
}