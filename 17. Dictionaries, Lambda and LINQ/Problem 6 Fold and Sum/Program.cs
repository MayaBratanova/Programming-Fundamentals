using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_6_Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 2 3 4 5 6 7 8
            // 2 1 8 7 3 4 5 6
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var answer = new List<int>();
            int k = input.Count / 4;
            var helper = input.Take(k).Reverse().ToList();
            input.Reverse();
            helper.AddRange(input.Take(k));
            input.Reverse();
            input.RemoveRange(0, k);
            for (int i = 0; i < 2*k; i++)
            {
                int result = helper[i] + input[i];
                answer.Add(result);
            }
            Console.WriteLine(string.Join(" ", answer));

        }
    }
}
