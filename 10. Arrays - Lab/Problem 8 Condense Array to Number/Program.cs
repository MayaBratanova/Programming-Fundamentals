using System;
using System.Linq;

namespace Problem_8_Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            
            while (numbers.Length>1)
            {
                int[] helper = new int[numbers.Length - 1];
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    helper[i] = numbers[i] + numbers[i + 1];
                }
                numbers = helper;
               
                
            }

            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
