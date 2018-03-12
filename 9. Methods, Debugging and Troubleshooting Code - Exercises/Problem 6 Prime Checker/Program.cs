using System;
using System.Numerics;

namespace Problem_6_Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            long num = long.Parse(Console.ReadLine());
            Console.WriteLine(isPrime(num));
        }

        static bool isPrime(long number)
        {

            if (number <= 1) return false;
            if (number == 2) return true;

            for (long i = 2; i <= Math.Ceiling(Math.Sqrt(number)); ++i)
            {
                if (number % i == 0) return false;
            }

            return true;

        }
    }
}
