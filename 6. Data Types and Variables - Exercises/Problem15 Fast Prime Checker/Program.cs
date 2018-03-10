using System;

namespace Fast_Prime_Checker___Refactor
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            for (int i = 2; i <= a; i++)
            {
                bool num = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        num = false;
                        break;
                    }
                }
                Console.WriteLine($"{i} -> {num}");
            }

        }
    }
}