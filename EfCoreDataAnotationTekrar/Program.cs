
using EfCoreDataAnotationTekrar.Models;

MyDbContext dbContext = new MyDbContext();

List<Siparis> sip = dbContext.Sips.ToList(); // bütün kayıtları sip nesnesine aktar..

var sipList = dbContext.Sips.Where(c => c.GonderimTarihi == null).ToList();

var sipList1 = dbContext.Sips.Where(c => c.GonderimTarihi != null).ToList();

int a = 1;