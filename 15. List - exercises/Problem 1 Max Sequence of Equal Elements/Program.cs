using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_1_Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var helper = new List<int>();
            input.Add(int.MaxValue);
            int count = 1;
            int number = 0;
            int maxCount = 0;
            for (int i = 0; i < input.Count-1; i++)
            {
                if (input[i]==input[i+1])
                {
                    count++;
                }
                else
                {
                    if (count>maxCount)
                    {
                        maxCount = count;
                        number = input[i];
                    }
                    count = 1;
                }
               
            }
            for (int i = 0; i < maxCount; i++)
            {
                helper.Add(number);
            }
            Console.WriteLine(string.Join(" ", helper));
        }
    }
}
