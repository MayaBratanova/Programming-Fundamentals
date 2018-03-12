using System;

namespace Problem_2_Max_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            var result = GetMaxInt(num1, num2, num3);
            Console.WriteLine(result);
        }

        static int GetMaxInt(int a, int b, int c)
        {
            var result = Math.Max(a, b);
            return Math.Max(result, c);
            
        }
    }
}
