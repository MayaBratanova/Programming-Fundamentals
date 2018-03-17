using System;
using System.Linq;

namespace Problem_7_Count_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var helper = new int[1001];
            for (int i = 0; i < input.Count; i++)
            {
                int currentNumber = input[i];
                helper[currentNumber]++;
            }
            for (int i = 0; i < helper.Length; i++)
            {
                if (helper[i]>0)
                {
                    Console.WriteLine($"{i} -> {helper[i]}");
                }
            }
        }
    }
}
