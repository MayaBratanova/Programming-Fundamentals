using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_1_Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var helper = new List<int>();

            for (int i = 0; i < input.Count; i++)
            {
                if (input[i]>=0)
                {
                    helper.Add(input[i]);
                }
            }
            if (helper.Count==0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                helper.Reverse();
                Console.WriteLine(string.Join(", ", helper));
            }
            
        }
    }
}
