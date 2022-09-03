

using EfCoreFluentApi.Models;

NortAppDbContext dbContext = new NortAppDbContext();

var result = dbContext.Kategoris.ToList();

var prodList = dbContext.Uruns.ToList();



Console.WriteLine("Kapatmak için bir tuşa basın");
Console.ReadKey();