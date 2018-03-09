using System;

namespace Problem_5_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            int newNum = 0;
            for (int i = 1; i <= num; i++)
            {
                newNum = i;
                while (newNum > 0)
                {
                    sum = sum + newNum % 10;
                    newNum = newNum / 10;
                }
                if (sum == 5 || sum == 7 || sum == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }
                sum = 0;
            }
        }
    }
}
