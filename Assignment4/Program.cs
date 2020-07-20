using Assignment4.Entities;
using Assignment4.SortingAlgorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            Database db = new Database();
            var shirts = db.Shirts.ToArray();

            //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("BubbleSort");
            Console.WriteLine("~~~~~~~~~~~");

            Console.WriteLine("Ascending order by size, color and fabric");
            BubbleSort.SizeColorFabricAscendingOrder(shirts);
            PrintAllItems(shirts);

            Console.WriteLine("Descending order by size, color and fabric");
            BubbleSort.SizeColorFabricDescendingOrder(shirts);
            PrintAllItems(shirts);

            Console.WriteLine("Ascending order by fabric");
            BubbleSort.FabricAscendingOrder(shirts);
            PrintAllItems(shirts);

            Console.WriteLine("Descending order by fabric");
            BubbleSort.FabricDescendingOrder(shirts);
            PrintAllItems(shirts);

            //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("QuickSort");
            Console.WriteLine("~~~~~~~~~~~");

            Console.WriteLine("Ascending order by color");
            QuickSort.ColorAscending(shirts);
            PrintAllItems(shirts);

            Console.WriteLine("Descending order by color");
            QuickSort.ColorDescending(shirts);
            PrintAllItems(shirts);

            //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("BucketSort");
            Console.WriteLine("~~~~~~~~~~~");

            Console.WriteLine("Ascending order by size");
            var listSizeAsc = BucketSort.SizeAscending(shirts);
            PrintAllItems(listSizeAsc.ToArray());

            Console.WriteLine("Descending order by size");
            var listSizeDesc = BucketSort.SizeDescending(shirts);
            PrintAllItems(listSizeDesc.ToArray());
            


            UserApplication.BuyShirt();

            Console.ReadKey();
        }

        public static void PrintAllItems(Shirt[] shirts)
        {
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("{0,-15} {1,-15} {2,-15}", "Color", "Size", "Fabric");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var item in shirts)
            {
                item.Output();
            }
            Console.WriteLine();
        }
    }
}
