using System;
using System.Linq;

namespace Problem_7_Sum_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] secondArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] answerArray = new int[Math.Max(firstArray.Length, secondArray.Length)];
            for (int i = 0; i < Math.Max(firstArray.Length, secondArray.Length); i++)
            {
                answerArray[i] = firstArray[i % firstArray.Length] + secondArray[i % secondArray.Length];
            }
            Console.WriteLine(string.Join(" ", answerArray));
        }
    }
}
