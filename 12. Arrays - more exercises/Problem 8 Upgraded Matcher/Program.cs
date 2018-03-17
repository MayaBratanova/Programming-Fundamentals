using System;
using System.Linq;

namespace Problem_8_Upgraded_Matcher
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] products = Console.ReadLine().Split(' ').ToArray();
            long[] quantities = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            decimal[] price = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();
            string line = "";
            while ((line = Console.ReadLine()) != "done")
            {
                string[] input = line.Split(' ').ToArray();
                long orderedQuant = long.Parse(input[1]);
                long i = Array.FindIndex(products, x => x.Contains(input[0]));
                long newQuant = 0;
                if (i >= quantities.Length || i < 0)
                {
                    newQuant = 0;
                }
                else
                {
                    newQuant = quantities[i];
                    quantities[i] = quantities[i] - orderedQuant;
                }

                if (orderedQuant<=newQuant)
                {
                    Console.WriteLine($"{products[i]} x {orderedQuant} costs {orderedQuant*price[i]:f2}");
                }
                else
                {
                    Console.WriteLine($"We do not have enough {products[i]}");
                }

            }
        }
    }
}
