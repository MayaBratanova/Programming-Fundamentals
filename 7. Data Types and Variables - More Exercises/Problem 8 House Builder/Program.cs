using System;
using System.Numerics;

namespace Problem_8_House_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            long sum = 0;
            for (int i = 0; i < 2; i++)
            {
                long number = long.Parse(Console.ReadLine());
                
                if (number>=sbyte.MinValue && number<=sbyte.MaxValue)
                {
                    sum = sum + number * 4;
                }
                else
                {
                    sum = sum + number * 10;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
