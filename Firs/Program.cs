// See https://aka.ms/new-console-template for more information
using Firs;

Console.WriteLine("Hello, World!");

/*
        Kütüphaneleri Projeye sağ tık NUget Package Manager pencresinden browse bölümünden ilgili kütüphaneyi bulup indiriyoruz

        aşağıdaki kütüphaneleri projemize indirmemiz gerekir..
        Microsoft.EntityFrameworkCore    (linq queryleri yazamamızı saplayan veritabanı objelerimiz ile c# objelerimizi ilişkilendiren, veritabanı bağlantısını sağlayan kütühnedir)
        Microsoft.EntityFrameworkCore.SqlServer (Sql server kütüphaneisdir...)
 */

MyDbContext dbContext = new MyDbContext();
List<Nakliye> nakliyeList = dbContext.Shippers.ToList();

int a = nakliyeList.Count;
