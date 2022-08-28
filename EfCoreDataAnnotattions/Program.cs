using EfCoreDataAnnotattions.Entites;

AppDbContext db = new AppDbContext();
var result =db.Customer.ToList();


foreach (var item in result)
{
    Console.WriteLine($"Müşteri Ad= {item.MusteriAdi} İlgili Kişi= {item.İlgliKisi} Unvanı={item.Unvan} TelNo={item.Tel}");
}

Console.ReadKey();