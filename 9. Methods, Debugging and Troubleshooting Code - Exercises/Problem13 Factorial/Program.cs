using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Problem13_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger num = BigInteger.Parse(Console.ReadLine());
            BigInteger result = Factorial(num);
            Console.WriteLine(result);
        }
        static BigInteger Factorial(BigInteger num)
        {
            BigInteger factorialNumber = 1;

            for (BigInteger i = 1; i <= num; i++)
            {
                factorialNumber = factorialNumber * i;
            }

            return factorialNumber;
        }

    }
}
