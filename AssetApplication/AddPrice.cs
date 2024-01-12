using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetApplication
{
    internal class AddPrice
    {
        public decimal Price { get; set; }
        public string Currency { get; set; }
        public string Office { get; set; }
        public decimal LocalPrice { get; set; }


        public AddPrice(decimal price, string office)
        {
            Price = price;
            Office = office;
        }

        public decimal PriceInDollar()   // method to convert input values in dollars and convert them to each currency according to office
        {
            decimal usdToEurRate = 0.92m;
            decimal usdToSekRate = 10.59m;

            switch (Office.ToUpper())
            {
                case "USA":
                    return LocalPrice = Price;

                case "SPAIN":
                    return LocalPrice = Price * usdToEurRate;

                case "SWEDEN":
                    return LocalPrice = Price * usdToSekRate;

                default:
                    Console.WriteLine("Invalid Office");
                    return 0;
            }
        }



        // Method to return currency according to office
        public string GetCurrency()
        {
            switch (Office.ToUpper())
            {
                case "USA":
                    return Currency = "US";


                case "SPAIN":
                    return Currency = "EUR";

                case "SWEDEN":
                    return Currency = "SEK";

                default:

                    return Currency = "US";
            }
        }
    }
}
