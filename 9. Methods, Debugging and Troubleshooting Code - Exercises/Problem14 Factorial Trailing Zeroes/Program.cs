using System;
using System.Numerics;

namespace Problem14_Factorial_Trailing_Zeroes
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

            BigInteger newNumber = factorialNumber;
            BigInteger count = 0;
            BigInteger zero = 0;
            while (true)
            {
                zero = newNumber % 10;
                if (zero == 0)
                {
                    count++;
                }
                else
                {
                    break;
                }
                newNumber = newNumber / 10;
            }
            return count;
        }
    }
}
