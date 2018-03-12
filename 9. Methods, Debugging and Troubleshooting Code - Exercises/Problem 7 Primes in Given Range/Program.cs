using System;
using System.Collections.Generic;

namespace Problem_7_Primes_in_Given_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            long num1 = long.Parse(Console.ReadLine());
            long num2 = long.Parse(Console.ReadLine());
            
            var result = isPrime(num1, num2);
            Console.WriteLine(string.Join(", ", result));
        }

        static List<long> isPrime(long num1, long num2)
        {
            var result = new List<long>();
            for (long i = num1; i <= num2; i++)
            {
                bool isPrime = true;
                if (i < 2) isPrime = false;
                for (long j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    result.Add(i);
                }
            }
            return result;
        }
    }
}
