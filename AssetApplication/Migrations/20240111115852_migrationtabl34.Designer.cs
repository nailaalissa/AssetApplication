﻿// <auto-generated />
using System;
using AssetApplication;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AssetApplication.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20240111115852_migrationtabl34")]
    partial class migrationtabl34
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AssetApplication.Asset", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Currency")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("LocalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Office")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("PurchaseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AssetsList");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Brand = "Samsung",
                            Currency = "SEK",
                            LocalPrice = 234m,
                            Model = "s 13",
                            Office = "USA",
                            Price = 1500m,
                            PurchaseDate = new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "Phone"
                        },
                        new
                        {
                            Id = 2,
                            Brand = "Iphon",
                            Currency = "SEK",
                            LocalPrice = 234m,
                            Model = "iPhone 13",
                            Office = "USA",
                            Price = 1200m,
                            PurchaseDate = new DateTime(2020, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "Phone"
                        },
                        new
                        {
                            Id = 3,
                            Brand = "Lenovo ThinkPad",
                            Currency = "SEK",
                            LocalPrice = 234m,
                            Model = "iPhone 13",
                            Office = "USA",
                            Price = 1000m,
                            PurchaseDate = new DateTime(2023, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "Computer"
                        },
                        new
                        {
                            Id = 4,
                            Brand = "MacBook Pro",
                            Currency = "SEK",
                            LocalPrice = 234m,
                            Model = "iPhone 13",
                            Office = "Sweden",
                            Price = 1500m,
                            PurchaseDate = new DateTime(2022, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "Computer"
                        },
                        new
                        {
                            Id = 5,
                            Brand = "Asus ROG",
                            Currency = "SEK",
                            LocalPrice = 234m,
                            Model = "iPhone 13",
                            Office = "Spain",
                            Price = 1200m,
                            PurchaseDate = new DateTime(2023, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "Computer"
                        },
                        new
                        {
                            Id = 6,
                            Brand = "MacBook Pro",
                            Currency = "SEK",
                            LocalPrice = 234m,
                            Model = "iPhone 13",
                            Office = "USA",
                            Price = 500m,
                            PurchaseDate = new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "Computer"
                        },
                        new
                        {
                            Id = 7,
                            Brand = "Asus ROG",
                            Currency = "SEK",
                            LocalPrice = 234m,
                            Model = "iPhone 13",
                            Office = "Spain",
                            Price = 1200m,
                            PurchaseDate = new DateTime(2023, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "Computer"
                        },
                        new
                        {
                            Id = 8,
                            Brand = "Galaxy S21",
                            Currency = "SEK",
                            LocalPrice = 234m,
                            Model = "iPhone 13",
                            Office = "USA",
                            Price = 900m,
                            PurchaseDate = new DateTime(2021, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "Phone"
                        },
                        new
                        {
                            Id = 9,
                            Brand = "Iphon 14",
                            Currency = "SEK",
                            LocalPrice = 234m,
                            Model = "iPhone 13",
                            Office = "USA",
                            Price = 10m,
                            PurchaseDate = new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "Phone"
                        },
                        new
                        {
                            Id = 10,
                            Brand = "",
                            Currency = "SEK",
                            LocalPrice = 234m,
                            Model = "iPhone 13",
                            Office = "USA",
                            Price = 1200m,
                            PurchaseDate = new DateTime(2023, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "Phone"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
