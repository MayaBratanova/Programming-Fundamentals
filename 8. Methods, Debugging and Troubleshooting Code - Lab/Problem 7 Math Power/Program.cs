using System;

namespace Problem_7_Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine(CalculateNumberPow(num1, num2));

        }

        static double CalculateNumberPow(double num1, double num2)
        {
            return Math.Pow(num1, num2);
        }
    }
}
