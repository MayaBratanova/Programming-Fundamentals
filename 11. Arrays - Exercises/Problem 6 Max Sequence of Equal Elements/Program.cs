using System;
using System.Linq;

namespace Problem_6_Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2 1 1 2 3 3 2 2 2 1 // 2 2 2
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int count = 1;
            int maxCount = 0;
            int maxNum = 0;
            for (int i = 0; i < input.Length-1; i++)
            {
                if (input[i] == input[i+1])
                {
                    count++;
                    if (input[i + 1] == input[input.Length-1])
                    {
                        if (count > maxCount)
                        {
                            maxCount = count;
                            maxNum = input[i];
                        }
                    }
                }
                else
                {
                    if (count>maxCount)
                    {
                        maxCount = count;
                        maxNum = input[i];
                    }
                    count = 1;
                }
                
            }
            for (int i = 0; i < maxCount; i++)
            {
                Console.Write(maxNum+" ");
            }
        }
    }
}
