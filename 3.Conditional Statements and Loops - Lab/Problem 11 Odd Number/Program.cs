using System;

namespace Problem_11_Odd_Number
{
    class Program
    {
        static void Main(string[] args)
        {
           
            for (int i = 0; i < 10; i++)
            {
                int num = Math.Abs(int.Parse(Console.ReadLine()));
                if (num%2 == 1)
                {
                    Console.WriteLine($"The number is: {Math.Abs(num)}");
                    return;
                }
                else
                {
                    Console.WriteLine("Please write an odd number.");
                   
                }
            }
        }
    }
}
