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
    [Migration("20231231134553_register")]
    partial class register
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("backend.Entities.CatalogItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("ModelId")
                        .HasColumnType("integer");

                    b.Property<double>("Price")
                        .HasColumnType("double precision");

                    b.Property<int>("SupplierId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ModelId");

                    b.HasIndex("SupplierId");

                    b.ToTable("CatalogItems");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ModelId = 1,
                            Price = 50.0,
                            SupplierId = 1
                        },
                        new
                        {
                            Id = 2,
                            ModelId = 2,
                            Price = 80.0,
                            SupplierId = 1
                        },
                        new
                        {
                            Id = 3,
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

            modelBuilder.Entity("backend.Entities.Model", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Color")
                        .HasColumnType("text");

                    b.Property<string>("Company")
                        .IsRequired()
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

                    b.ToTable("Models");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Color = "White",
                            Company = "FIAT",
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
                            Color = "Silver",
                            Company = "TOYOTA",
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
                            Color = "White",
                            Company = "TOYOTA",
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
                            BeginTime = new DateTime(2024, 1, 1, 13, 45, 52, 630, DateTimeKind.Utc).AddTicks(1793),
                            CatalogItemId = 1,
                            DriversDetailsId = 1,
                            EndTime = new DateTime(2024, 1, 3, 13, 45, 52, 630, DateTimeKind.Utc).AddTicks(1812),
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            BeginTime = new DateTime(2024, 1, 5, 13, 45, 52, 630, DateTimeKind.Utc).AddTicks(1822),
                            CatalogItemId = 2,
                            DriversDetailsId = 2,
                            EndTime = new DateTime(2024, 1, 8, 13, 45, 52, 630, DateTimeKind.Utc).AddTicks(1822),
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

            modelBuilder.Entity("backend.Entities.CatalogItem", b =>
                {
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

                    b.Navigation("Model");

                    b.Navigation("Supplier");
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
#pragma warning restore 612, 618
        }
    }
}
