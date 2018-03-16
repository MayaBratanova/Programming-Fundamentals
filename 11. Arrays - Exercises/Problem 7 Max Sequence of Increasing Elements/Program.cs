using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_7_Max_Sequence_of_Increasing_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3   2 3 4    2 2 4
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int count = 1;
            int maxCount = 0;
            int position = 0;
            for (int i = 1; i < input.Length; i++)
            {
                if (input[i]>input[i-1])
                {
                    count++;
                    if (count > maxCount)
                    {
                        maxCount = count;
                        position = i + 1;
                    }
                }
                else
                {
                    count = 1;
                }
            }
            int[] result = new int[maxCount];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = input[position - maxCount + i];
            }
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
