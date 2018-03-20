using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_3_Min__Max__Sum__Average
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            var input = new List<int>();
            for (int i = 0; i < num; i++)
            {
                input.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine($"Sum = {input.Sum()}");
            Console.WriteLine($"Min = {input.Min()}");
            Console.WriteLine($"Max = {input.Max()}");
            Console.WriteLine($"Average = {input.Average()}");
        }
    }
}
