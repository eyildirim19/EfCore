using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreMigrationandConfiguration.Models
{
    public class Not
    {
        public int Id { get; set; } // Id veua NotId Pk olarak işaretlenir..
        public float? Vize { get; set; }
        public float? Final { get; set; }
        public string NotAdi { get; set; }
        public float? Ortalama
        {
            get
            {
                return Vize * 0.4f + Final * 0.6f;
            }
        }

        // navigation property denir => Navigatipn property veritabanında fiziki oluşutmak için ve sınıflar arasındaki ikilişkiyi sağlamk için kullanılır..

        public int OgrenciId { get; set; }

        [ForeignKey("OgrenciId")] // FK alanımız OgrenciId olsun. Eğer belirtmezsek NavigationProperyName ve EntitySinif PK'sinin adı olur //OgrenciNo veya OgrenciId gibi
        public Ogrenci Ogrenci { get; set; }

    }
}