﻿// <auto-generated />
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
    [Migration("20231229123117_conversion3")]
    partial class conversion3
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

                    b.Property<string>("Supplier")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ModelId");

                    b.ToTable("CatalogItems");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ModelId = 1,
                            Price = 50.0,
                            Supplier = "Europcar"
                        },
                        new
                        {
                            Id = 2,
                            ModelId = 2,
                            Price = 80.0,
                            Supplier = "Express"
                        },
                        new
                        {
                            Id = 3,
                            ModelId = 3,
                            Price = 60.0,
                            Supplier = "Budget"
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

            modelBuilder.Entity("backend.Entities.CatalogItem", b =>
                {
                    b.HasOne("backend.Entities.Model", "Model")
                        .WithMany()
                        .HasForeignKey("ModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Model");
                });
#pragma warning restore 612, 618
        }
    }
}
