using System;
using System.Linq;

namespace Problem_10_Pairs_by_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int num = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i; j < input.Length; j++)
                {
                    if (Math.Abs(input[i] - input[j]) == num)
                    {
                        Console.WriteLine($"{input[i]} -> {input[j]}");
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
