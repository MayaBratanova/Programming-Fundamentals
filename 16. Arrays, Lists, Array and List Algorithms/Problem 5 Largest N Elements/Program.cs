using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_5_Largest_N_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int num = int.Parse(Console.ReadLine());
            input.Sort();
            input.Reverse();
            var helper = new List<int>();

            for (int i = 0; i < num; i++)
            {
                helper.Add(input[i]);
            }
            Console.WriteLine(string.Join(" ", helper));
        }
    }
}
