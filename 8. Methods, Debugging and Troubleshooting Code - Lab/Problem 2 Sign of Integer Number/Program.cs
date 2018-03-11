using System;

namespace Problem_2_Sign_of_Integer_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            NumberIsPositive(num);

        }
        static void NumberIsPositive(int num)
        {
           
            if (num>0)
            {
                Console.WriteLine($"The number {num} is positive.");
            }
            else if (num==0)
            {
                Console.WriteLine($"The number {num} is zero.");
            }
            else
            {
                Console.WriteLine($"The number {num} is negative.");
            }
        }

    }
}
