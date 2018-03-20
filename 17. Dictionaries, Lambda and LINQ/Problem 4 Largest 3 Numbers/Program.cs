using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_4_Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).OrderByDescending(x => x).Take(3).ToList();
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
