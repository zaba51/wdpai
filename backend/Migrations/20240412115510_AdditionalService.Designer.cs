﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using backend.DbContexts;

#nullable disable

namespace backend.Migrations
{
    [DbContext(typeof(AutomobileContext))]
    [Migration("20240412115510_AdditionalService")]
    partial class AdditionalService
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("AdditionalServiceReservation", b =>
                {
                    b.Property<int>("AdditionalServicesId")
                        .HasColumnType("integer");

                    b.Property<int>("ReservationsId")
                        .HasColumnType("integer");

                    b.HasKey("AdditionalServicesId", "ReservationsId");

                    b.HasIndex("ReservationsId");

                    b.ToTable("AdditionalServiceReservation");
                });

            modelBuilder.Entity("backend.Entities.AdditionalService", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("Price")
                        .HasColumnType("double precision");

                    b.Property<string>("ServiceCategory")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("AdditionalServices");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "",
                            Name = "Additional Insurance",
                            Price = 15.0,
                            ServiceCategory = "INSURANCE"
                        },
                        new
                        {
                            Id = 2,
                            Description = "",
                            Name = "Bike holder",
                            Price = 10.0,
                            ServiceCategory = "BIKE_HOLDER"
                        },
                        new
                        {
                            Id = 3,
                            Description = "",
                            Name = "Child seat",
                            Price = 15.0,
                            ServiceCategory = "CHILD_SEAT"
                        },
                        new
                        {
                            Id = 4,
                            Description = "",
                            Name = "Animal Carrier",
                            Price = 7.0,
                            ServiceCategory = "ANIMAL_CARRIER"
                        });
                });

            modelBuilder.Entity("backend.Entities.CarCompany", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("CarCompanies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Code = "FIAT",
                            Name = "Fiat"
                        },
                        new
                        {
                            Id = 2,
                            Code = "TOYOTA",
                            Name = "Toyota"
                        });
                });

            modelBuilder.Entity("backend.Entities.CatalogItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("LocationId")
                        .HasColumnType("integer");

                    b.Property<int>("ModelId")
                        .HasColumnType("integer");

                    b.Property<double>("Price")
                        .HasColumnType("double precision");

                    b.Property<int>("SupplierId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.HasIndex("ModelId");

                    b.HasIndex("SupplierId");

                    b.ToTable("CatalogItems");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            LocationId = 1,
                            ModelId = 1,
                            Price = 50.0,
                            SupplierId = 1
                        },
                        new
                        {
                            Id = 2,
                            LocationId = 1,
                            ModelId = 2,
                            Price = 80.0,
                            SupplierId = 1
                        },
                        new
                        {
                            Id = 3,
                            LocationId = 1,
                            ModelId = 3,
                            Price = 60.0,
                            SupplierId = 2
                        });
                });

            modelBuilder.Entity("backend.Entities.DriversDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("DriversDetails");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Country = "USA",
                            Name = "John",
                            Number = "123456789",
                            Surname = "Doe"
                        },
                        new
                        {
                            Id = 2,
                            Country = "Canada",
                            Name = "Jane",
                            Number = "987654321",
                            Surname = "Smith"
                        });
                });

            modelBuilder.Entity("backend.Entities.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("CityName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("CountryName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Locations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CityName = "Warsaw",
                            CountryName = "Poland"
                        },
                        new
                        {
                            Id = 2,
                            CityName = "Prague",
                            CountryName = "Chech Republic"
                        },
                        new
                        {
                            Id = 3,
                            CityName = "Cracow",
                            CountryName = "Poland"
                        },
                        new
                        {
                            Id = 4,
                            CityName = "Gdansk",
                            CountryName = "Poland"
                        },
                        new
                        {
                            Id = 5,
                            CityName = "Berlin",
                            CountryName = "Germany"
                        },
                        new
                        {
                            Id = 6,
                            CityName = "Paris",
                            CountryName = "France"
                        });
                });

            modelBuilder.Entity("backend.Entities.Model", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CarCompanyId")
                        .HasColumnType("integer");

                    b.Property<string>("Color")
                        .HasColumnType("text");

                    b.Property<int>("DoorCount")
                        .HasColumnType("integer");

                    b.Property<string>("Engine")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Gear")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("Power")
                        .HasColumnType("integer");

                    b.Property<int>("SeatCount")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CarCompanyId");

                    b.ToTable("Models");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CarCompanyId = 2,
                            Color = "White",
                            DoorCount = 5,
                            Engine = "HYBRID",
                            Gear = "AUTOMATIC",
                            ImageUrl = "https://flib.carshow360.net/700/900/705993b922662ed39c6.webp",
                            Name = "Panda",
                            Power = 69,
                            SeatCount = 5
                        },
                        new
                        {
                            Id = 2,
                            CarCompanyId = 1,
                            Color = "Silver",
                            DoorCount = 5,
                            Engine = "HYBRID",
                            Gear = "AUTOMATIC",
                            ImageUrl = "https://cfm.pl/wp-content/uploads/2021/04/toyota-corolla-sd-srebrna-dlugoterminowy-glowne-cfm.jpg",
                            Name = "Corolla",
                            Power = 140,
                            SeatCount = 5
                        },
                        new
                        {
                            Id = 3,
                            CarCompanyId = 1,
                            Color = "White",
                            DoorCount = 5,
                            Engine = "GASOLINE",
                            Gear = "MANUAL",
                            ImageUrl = "https://media.ed.edmunds-media.com/toyota/corolla/2023/oem/2023_toyota_corolla_sedan_xse_fq_oem_1_600.jpg",
                            Name = "Corolla",
                            Power = 140,
                            SeatCount = 6
                        });
                });

            modelBuilder.Entity("backend.Entities.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("BeginTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("CatalogItemId")
                        .HasColumnType("integer");

                    b.Property<int>("DriversDetailsId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CatalogItemId");

                    b.HasIndex("DriversDetailsId");

                    b.HasIndex("UserId");

                    b.ToTable("Reservations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BeginTime = new DateTime(2024, 4, 13, 11, 55, 9, 104, DateTimeKind.Utc).AddTicks(9327),
                            CatalogItemId = 1,
                            DriversDetailsId = 1,
                            EndTime = new DateTime(2024, 4, 15, 11, 55, 9, 104, DateTimeKind.Utc).AddTicks(9338),
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            BeginTime = new DateTime(2024, 4, 17, 11, 55, 9, 104, DateTimeKind.Utc).AddTicks(9342),
                            CatalogItemId = 2,
                            DriversDetailsId = 2,
                            EndTime = new DateTime(2024, 4, 20, 11, 55, 9, 104, DateTimeKind.Utc).AddTicks(9344),
                            UserId = 2
                        });
                });

            modelBuilder.Entity("backend.Entities.Supplier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("LogoUrl")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Suppliers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            LogoUrl = "https://www.europcar.com/_nuxt/img/europcar-signature-green@3x.a2d761a.png",
                            Name = "Europcar"
                        },
                        new
                        {
                            Id = 2,
                            LogoUrl = "https://www.enterprise.com/content/experience-fragments/ecom/en/footer/master/_jcr_content/root/footer/footer/container/container/image.coreimg.png/1692607172448/logo-enterprise.png",
                            Name = "Enterpsie"
                        });
                });

            modelBuilder.Entity("backend.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("SupplierId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "alice@example.com",
                            Password = "pass1",
                            Role = "user"
                        },
                        new
                        {
                            Id = 2,
                            Email = "bob@example.com",
                            Password = "pass1",
                            Role = "supplier"
                        });
                });

            modelBuilder.Entity("LocationSupplier", b =>
                {
                    b.Property<int>("LocationsId")
                        .HasColumnType("integer");

                    b.Property<int>("SuppliersId")
                        .HasColumnType("integer");

                    b.HasKey("LocationsId", "SuppliersId");

                    b.HasIndex("SuppliersId");

                    b.ToTable("LocationSupplier");
                });

            modelBuilder.Entity("AdditionalServiceReservation", b =>
                {
                    b.HasOne("backend.Entities.AdditionalService", null)
                        .WithMany()
                        .HasForeignKey("AdditionalServicesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("backend.Entities.Reservation", null)
                        .WithMany()
                        .HasForeignKey("ReservationsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("backend.Entities.CatalogItem", b =>
                {
                    b.HasOne("backend.Entities.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("backend.Entities.Model", "Model")
                        .WithMany()
                        .HasForeignKey("ModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("backend.Entities.Supplier", "Supplier")
                        .WithMany()
                        .HasForeignKey("SupplierId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Location");

                    b.Navigation("Model");

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("backend.Entities.Model", b =>
                {
                    b.HasOne("backend.Entities.CarCompany", "CarCompany")
                        .WithMany()
                        .HasForeignKey("CarCompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CarCompany");
                });

            modelBuilder.Entity("backend.Entities.Reservation", b =>
                {
                    b.HasOne("backend.Entities.CatalogItem", "CatalogItem")
                        .WithMany()
                        .HasForeignKey("CatalogItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("backend.Entities.DriversDetails", "DriversDetails")
                        .WithMany()
                        .HasForeignKey("DriversDetailsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("backend.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CatalogItem");

                    b.Navigation("DriversDetails");

                    b.Navigation("User");
                });

            modelBuilder.Entity("LocationSupplier", b =>
                {
                    b.HasOne("backend.Entities.Location", null)
                        .WithMany()
                        .HasForeignKey("LocationsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("backend.Entities.Supplier", null)
                        .WithMany()
                        .HasForeignKey("SuppliersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
