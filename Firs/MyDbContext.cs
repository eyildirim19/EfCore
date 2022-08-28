using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firs
{
    // DBContext sınıfı veritabanı objeniz ile c# objenizi ilişkilendiren (mapping) sınıftır. veritabanı bağlantısı bu sınıf üzerinden yapılır....

    public class MyDbContext : DbContext
    {
        // veritabanı yolunu belirtiyoruz...
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\mssqlexpress;Database=Northwind;uid=sa;pwd=123");
        }



        public DbSet<Nakliye> Shippers { get; set; }
        //DBSet ile hangi c# objesinin veritabanı objesi olacağı belirtilir..
    }
}