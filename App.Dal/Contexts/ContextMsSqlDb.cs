using App.Entity.Concretes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Dal.Contexts
{
    public class ContextMsSqlDb : DbContext
    {
        public ContextMsSqlDb(DbContextOptions<ContextMsSqlDb> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<City>().HasData(
                new City() { Id = 1, CreatedTime = Convert.ToDateTime("09.03.2022"), Name = "ADANA", PlateNumber = "1" },
new City() { Id = 2, CreatedTime = Convert.ToDateTime("09.03.2022"), Name = "ADIYAMAN", PlateNumber = "2" },
new City() { Id = 3, CreatedTime = Convert.ToDateTime("09.03.2022"), Name = "AFYONKARAHİSAR", PlateNumber = "3" },
new City() { Id = 4, CreatedTime = Convert.ToDateTime("09.03.2022"), Name = "AĞRI", PlateNumber = "4" },
new City() { Id = 5, CreatedTime = Convert.ToDateTime("09.03.2022"), Name = "AMASYA", PlateNumber = "5" },
new City() { Id = 6, CreatedTime = Convert.ToDateTime("09.03.2022"), Name = "ANKARA", PlateNumber = "6" },
new City() { Id = 7, CreatedTime = Convert.ToDateTime("09.03.2022"), Name = "ANTALYA", PlateNumber = "7" },
new City() { Id = 8, CreatedTime = Convert.ToDateTime("09.03.2022"), Name = "ARTVİN", PlateNumber = "8" },
new City() { Id = 9, CreatedTime = Convert.ToDateTime("09.03.2022"), Name = "AYDIN", PlateNumber = "9" },
new City() { Id = 10, CreatedTime = Convert.ToDateTime("09.03.2022"), Name = "BALIKESİR", PlateNumber = "10" },
new City() { Id = 11, CreatedTime = Convert.ToDateTime("09.03.2022"), Name = "BİLECİK", PlateNumber = "11" },
new City() { Id = 12, CreatedTime = Convert.ToDateTime("09.03.2022"), Name = "BİNGÖL", PlateNumber = "12" },
new City() { Id = 13, CreatedTime = Convert.ToDateTime("09.03.2022"), Name = "BİTLİS", PlateNumber = "13" },
new City() { Id = 14, CreatedTime = Convert.ToDateTime("09.03.2022"), Name = "BOLU", PlateNumber = "14" },
new City() { Id = 15, CreatedTime = Convert.ToDateTime("09.03.2022"), Name = "BURDUR", PlateNumber = "15" },
new City() { Id = 16, CreatedTime = Convert.ToDateTime("09.03.2022"), Name = "BURSA", PlateNumber = "16" },
new City() { Id = 17, CreatedTime = Convert.ToDateTime("09.03.2022"), Name = "ÇANAKKALE", PlateNumber = "17" },
new City() { Id = 18, CreatedTime = Convert.ToDateTime("09.03.2022"), Name = "ÇANKIRI", PlateNumber = "18" },
new City() { Id = 19, CreatedTime = Convert.ToDateTime("09.03.2022"), Name = "ÇORUM", PlateNumber = "19" },
new City() { Id = 20, CreatedTime = Convert.ToDateTime("09.03.2022"), Name = "DENİZLİ", PlateNumber = "20" },
new City() { Id = 21, CreatedTime = Convert.ToDateTime("09.03.2022"), Name = "DİYARBAKIR", PlateNumber = "21" },
new City() { Id = 22, CreatedTime = Convert.ToDateTime("09.03.2022"), Name = "EDİRNE", PlateNumber = "22" },
new City() { Id = 23, CreatedTime = Convert.ToDateTime("09.03.2022"), Name = "ELAZIĞ", PlateNumber = "23" },
new City() { Id = 24, CreatedTime = Convert.ToDateTime("09.03.2022"), Name = "ERZİNCAN", PlateNumber = "24" },
new City() { Id = 25, CreatedTime = Convert.ToDateTime("09.03.2022"), Name = "ERZURUM", PlateNumber = "25" },
new City() { Id = 26, CreatedTime = Convert.ToDateTime("09.03.2022"), Name = "ESKİŞEHİR", PlateNumber = "26" },
new City() { Id = 27, CreatedTime = Convert.ToDateTime("09.03.2022"), Name = "GAZİANTEP", PlateNumber = "27" },
new City() { Id = 28, CreatedTime = Convert.ToDateTime("09.03.2022"), Name = "GİRESUN", PlateNumber = "28" },
new City() { Id = 29, CreatedTime = Convert.ToDateTime("09.03.2022"), Name = "GÜMÜŞHANE", PlateNumber = "29" },
new City() { Id = 30, CreatedTime = Convert.ToDateTime("09.03.2022"), Name = "HAKKARİ", PlateNumber = "30" },
new City() { Id = 31, CreatedTime = Convert.ToDateTime("09.03.2022"), Name = "HATAY", PlateNumber = "31" },
new City() { Id = 32, CreatedTime = Convert.ToDateTime("09.03.2022"), Name = "ISPARTA", PlateNumber = "32" },
new City() { Id = 33, CreatedTime = Convert.ToDateTime("09.03.2022"), Name = "MERSİN", PlateNumber = "33" },
new City() { Id = 34, CreatedTime = Convert.ToDateTime("09.03.2022"), Name = "İSTANBUL", PlateNumber = "34" },
new City() { Id = 35, CreatedTime = Convert.ToDateTime("09.03.2022"), Name = "İZMİR", PlateNumber = "35" },
new City() { Id = 36, CreatedTime = Convert.ToDateTime("09.03.2022"), Name = "KARS", PlateNumber = "36" },
new City() { Id = 37, CreatedTime = Convert.ToDateTime("09.03.2022"), Name = "KASTAMONU", PlateNumber = "37" },
new City() { Id = 38, CreatedTime = Convert.ToDateTime("09.03.2022"), Name = "KAYSERİ", PlateNumber = "38" },
new City() { Id = 39, CreatedTime = Convert.ToDateTime("09.03.2022"), Name = "KIRKLARELİ", PlateNumber = "39" },
new City() { Id = 40, CreatedTime = Convert.ToDateTime("09.03.2022"), Name = "KIRŞEHİR", PlateNumber = "40" },
new City() { Id = 41, CreatedTime = Convert.ToDateTime("09.03.2022"), Name = "KOCAELİ (İZMİT)", PlateNumber = "41" },
new City() { Id = 42, CreatedTime = Convert.ToDateTime("09.03.2022"), Name = "KONYA", PlateNumber = "42" },
new City() { Id = 43, CreatedTime = Convert.ToDateTime("09.03.2022"), Name = "KÜTAHYA", PlateNumber = "43" },
new City() { Id = 44, CreatedTime = Convert.ToDateTime("09.03.2022"), Name = "MALATYA", PlateNumber = "44" },
new City() { Id = 45, CreatedTime = Convert.ToDateTime("09.03.2022"), Name = "MANİSA", PlateNumber = "45" },
new City() { Id = 46, CreatedTime = Convert.ToDateTime("09.03.2022"), Name = "KAHRAMANMARAŞ", PlateNumber = "46" },
new City() { Id = 47, CreatedTime = Convert.ToDateTime("09.03.2022"), Name = "MARDİN", PlateNumber = "47" },
new City() { Id = 48, CreatedTime = Convert.ToDateTime("09.03.2022"), Name = "MUĞLA", PlateNumber = "48" },
new City() { Id = 49, CreatedTime = Convert.ToDateTime("09.03.2022"), Name = "MUŞ", PlateNumber = "49" },
new City() { Id = 50, CreatedTime = Convert.ToDateTime("09.03.2022"), Name = "NEVŞEHİR", PlateNumber = "50" },
new City() { Id = 51, CreatedTime = Convert.ToDateTime("09.03.2022"), Name = "NİĞDE", PlateNumber = "51" },
new City() { Id = 52, CreatedTime = Convert.ToDateTime("09.03.2022"), Name = "ORDU", PlateNumber = "52" },
new City() { Id = 53, CreatedTime = Convert.ToDateTime("09.03.2022"), Name = "RİZE", PlateNumber = "53" },
new City() { Id = 54, CreatedTime = Convert.ToDateTime("09.03.2022"), Name = "SAKARYA (ADAPAZARI)", PlateNumber = "54" },
new City() { Id = 55, CreatedTime = Convert.ToDateTime("09.03.2022"), Name = "SAMSUN", PlateNumber = "55" },
new City() { Id = 56, CreatedTime = Convert.ToDateTime("09.03.2022"), Name = "SİİRT", PlateNumber = "56" },
new City() { Id = 57, CreatedTime = Convert.ToDateTime("09.03.2022"), Name = "SİNOP", PlateNumber = "57" },
new City() { Id = 58, CreatedTime = Convert.ToDateTime("09.03.2022"), Name = "SİVAS", PlateNumber = "58" },
new City() { Id = 59, CreatedTime = Convert.ToDateTime("09.03.2022"), Name = "TEKİRDAĞ", PlateNumber = "59" },
new City() { Id = 60, CreatedTime = Convert.ToDateTime("09.03.2022"), Name = "TOKAT", PlateNumber = "60" },
new City() { Id = 61, CreatedTime = Convert.ToDateTime("09.03.2022"), Name = "TRABZON", PlateNumber = "61" },
new City() { Id = 62, CreatedTime = Convert.ToDateTime("09.03.2022"), Name = "TUNCELİ", PlateNumber = "62" },
new City() { Id = 63, CreatedTime = Convert.ToDateTime("09.03.2022"), Name = "ŞANLIURFA", PlateNumber = "63" },
new City() { Id = 64, CreatedTime = Convert.ToDateTime("09.03.2022"), Name = "UŞAK", PlateNumber = "64" },
new City() { Id = 65, CreatedTime = Convert.ToDateTime("09.03.2022"), Name = "VAN", PlateNumber = "65" },
new City() { Id = 66, CreatedTime = Convert.ToDateTime("09.03.2022"), Name = "YOZGAT", PlateNumber = "66" },
new City() { Id = 67, CreatedTime = Convert.ToDateTime("09.03.2022"), Name = "ZONGULDAK", PlateNumber = "67" },
new City() { Id = 68, CreatedTime = Convert.ToDateTime("09.03.2022"), Name = "AKSARAY", PlateNumber = "68" },
new City() { Id = 69, CreatedTime = Convert.ToDateTime("09.03.2022"), Name = "BAYBURT", PlateNumber = "69" },
new City() { Id = 70, CreatedTime = Convert.ToDateTime("09.03.2022"), Name = "KARAMAN", PlateNumber = "70" },
new City() { Id = 71, CreatedTime = Convert.ToDateTime("09.03.2022"), Name = "KIRIKKALE", PlateNumber = "71" },
new City() { Id = 72, CreatedTime = Convert.ToDateTime("09.03.2022"), Name = "BATMAN", PlateNumber = "72" },
new City() { Id = 73, CreatedTime = Convert.ToDateTime("09.03.2022"), Name = "ŞIRNAK", PlateNumber = "73" },
new City() { Id = 74, CreatedTime = Convert.ToDateTime("09.03.2022"), Name = "BARTIN", PlateNumber = "74" },
new City() { Id = 75, CreatedTime = Convert.ToDateTime("09.03.2022"), Name = "ARDAHAN", PlateNumber = "75" },
new City() { Id = 76, CreatedTime = Convert.ToDateTime("09.03.2022"), Name = "IĞDIR", PlateNumber = "76" },
new City() { Id = 77, CreatedTime = Convert.ToDateTime("09.03.2022"), Name = "YALOVA", PlateNumber = "77" },
new City() { Id = 78, CreatedTime = Convert.ToDateTime("09.03.2022"), Name = "KARABÜK", PlateNumber = "78" },
new City() { Id = 79, CreatedTime = Convert.ToDateTime("09.03.2022"), Name = "KİLİS", PlateNumber = "79" },
new City() { Id = 80, CreatedTime = Convert.ToDateTime("09.03.2022"), Name = "OSMANİYE", PlateNumber = "80" },
new City() { Id = 81, CreatedTime = Convert.ToDateTime("09.03.2022"), Name = "DÜZCE", PlateNumber = "81" }

                );

        }


        public DbSet<FuelPrice> FuelPrices { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<District> Districts { get; set; }
    }
}
