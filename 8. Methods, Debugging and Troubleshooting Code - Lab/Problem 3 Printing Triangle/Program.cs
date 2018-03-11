using System;

namespace Problem_3_Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            PrintNumsTriangle(num);

        }

        static void PrintNumsTriangle(int num)
        {
            PrintFirstPart(num);
            PrintSecondPart(num);
        }
        static void PrintFirstPart(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
        static void PrintSecondPart(int num)
        {
            for (int i = num - 1; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }

    }
}
