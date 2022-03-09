﻿// <auto-generated />
using System;
using App.Dal.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace App.Dal.Migrations
{
    [DbContext(typeof(ContextMsSqlDb))]
    partial class ContextMsSqlDbModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("App.Entity.Concretes.City", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlateNumber")
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.HasKey("Id");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CreatedTime = new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "ADANA",
                            PlateNumber = "1"
                        },
                        new
                        {
                            Id = 2L,
                            CreatedTime = new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "ADIYAMAN",
                            PlateNumber = "2"
                        },
                        new
                        {
                            Id = 3L,
                            CreatedTime = new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "AFYONKARAHİSAR",
                            PlateNumber = "3"
                        },
                        new
                        {
                            Id = 4L,
                            CreatedTime = new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "AĞRI",
                            PlateNumber = "4"
                        },
                        new
                        {
                            Id = 5L,
                            CreatedTime = new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "AMASYA",
                            PlateNumber = "5"
                        },
                        new
                        {
                            Id = 6L,
                            CreatedTime = new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "ANKARA",
                            PlateNumber = "6"
                        },
                        new
                        {
                            Id = 7L,
                            CreatedTime = new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "ANTALYA",
                            PlateNumber = "7"
                        },
                        new
                        {
                            Id = 8L,
                            CreatedTime = new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "ARTVİN",
                            PlateNumber = "8"
                        },
                        new
                        {
                            Id = 9L,
                            CreatedTime = new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "AYDIN",
                            PlateNumber = "9"
                        },
                        new
                        {
                            Id = 10L,
                            CreatedTime = new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "BALIKESİR",
                            PlateNumber = "10"
                        },
                        new
                        {
                            Id = 11L,
                            CreatedTime = new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "BİLECİK",
                            PlateNumber = "11"
                        },
                        new
                        {
                            Id = 12L,
                            CreatedTime = new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "BİNGÖL",
                            PlateNumber = "12"
                        },
                        new
                        {
                            Id = 13L,
                            CreatedTime = new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "BİTLİS",
                            PlateNumber = "13"
                        },
                        new
                        {
                            Id = 14L,
                            CreatedTime = new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "BOLU",
                            PlateNumber = "14"
                        },
                        new
                        {
                            Id = 15L,
                            CreatedTime = new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "BURDUR",
                            PlateNumber = "15"
                        },
                        new
                        {
                            Id = 16L,
                            CreatedTime = new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "BURSA",
                            PlateNumber = "16"
                        },
                        new
                        {
                            Id = 17L,
                            CreatedTime = new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "ÇANAKKALE",
                            PlateNumber = "17"
                        },
                        new
                        {
                            Id = 18L,
                            CreatedTime = new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "ÇANKIRI",
                            PlateNumber = "18"
                        },
                        new
                        {
                            Id = 19L,
                            CreatedTime = new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "ÇORUM",
                            PlateNumber = "19"
                        },
                        new
                        {
                            Id = 20L,
                            CreatedTime = new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "DENİZLİ",
                            PlateNumber = "20"
                        },
                        new
                        {
                            Id = 21L,
                            CreatedTime = new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "DİYARBAKIR",
                            PlateNumber = "21"
                        },
                        new
                        {
                            Id = 22L,
                            CreatedTime = new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "EDİRNE",
                            PlateNumber = "22"
                        },
                        new
                        {
                            Id = 23L,
                            CreatedTime = new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "ELAZIĞ",
                            PlateNumber = "23"
                        },
                        new
                        {
                            Id = 24L,
                            CreatedTime = new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "ERZİNCAN",
                            PlateNumber = "24"
                        },
                        new
                        {
                            Id = 25L,
                            CreatedTime = new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "ERZURUM",
                            PlateNumber = "25"
                        },
                        new
                        {
                            Id = 26L,
                            CreatedTime = new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "ESKİŞEHİR",
                            PlateNumber = "26"
                        },
                        new
                        {
                            Id = 27L,
                            CreatedTime = new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "GAZİANTEP",
                            PlateNumber = "27"
                        },
                        new
                        {
                            Id = 28L,
                            CreatedTime = new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "GİRESUN",
                            PlateNumber = "28"
                        },
                        new
                        {
                            Id = 29L,
                            CreatedTime = new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "GÜMÜŞHANE",
                            PlateNumber = "29"
                        },
                        new
                        {
                            Id = 30L,
                            CreatedTime = new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "HAKKARİ",
                            PlateNumber = "30"
                        },
                        new
                        {
                            Id = 31L,
                            CreatedTime = new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "HATAY",
                            PlateNumber = "31"
                        },
                        new
                        {
                            Id = 32L,
                            CreatedTime = new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "ISPARTA",
                            PlateNumber = "32"
                        },
                        new
                        {
                            Id = 33L,
                            CreatedTime = new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "MERSİN",
                            PlateNumber = "33"
                        },
                        new
                        {
                            Id = 34L,
                            CreatedTime = new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "İSTANBUL",
                            PlateNumber = "34"
                        },
                        new
                        {
                            Id = 35L,
                            CreatedTime = new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "İZMİR",
                            PlateNumber = "35"
                        },
                        new
                        {
                            Id = 36L,
                            CreatedTime = new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "KARS",
                            PlateNumber = "36"
                        },
                        new
                        {
                            Id = 37L,
                            CreatedTime = new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "KASTAMONU",
                            PlateNumber = "37"
                        },
                        new
                        {
                            Id = 38L,
                            CreatedTime = new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "KAYSERİ",
                            PlateNumber = "38"
                        },
                        new
                        {
                            Id = 39L,
                            CreatedTime = new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "KIRKLARELİ",
                            PlateNumber = "39"
                        },
                        new
                        {
                            Id = 40L,
                            CreatedTime = new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "KIRŞEHİR",
                            PlateNumber = "40"
                        },
                        new
                        {
                            Id = 41L,
                            CreatedTime = new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "KOCAELİ (İZMİT)",
                            PlateNumber = "41"
                        },
                        new
                        {
                            Id = 42L,
                            CreatedTime = new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "KONYA",
                            PlateNumber = "42"
                        },
                        new
                        {
                            Id = 43L,
                            CreatedTime = new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "KÜTAHYA",
                            PlateNumber = "43"
                        },
                        new
                        {
                            Id = 44L,
                            CreatedTime = new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "MALATYA",
                            PlateNumber = "44"
                        },
                        new
                        {
                            Id = 45L,
                            CreatedTime = new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "MANİSA",
                            PlateNumber = "45"
                        },
                        new
                        {
                            Id = 46L,
                            CreatedTime = new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "KAHRAMANMARAŞ",
                            PlateNumber = "46"
                        },
                        new
                        {
                            Id = 47L,
                            CreatedTime = new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "MARDİN",
                            PlateNumber = "47"
                        },
                        new
                        {
                            Id = 48L,
                            CreatedTime = new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "MUĞLA",
                            PlateNumber = "48"
                        },
                        new
                        {
                            Id = 49L,
                            CreatedTime = new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "MUŞ",
                            PlateNumber = "49"
                        },
                        new
                        {
                            Id = 50L,
                            CreatedTime = new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "NEVŞEHİR",
                            PlateNumber = "50"
                        },
                        new
                        {
                            Id = 51L,
                            CreatedTime = new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "NİĞDE",
                            PlateNumber = "51"
                        },
                        new
                        {
                            Id = 52L,
                            CreatedTime = new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "ORDU",
                            PlateNumber = "52"
                        },
                        new
                        {
                            Id = 53L,
                            CreatedTime = new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "RİZE",
                            PlateNumber = "53"
                        },
                        new
                        {
                            Id = 54L,
                            CreatedTime = new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "SAKARYA (ADAPAZARI)",
                            PlateNumber = "54"
                        },
                        new
                        {
                            Id = 55L,
                            CreatedTime = new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "SAMSUN",
                            PlateNumber = "55"
                        },
                        new
                        {
                            Id = 56L,
                            CreatedTime = new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "SİİRT",
                            PlateNumber = "56"
                        },
                        new
                        {
                            Id = 57L,
                            CreatedTime = new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "SİNOP",
                            PlateNumber = "57"
                        },
                        new
                        {
                            Id = 58L,
                            CreatedTime = new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "SİVAS",
                            PlateNumber = "58"
                        },
                        new
                        {
                            Id = 59L,
                            CreatedTime = new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "TEKİRDAĞ",
                            PlateNumber = "59"
                        },
                        new
                        {
                            Id = 60L,
                            CreatedTime = new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "TOKAT",
                            PlateNumber = "60"
                        },
                        new
                        {
                            Id = 61L,
                            CreatedTime = new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "TRABZON",
                            PlateNumber = "61"
                        },
                        new
                        {
                            Id = 62L,
                            CreatedTime = new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "TUNCELİ",
                            PlateNumber = "62"
                        },
                        new
                        {
                            Id = 63L,
                            CreatedTime = new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "ŞANLIURFA",
                            PlateNumber = "63"
                        },
                        new
                        {
                            Id = 64L,
                            CreatedTime = new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "UŞAK",
                            PlateNumber = "64"
                        },
                        new
                        {
                            Id = 65L,
                            CreatedTime = new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "VAN",
                            PlateNumber = "65"
                        },
                        new
                        {
                            Id = 66L,
                            CreatedTime = new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "YOZGAT",
                            PlateNumber = "66"
                        },
                        new
                        {
                            Id = 67L,
                            CreatedTime = new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "ZONGULDAK",
                            PlateNumber = "67"
                        },
                        new
                        {
                            Id = 68L,
                            CreatedTime = new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "AKSARAY",
                            PlateNumber = "68"
                        },
                        new
                        {
                            Id = 69L,
                            CreatedTime = new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "BAYBURT",
                            PlateNumber = "69"
                        },
                        new
                        {
                            Id = 70L,
                            CreatedTime = new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "KARAMAN",
                            PlateNumber = "70"
                        },
                        new
                        {
                            Id = 71L,
                            CreatedTime = new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "KIRIKKALE",
                            PlateNumber = "71"
                        },
                        new
                        {
                            Id = 72L,
                            CreatedTime = new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "BATMAN",
                            PlateNumber = "72"
                        },
                        new
                        {
                            Id = 73L,
                            CreatedTime = new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "ŞIRNAK",
                            PlateNumber = "73"
                        },
                        new
                        {
                            Id = 74L,
                            CreatedTime = new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "BARTIN",
                            PlateNumber = "74"
                        },
                        new
                        {
                            Id = 75L,
                            CreatedTime = new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "ARDAHAN",
                            PlateNumber = "75"
                        },
                        new
                        {
                            Id = 76L,
                            CreatedTime = new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "IĞDIR",
                            PlateNumber = "76"
                        },
                        new
                        {
                            Id = 77L,
                            CreatedTime = new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "YALOVA",
                            PlateNumber = "77"
                        },
                        new
                        {
                            Id = 78L,
                            CreatedTime = new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "KARABÜK",
                            PlateNumber = "78"
                        },
                        new
                        {
                            Id = 79L,
                            CreatedTime = new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "KİLİS",
                            PlateNumber = "79"
                        },
                        new
                        {
                            Id = 80L,
                            CreatedTime = new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "OSMANİYE",
                            PlateNumber = "80"
                        },
                        new
                        {
                            Id = 81L,
                            CreatedTime = new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "DÜZCE",
                            PlateNumber = "81"
                        });
                });

            modelBuilder.Entity("App.Entity.Concretes.District", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("CityId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Districts");
                });

            modelBuilder.Entity("App.Entity.Concretes.FuelPrice", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("APILastSyncTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Brand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("District")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FuelType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsLastUpdated")
                        .HasColumnType("bit");

                    b.Property<string>("Price")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FuelPrices");
                });

            modelBuilder.Entity("App.Entity.Concretes.District", b =>
                {
                    b.HasOne("App.Entity.Concretes.City", "City")
                        .WithMany("Districts")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("App.Entity.Concretes.City", b =>
                {
                    b.Navigation("Districts");
                });
#pragma warning restore 612, 618
        }
    }
}
