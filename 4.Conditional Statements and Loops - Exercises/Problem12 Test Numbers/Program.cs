using System;

namespace Problem12_Test_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int possibleSum = int.Parse(Console.ReadLine());
            int count = 0;
            int sum = 0;
            for (int i = num1; i >= 1; i--)
            {
                for (int j = 1; j <= num2; j++)
                {
                    sum = sum + (i * j) * 3;
                    count++;
                    if (sum>=possibleSum)
                    {
                        Console.WriteLine($"{count} combinations");
                        Console.WriteLine($"Sum: {sum} >= {possibleSum}");
                        return;
                    }
                }
            }
            if (sum<possibleSum)
            {
                Console.WriteLine($"{count} combinations");
                Console.WriteLine($"Sum: {sum}");
            }
          
        }
    }
}
