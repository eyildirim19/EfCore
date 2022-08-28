// See https://aka.ms/new-console-template for more information
using CodeFirst.Entities;

//Migration => veritabanını visual studio ortamından yönetme işlemidir..

// Migration'ı kullanabilmemiz için Nuget Package Manage  penceresinden EntityFrameowrkCore.Tools kütüphanesi indirmemiz gerekir..

// Migration komutlarını yazabilmek için   Package Manager Console pencersi kullanılır. Tools Menü altına Nuget Package Manager menüsü altında Package Manager Console seçeneği ile bu pencere açılır

// add-migration komutu ile yapılan değişikler için bir migration dosyası oluşturur. Bu dosya sql ayarları vardır.
// update-database komutu ile migration dosyası veritabanına yansıtılır.

Console.WriteLine("Hello, World!");

AppDbContext db = new AppDbContext();


db.Category.ToList();


db.Urunler.ToList();