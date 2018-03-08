using System;

namespace Problem12_Test_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int real1 = Math.Min(num1, num2);
            int real2 = Math.Max(num1, num2);
            int magicNum = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = real2; i >= real1; i--)
            {
                for (int j = real1; j <= real2; j++)
                {
                    count++;
                    if (i + j == magicNum)
                    {
                        Console.Write($"Number found! ");
                        Console.WriteLine($"{i} + {j} = {magicNum}");
                        return;
                    }
                }
            }

            Console.WriteLine($"{count} combinations - neither equals {magicNum}");

        }
    }
}
