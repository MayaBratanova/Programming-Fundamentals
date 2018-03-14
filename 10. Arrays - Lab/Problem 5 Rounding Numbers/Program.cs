using System;
using System.Linq;

namespace Problem_5_Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numArray = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            foreach (var num in numArray)
            {
                Console.WriteLine($"{num} => {Math.Round(num, MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
