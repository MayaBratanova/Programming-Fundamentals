using System;
using System.Linq;

namespace Problem_6_Reverse_an_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').Reverse().ToArray();
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
