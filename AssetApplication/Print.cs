using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetApplication
{
    internal class Print
    {
        public Print()
        {
        }
        public void mainChoices()
        {
            Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(">> Pick up an Option");
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write(">> ");
            Console.ForegroundColor = ConsoleColor.White; Console.Write("(");
            Console.ForegroundColor = ConsoleColor.Magenta; Console.Write("1");
            Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(") Show the List ");
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write(">> ");
            Console.ForegroundColor = ConsoleColor.White; Console.Write("(");
            Console.ForegroundColor = ConsoleColor.Magenta; Console.Write("2");
            Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(") Add new Asset");
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write(">> ");
            Console.ForegroundColor = ConsoleColor.White; Console.Write("(");
            Console.ForegroundColor = ConsoleColor.Magenta; Console.Write("3");
            Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(") Update Asset ");
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write(">> ");
            Console.ForegroundColor = ConsoleColor.White; Console.Write("(");
            Console.ForegroundColor = ConsoleColor.Magenta; Console.Write("4");
            Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(") Delete Asset");
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write(">> ");
            Console.ForegroundColor = ConsoleColor.White; Console.Write("(");
            Console.ForegroundColor = ConsoleColor.Magenta; Console.Write("5");
            Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(") Save and Quite");

        }

        public void sortChoices()
        {
            Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine(">> Sort Asset  ");
            Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(">> Pick up an Option");
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write(">> ");
            Console.ForegroundColor = ConsoleColor.White; Console.Write("(");
            Console.ForegroundColor = ConsoleColor.Magenta; Console.Write("1");
            Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(") Sort By Type then By Date ");
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write(">> ");
            Console.ForegroundColor = ConsoleColor.White; Console.Write("(");
            Console.ForegroundColor = ConsoleColor.Magenta; Console.Write("2");
            Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(") Sort By Office then By Date");
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write(">> ");
            Console.ForegroundColor = ConsoleColor.White; Console.Write("(");
            Console.ForegroundColor = ConsoleColor.Magenta; Console.Write("3");
            Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(") Return to Main Menue ");
        }
    }
}