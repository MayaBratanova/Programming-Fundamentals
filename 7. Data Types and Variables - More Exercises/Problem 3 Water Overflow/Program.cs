using System;

namespace Problem_3_Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = 255;
            int sum = 0;
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                int liters = int.Parse(Console.ReadLine());
                sum = sum + liters;
                if (sum>capacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                    sum = sum - liters;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
