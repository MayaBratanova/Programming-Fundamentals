using System;
using System.Linq;

namespace Problem10__Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int sum1 = 0;
            int sum2 = 0;
            bool istrue = false;
            for (int i = 0; i < input.Length; i++)
            {
                sum1 = sum1 + input[i];
                for (int j = i + 2; j < input.Length; j++)
                {
                    sum2 = sum2 + input[j];
                }
                if (sum1 == sum2)
                {
                    Console.WriteLine(i + 1);
                    istrue = true;
                }
                sum2 = 0;
            }
            if (input.Length == 1)
            {
                istrue = true;
                Console.WriteLine(0);
                
            }
            if (istrue == false)
            {
                Console.WriteLine("no");
            }
           


        }
    }
}
