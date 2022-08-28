using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreDataAnnotattions.Entites
{

    // DataAnnotatiton ile ef core'daki default kurallara (convention) devre dışı bırakılarak entity varlıklaklrı özelliştirilir...sınıf veya propertyler atribute ile özelleştirilir...


    // [TableName] ile sınıf ve tablo mapping edilir. eğer bu isimde tablo varsa sınıf o tabloya eşleştirilir. eğer tablo yoksa migration yapılarak tablo oluşuturlur ve sınıf ile eşleştirilir...

    [Table("Firms")] // veritabanındaki Firm tablosu ile eşleş...
    public class Customer
    {
        public int CustomerId { get; set; }

        [Column("CustomerName")]  // MusteriAdi alanının veritabanındaki karşılığı CustomerName alanıdır....
        public string MusteriAdi { get; set; }

        [Column("ContactName")]
        public string İlgliKisi { get; set; }

        [Column("ContactTitle")]
        public string Unvan { get; set; }

        [Column("Phone")]
        public string Tel { get; set; }
    }
}