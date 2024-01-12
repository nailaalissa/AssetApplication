// See https://aka.ms/new-console-template for more information
using AssetApplication;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello To Asset Tracking Console Appication");
MyDbContext Context = new MyDbContext();
List<Asset> assets= Context.AssetsList.ToList();
Operations operations = new Operations();
Print print = new Print();


while (true)
{
   
    // Print the main Choices from class print
    print.mainChoices();

    string mainChoice = Console.ReadLine();

    switch (mainChoice)
    {
        case "1":
            operations.ReadAssetData(Context);
            print.sortChoices();
            operations.ShowSortList(Context);
            break;
        case "2":

            operations.AddNewAsset(Context);
            break;
        case "3":
            operations.UpdateAssetData(Context);
            break;
        case "4":

            operations.DeleteAssetsByCondition(Context);
            break;
        case "5":
            Context.SaveChanges();
            Environment.Exit(0);              // to close the program

            break;
        default:                            // error message if enter invaled value
            Console.WriteLine("Invalid choice. Please try again.");
            break;
    }
}



