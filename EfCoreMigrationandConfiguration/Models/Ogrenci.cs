using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreMigrationandConfiguration.Models
{

    // DataAnotation Yöntemi ile Configuration yapıyoruz...

    [Table("Ogrenci")]
    public class Ogrenci
    {
        [Key] // PK 
        public int No { get; set; }
        public string Adi { get; set; }
        public string SoyAdi { get; set; }

        [Column("TelNo", TypeName = "varchar")]
        [StringLength(11)] // karakter sayısı 11 karakter
        public string? Telefon { get; set; }

        [NotMapped] // bu alanı eşleştirme...
        public string FullAd
        {
            get
            {
                return $"{Adi} {SoyAdi}";
            }
        }
    }
}