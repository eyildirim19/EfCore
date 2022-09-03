using System.ComponentModel.DataAnnotations.Schema;

namespace EfCoreDataAnotationTekrar.Models
{


    [Table("Orders")] // Eşleşilecek veritabanı tablsonun adını berlirtiriz..
    public class Siparis
    {
        // Column atriubute ile eşleşişlecek colonlar belirtilir.
        [Column("OrderId")]
        public int SiparisId { get; set; }

        [Column("CustomerId")]
        public string MusteriId { get; set; }

        [Column("OrderDate")]
        public DateTime SiparisTarihi { get; set; }

        [Column("ShippedDate")]
        //public Nullable<DateTime> GonderimTarihi { get; set; }
        public DateTime? GonderimTarihi { get; set; }

        [Column("EmployeeId")]
        public int CalisanId { get; set; }

    }
}