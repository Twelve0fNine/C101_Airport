using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Uebungen_A001
{
    class Program
    {
        public static int j;
        static void Main(string[] args)
        {
            string[,] airports = new string[,] { { "MUC", "München" }, { "CDG", "Charle de Gaul- Paris" }, { "MAD", "Madrid" }, { "HAM", "Hamburg" }, { "BER", "Berlin" }, { "FRA", "Frankfurt" } };
            string search;
            bool next = false;


            while (next == false)
            {
                Console.Clear();
                Console.WriteLine("\nType in the IATA-Code you are searching for!\n");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("In this Demo only these Codes are available!!!\n");
                Console.WriteLine("MUC, CDG, MAD, HAM, BER, FRA\n");
                Console.ForegroundColor = ConsoleColor.White;
                search = Console.ReadLine();
                Console.WriteLine("\n");

                search = search.ToUpper();

                for (int i = 0; i < airports.Length; i++)
                {

                    if (airports[i, 0] == search)
                    {
                        j = i;
                        break;

                    }

                }
                Console.WriteLine("The Name of the Airport is: " + airports[j, 1] + "\n");
                Console.WriteLine("Would you like to go on?\n");
                Console.WriteLine("Yes   1\nNo 2\n");
                switch (Console.ReadLine())
                {
                    case "1": next = false; break;
                    case "2": next = true; break;

                }
            }
        }
    }
}
