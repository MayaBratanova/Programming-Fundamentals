using System;
using System.Collections.Generic;

namespace Problem_9_Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Math.Abs(int.Parse(Console.ReadLine()));
            var result = MultiplyEvenAndOdd(num);
            Console.WriteLine(result);
        }

        static int MultiplyEvenAndOdd(int num)
        {
            var oddList = new List<int>();
            var evenList = new List<int>();

            while (num>=0)
            {
                int number = num % 10;
                if (number%2!=0)
                {
                    oddList.Add(number);
                }
                else
                {
                    evenList.Add(number);
                }
                num = num / 10;
            }
            int sumOdd = 0;
            int sumEven = 0;
            foreach (var nums in oddList)
            {
                sumOdd = sumOdd + nums;
            }
            foreach (var nums in evenList)
            {
                sumEven = sumEven + nums;
            }
            return sumOdd * sumEven;
        }
    }
}
