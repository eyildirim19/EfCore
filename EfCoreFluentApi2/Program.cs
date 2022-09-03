using EfCoreFluentApi2.Models;
NortAppDbContext dbContext = new NortAppDbContext();
var result = dbContext.Kategoris.ToList();

// Ödev => Nortwind veritabanın efcore yöntemi ile bütün tablolarını ve classlarını(oluşturulacak) ve eşleştirelecek) 

// 14-15 adet tablo var yarısı fluent api yarısı data anontation yöntemi ile olsun...

// Alanlara siz karar verin tablodaki alan sayılarının yarısını yapın... (eğer alan sayısı 5 den fazla ya 5 adet az ise hepsini )

//Not : Categories tablosundaki Picture alanını eşleştirmeyin...