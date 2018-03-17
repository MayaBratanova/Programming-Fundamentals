using System;
using System.Linq;

namespace Problem_7_Inventory_Matcher
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] products = Console.ReadLine().Split(' ').ToArray();
            long[] quantities = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            decimal[] price = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();
            string line = "";
            while ((line = Console.ReadLine())!="done")
            {
                int i = Array.FindIndex(products, x => x.Contains(line));
                Console.WriteLine($"{products[i]} costs: {price[i]}; Available quantity: {quantities[i]}");
                
            }
        }
    }
}
