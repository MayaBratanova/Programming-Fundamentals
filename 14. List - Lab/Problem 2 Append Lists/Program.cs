using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_2_Append_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 2 3 |4 5 6 |  7  8
            //7 8 4 5 6 1 2 3
            var input = Console.ReadLine().Split('|').ToList();
            var helper = new List<int>();
            var answer = new List<int>();
            input.Reverse();
            for (int i = 0; i < input.Count; i++)
            {
                helper = input[i].Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
                for (int j = 0; j < helper.Count; j++)
                {
                    answer.Add(helper[j]);
                }
            }
            Console.WriteLine(string.Join(" ", answer));
            

        }
    }
}
