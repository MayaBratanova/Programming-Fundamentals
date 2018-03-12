using System;
using System.Collections.Generic;

namespace Problem_5_Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            
                int n = int.Parse(Console.ReadLine());
                int fibNumber = Fibonacci(n);
                Console.WriteLine(fibNumber);
            
           
        }
        public static int Fibonacci(int n)
        {
            int fibN = 1;
            int fib1 = 0;
            int fib2 = 1;
            for (int i = 0; i < n; i++)
            {
                fibN = fib1 + fib2;
                fib1 = fib2;
                fib2 = fibN;
            }
            return fibN;
        }
    }
}
