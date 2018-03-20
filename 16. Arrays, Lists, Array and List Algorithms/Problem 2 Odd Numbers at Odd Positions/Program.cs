using System;
using System.Linq;

namespace Problem_2_Odd_Numbers_at_Odd_Positions
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            for (int i = 1; i < input.Count; i+=2)
            {
                if (input[i]%2==1 || input[i] % 2 == -1)
                {
                    Console.WriteLine($"Index {i} -> {input[i]}");
                }
            }
        }
    }
}
