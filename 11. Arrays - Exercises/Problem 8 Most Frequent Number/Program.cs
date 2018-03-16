using System;
using System.Linq;

namespace Problem_8_Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int count = 0;
            int maxCount = 0;
            int number = 0;
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < input.Length; j++)
                {
                    if (input[i] == input[j])
                    {
                        count++;
                        if (count > maxCount)
                        {
                            maxCount = count;
                            number = input[i];
                        }
                    }
                    else
                    {
                        count = 0;
                    }
                }
            }
            Console.WriteLine(number);
        }
    }
}
