using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetApplication
{
    internal class Operations 
    {

        public void UpdateAssetData(MyDbContext context)
        {
            Console.WriteLine("Enter the Asset Id you want to update:");
            if (int.TryParse(Console.ReadLine(), out int updateAssetId))
            {
                Asset updateAsset = context.AssetsList.FirstOrDefault(x => x.Id == updateAssetId);
                if (updateAsset != null)
                {
                    Console.WriteLine($"Current Type: {updateAsset.Type}");
                    Console.Write("Enter New Type (press Enter to keep current value): ");
                    string newType = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(newType))
                    {
                        updateAsset.Type = newType;
                    }
                    Console.WriteLine($"Current Brand: {updateAsset.Brand}");
                    Console.Write("Enter New Brand (press Enter to keep current value): ");
                    string newBrand = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(newBrand))
                    {
                        updateAsset.Brand = newBrand;
                    }

                    Console.WriteLine($"Current Purchase Date: {updateAsset.PurchaseDate}");
                    Console.WriteLine($"Current Model: {updateAsset.Model}");
                    Console.Write("Enter New Model (press Enter to keep current value): ");
                    string newModel = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(newModel))
                    {
                        updateAsset.Model = newModel;
                    }

                   
                    Console.Write("Enter New Purchase Date (yyyy-MM-dd) (press Enter to keep current value): ");
                    string newPurchaseDateInput = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(newPurchaseDateInput) && DateTime.TryParse(newPurchaseDateInput, out DateTime newPurchaseDate))
                    {
                        updateAsset.PurchaseDate = newPurchaseDate;
                    }

                    Console.WriteLine($"Current Price: {updateAsset.Price}");
                    Console.Write("Enter New Price (press Enter to keep current value): ");
                    string newPriceInput = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(newPriceInput) && decimal.TryParse(newPriceInput, out decimal newPrice))
                    {
                        updateAsset.Price = newPrice;
                    }

                    Console.WriteLine($"Current Office: {updateAsset.Office}");
                    Console.Write("Enter New Office (press Enter to keep current value): ");
                    string newOffice = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(newOffice))
                    {
                        updateAsset.Office = newOffice;
                    }

                    context.SaveChanges();
                    Console.WriteLine("Asset information updated successfully");
                }
                else
                {
                    Console.WriteLine("Asset not found");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid Id.");
            }
        }

        public void DeleteAssetsByCondition(MyDbContext context)
        {

            Console.WriteLine("Enter the Asset Id you want to Delete it:");
            string IdCondition = Console.ReadLine();
            if (int.TryParse(IdCondition, out int deleteCarId))
            {

                Asset removeCar = context.AssetsList.FirstOrDefault(x => x.Id == deleteCarId);
                if (removeCar != null)
                {
                    context.AssetsList.Remove(removeCar);
                    context.SaveChanges();
                    Console.WriteLine("Car deleted successfully");
                }
                else
                {
                    Console.WriteLine("Car not found");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid Car Id.");
            }
        }
        
        public void AddNewAsset(MyDbContext context)
        {
            Console.WriteLine("Enter the details for the new asset:");

            Console.Write("Type: ");
            string type = Console.ReadLine();

            Console.Write("Model: ");
            string model = Console.ReadLine();

            Console.Write("Brand: ");
            string brand = Console.ReadLine();

            Console.Write("Purchase Date (yyyy-MM-dd): ");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime purchaseDate))
            {
                Console.Write("Price: ");
                if (decimal.TryParse(Console.ReadLine(), out decimal price))
                {
                    Console.Write("Office: ");
                    string office = Console.ReadLine();
                    GetPrice convertPrice = new GetPrice(price, office);  // create object from class GEtPrice
                    string currency = convertPrice.GetCurrency();    //Get value of Currency from the method 
                    decimal localPrice = convertPrice.PriceInDollar();


                    // Create a new Asset object
                    var newAsset = new Asset
                    {
                        Type = type,
                        Model = model,
                        Brand = brand,
                        PurchaseDate = purchaseDate,
                        Price = price,
                        Office = office,
                        Currency = currency,
                        LocalPrice = localPrice
                    };

                    // Add the new asset to the context
                    context.AssetsList.Add(newAsset);

                    // Save changes to the database
                    context.SaveChanges();

                    Console.WriteLine("New asset added successfully.");
                }
                else
                {
                    Console.WriteLine("Invalid price input.");
                }
            }
            else
            {
                Console.WriteLine("Invalid purchase date input.");
            }
        }
        
        public void ReadAssetData(MyDbContext context)
        {
            Console.WriteLine("Reading Asset Data from the List:");
            // Retrieve assets from the database
            var assets = context.AssetsList.ToList();
            foreach (var asset in assets)
            {
                var addPrice = new AddPrice(asset.Price, asset.Office);
                asset.LocalPrice = addPrice.PriceInDollar();
                asset.Currency = addPrice.GetCurrency();
            }
            context.SaveChanges();
            // Print header
            PrintHeader();
            Print(assets);

        }
       
        public void ShowSortList(MyDbContext context)
        {

            string Choice = Console.ReadLine();
            switch (Choice)
            {
                case "1":
                    Console.WriteLine("Print Asset List Sorted By Type then By PurchaseDate");
                    var sortedAssets1 = context.AssetsList
                                   .OrderBy(a => a.Type)
                                   .ThenBy(a => a.PurchaseDate)
                                   .ToList();
                    PrintHeader();
                    Print(sortedAssets1);
                    break;
                case "2":
                    Console.WriteLine("Print Asset List Sorted By Office then By PurchaseDate");
                    var sortedAssets2 = context.AssetsList
                                    .OrderBy(a => a.Office)
                                   .ThenBy(a => a.PurchaseDate)
                                   .ToList();
                    PrintHeader();
                    Print(sortedAssets2);
                    break;
                case "3":
                    break;
                default:                            // error message if enter invaled value
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

        }

        public void Print(List<Asset> SortedProducts)
        {

            foreach (Asset ass in SortedProducts)
            {


                TimeSpan diff = DateTime.Now - ass.PurchaseDate;
                int daysWarning = 180;
                int daysAlarm = 90;
                DecideForegroundColor(daysWarning, daysAlarm, diff);
                string date = ass.PurchaseDate.ToString("yyyy-MM-dd");
                Console.WriteLine(
                     ass.Id.ToString().PadRight(5)+
                     Tab(ass.Type) +
                     Tab(ass.Brand) +
                     Tab(ass.Model) +
                     Tab(date) +
                     Tab(ass.Price.ToString("F2")) +
                     Tab(ass.Office) +
                     Tab(ass.Currency) +
                     Tab(ass.LocalPrice.ToString("F2"))
                   );
                Console.ForegroundColor = ConsoleColor.White;

            }

        }

        public void PrintHeader()
        {

            Console.WriteLine(
                  ("ID").PadRight(5) +
                 Tab("Type") +
                Tab("Brand") +
                Tab("Model") +
                Tab("Purchase Date") +
                Tab("Price") +
                 Tab("Office") +
                Tab("Currency") +
                Tab("In USD today")
                );
            Console.WriteLine(
                 ("---").PadRight(5) +
                 Tab("-----") +
                Tab("-----") +
                Tab("-----") +
                Tab("-------------") +
                Tab("------") +
                Tab("-----") +
                Tab("---------") +
                Tab("------------")
                );
        }
       
        public string Tab(string input)
        {
            return input.PadRight(14);
        }
       
        public void DecideForegroundColor(int daysWarning, int daysAlarm, TimeSpan diff)
        {
            if (diff.Days <= daysAlarm)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else if (diff.Days > daysAlarm && diff.Days <= daysWarning)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

    }
}

