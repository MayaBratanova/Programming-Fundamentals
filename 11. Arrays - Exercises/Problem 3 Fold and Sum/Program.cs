using System;
using System.Linq;

namespace Problem_3_Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] helper = new int[input.Length / 4];
            int[] answer = new int[input.Length / 2];
            int k = input.Length / 4;
            for (int i = 0; i < k; i++)
            {
                helper[i] = input[i];
            }
            helper = helper.Reverse().ToArray();
            for (int i = 0; i < helper.Length; i++)
            {
                answer[i] = helper[i];
            }
            input = input.Reverse().ToArray();
            for (int i = 0; i < k; i++)
            {
                helper[i] = input[i];
            }
            for (int i = 0; i < helper.Length; i++)
            {
                answer[k+i] = helper[i];
            }
            input = input.Reverse().ToArray();
            int maya = 0;
            int[] result = new int[input.Length / 2];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = answer[i] + input[k + i];
            }
            Console.WriteLine(string.Join(" ", result));


        }
    }
}
