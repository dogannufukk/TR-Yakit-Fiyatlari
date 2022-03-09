using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace App.Dal.Migrations
{
    public partial class FirstInit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlateNumber = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FuelPrices",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FuelType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    APILastSyncTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsLastUpdated = table.Column<bool>(type: "bit", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FuelPrices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Districts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CityId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Districts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Districts_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CreatedTime", "Name", "PlateNumber" },
                values: new object[,]
                {
                    { 1L, new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "ADANA", "1" },
                    { 58L, new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "SİVAS", "58" },
                    { 57L, new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "SİNOP", "57" },
                    { 56L, new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "SİİRT", "56" },
                    { 55L, new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "SAMSUN", "55" },
                    { 54L, new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "SAKARYA (ADAPAZARI)", "54" },
                    { 53L, new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "RİZE", "53" },
                    { 52L, new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "ORDU", "52" },
                    { 59L, new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "TEKİRDAĞ", "59" },
                    { 51L, new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "NİĞDE", "51" },
                    { 49L, new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "MUŞ", "49" },
                    { 48L, new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "MUĞLA", "48" },
                    { 47L, new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "MARDİN", "47" },
                    { 46L, new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "KAHRAMANMARAŞ", "46" },
                    { 45L, new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "MANİSA", "45" },
                    { 44L, new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "MALATYA", "44" },
                    { 43L, new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "KÜTAHYA", "43" },
                    { 50L, new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "NEVŞEHİR", "50" },
                    { 60L, new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "TOKAT", "60" },
                    { 61L, new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "TRABZON", "61" },
                    { 62L, new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "TUNCELİ", "62" },
                    { 79L, new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "KİLİS", "79" },
                    { 78L, new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "KARABÜK", "78" },
                    { 77L, new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "YALOVA", "77" },
                    { 76L, new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "IĞDIR", "76" },
                    { 75L, new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "ARDAHAN", "75" },
                    { 74L, new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "BARTIN", "74" },
                    { 73L, new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "ŞIRNAK", "73" },
                    { 72L, new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "BATMAN", "72" },
                    { 71L, new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "KIRIKKALE", "71" },
                    { 70L, new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "KARAMAN", "70" },
                    { 69L, new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "BAYBURT", "69" },
                    { 68L, new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "AKSARAY", "68" },
                    { 67L, new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "ZONGULDAK", "67" },
                    { 66L, new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "YOZGAT", "66" },
                    { 65L, new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "VAN", "65" },
                    { 64L, new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "UŞAK", "64" },
                    { 63L, new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "ŞANLIURFA", "63" },
                    { 42L, new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "KONYA", "42" },
                    { 80L, new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "OSMANİYE", "80" },
                    { 41L, new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "KOCAELİ (İZMİT)", "41" },
                    { 39L, new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "KIRKLARELİ", "39" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CreatedTime", "Name", "PlateNumber" },
                values: new object[,]
                {
                    { 17L, new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "ÇANAKKALE", "17" },
                    { 16L, new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "BURSA", "16" },
                    { 15L, new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "BURDUR", "15" },
                    { 14L, new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "BOLU", "14" },
                    { 13L, new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "BİTLİS", "13" },
                    { 12L, new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "BİNGÖL", "12" },
                    { 11L, new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "BİLECİK", "11" },
                    { 18L, new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "ÇANKIRI", "18" },
                    { 10L, new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "BALIKESİR", "10" },
                    { 8L, new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "ARTVİN", "8" },
                    { 7L, new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "ANTALYA", "7" },
                    { 6L, new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "ANKARA", "6" },
                    { 5L, new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "AMASYA", "5" },
                    { 4L, new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "AĞRI", "4" },
                    { 3L, new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "AFYONKARAHİSAR", "3" },
                    { 2L, new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "ADIYAMAN", "2" },
                    { 9L, new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "AYDIN", "9" },
                    { 19L, new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "ÇORUM", "19" },
                    { 20L, new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "DENİZLİ", "20" },
                    { 21L, new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "DİYARBAKIR", "21" },
                    { 38L, new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "KAYSERİ", "38" },
                    { 37L, new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "KASTAMONU", "37" },
                    { 36L, new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "KARS", "36" },
                    { 35L, new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "İZMİR", "35" },
                    { 34L, new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "İSTANBUL", "34" },
                    { 33L, new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "MERSİN", "33" },
                    { 32L, new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "ISPARTA", "32" },
                    { 31L, new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "HATAY", "31" },
                    { 30L, new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "HAKKARİ", "30" },
                    { 29L, new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "GÜMÜŞHANE", "29" },
                    { 28L, new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "GİRESUN", "28" },
                    { 27L, new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "GAZİANTEP", "27" },
                    { 26L, new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "ESKİŞEHİR", "26" },
                    { 25L, new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "ERZURUM", "25" },
                    { 24L, new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "ERZİNCAN", "24" },
                    { 23L, new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "ELAZIĞ", "23" },
                    { 22L, new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "EDİRNE", "22" },
                    { 40L, new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "KIRŞEHİR", "40" },
                    { 81L, new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "DÜZCE", "81" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Districts_CityId",
                table: "Districts",
                column: "CityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Districts");

            migrationBuilder.DropTable(
                name: "FuelPrices");

            migrationBuilder.DropTable(
                name: "Cities");
        }
    }
}
