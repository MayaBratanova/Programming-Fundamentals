using System;
using System.Linq;

namespace Problem_2_Reverse_Array_of_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int[] numberArray = new int [num];
            for (int i = 0; i < num; i++)
            {
                numberArray[i] = int.Parse(Console.ReadLine()); 
            }
            numberArray = numberArray.Reverse().ToArray();
            foreach (var nums in numberArray)
            {
                Console.Write(nums + " ");
            }
        }
    }
}
