using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetApplication
{
    internal class MyDbContext : DbContext
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Assets;Integrated Security=True";
        public DbSet<Asset> AssetsList { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // We tell the app to use the connectionstring.
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder ModelBuilder)
        {
            ModelBuilder.Entity<Asset>().HasData(

            new Asset { Id = 1, Type = "Phone", Brand = "Samsung", Model = "s13", PurchaseDate = new DateTime(2022, 1, 1), Price = 1500, Office = "USA", Currency = "USUS", LocalPrice = 234.34m },
            new Asset { Id = 2, Type = "Phone", Brand = "Iphon", Model = "iPhone13", PurchaseDate = new DateTime(2019, 2, 15), Price = 1200, Office = "USA", Currency = "", LocalPrice = 234 },
            new Asset { Id = 3, Type = "Computer", Brand = "Lenovo ", Model = "ThinkPad", PurchaseDate = new DateTime(2023, 9, 10), Price = 1000, Office = "SPAIN", Currency = "EUR", LocalPrice = 234 },
            new Asset { Id = 4, Type = "Computer", Brand = "MacBook Pro", Model = "Pro13", PurchaseDate = new DateTime(2022, 11, 1), Price = 678, Office = "Sweden", Currency = "SEK", LocalPrice = 344 },
            new Asset { Id = 5, Type = "Computer", Brand = "Asus ", Model = "ROG3", PurchaseDate = new DateTime(2023, 12, 15), Price = 2340, Office = "Spain", Currency = "EUR", LocalPrice = 234 },
            new Asset { Id = 6, Type = "Computer", Brand = "MacBook ", Model = "Pro L2", PurchaseDate = new DateTime(2018, 11, 1), Price = 500, Office = "USA", Currency = "US", LocalPrice = 234 },
            new Asset { Id = 7, Type = "Computer", Brand = "Asus ROG", Model = "ROG", PurchaseDate = new DateTime(2023, 2, 15), Price = 345, Office = "Spain", Currency = "EUR", LocalPrice = 234 },
            new Asset { Id = 8, Type = "Phone", Brand = "Galaxy ", Model = "S21", PurchaseDate = new DateTime(2021, 11, 15), Price = 900, Office = "USA", Currency = "", LocalPrice = 234 },
            new Asset { Id = 9, Type = "Phone", Brand = "Iphon", Model = "iPhone 14", PurchaseDate = new DateTime(2022, 1, 1), Price = 190, Office = "Spain", Currency = "EUR", LocalPrice = 234 },
            new Asset { Id = 10, Type = "Phone", Brand = "Motorola", Model = "DL 13", PurchaseDate = new DateTime(2023, 6, 15), Price = 789, Office = "USA", Currency = "US", LocalPrice = 234 },
            new Asset { Id = 11, Type = "Phone", Brand = "Samsung", Model = "s13", PurchaseDate = new DateTime(2022, 1, 1), Price = 234, Office = "Sweden", Currency = "SEK", LocalPrice = 234.34m },
            new Asset { Id = 12, Type = "Phone", Brand = "Motorola", Model = "Razr", PurchaseDate = new DateTime(2000, 4, 15), Price = 456, Office = "USA", Currency = "US", LocalPrice = 234 },
            new Asset { Id = 13, Type = "Computer", Brand = "Asus ", Model = "W234", PurchaseDate = new DateTime(2017 ,04 , 21), Price = 1000, Office = "sweden", Currency = "SEK", LocalPrice = 234 },
            new Asset { Id = 14, Type = "Computer", Brand = "HP", Model = "Elitebook", PurchaseDate = new DateTime(2023, 11, 5), Price = 588, Office = "Spain", Currency = "EUR", LocalPrice = 344 }

            );

        }

        }
}
