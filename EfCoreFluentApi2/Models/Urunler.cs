using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreFluentApi2.Models
{
    public class Urunler
    {
        public int UrunId { get; set; }
        public string UrunAdi { get; set; }

        // veritabanında smallint burada short
        public short Stok { get; set; }
        public decimal Fiyat { get; set; }
    }
}