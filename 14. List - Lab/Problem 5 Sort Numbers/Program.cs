using System;
using System.Linq;

namespace Problem_5_Sort_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            input.Sort();
            Console.WriteLine(string.Join(" <= ", input));
        }
    }
}
