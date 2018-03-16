using System;
using System.Linq;

namespace Problem_2_Rotate_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int num = int.Parse(Console.ReadLine());
            int[] helper = new int[numArray.Length];
            for (int i = 0; i < num; i++)
            {
                
                ReverseArray(numArray);
                for (int j = 0; j < helper.Length; j++)
                {
                    helper[j] = helper[j] + numArray[j];
                }
                
            }
            Console.WriteLine(string.Join(" ", helper));

        }
        //3 2 4 -1 //-1 3 2 4
         static int[] ReverseArray(int[] reverse)
        {
            int firstNum = reverse[reverse.Length-1];
            for (int i = reverse.Length-1; i >= 1; i--)
            {
                reverse[i] = reverse[i - 1];
            }
            reverse[0] = firstNum;
            return reverse;
        }
    }
}
