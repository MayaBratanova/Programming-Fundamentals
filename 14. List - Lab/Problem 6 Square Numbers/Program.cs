using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_6_Square_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var helper = new List<int>();
            for (int i = 0; i < input.Count; i++)
            {
                if (Math.Sqrt(input[i]) == (int)Math.Sqrt(input[i]))
                {
                    helper.Add(input[i]);
                }
            }
            helper.Sort();
            helper.Reverse();
            Console.WriteLine(string.Join(" ", helper));
        }
    }
}
