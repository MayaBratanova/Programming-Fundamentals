﻿using System;

namespace Problem_3_Exact_Sum_of_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            decimal sum = 0;
            for (int i = 0; i < num; i++)
            {
                sum = sum + decimal.Parse(Console.ReadLine());
            }
            Console.WriteLine(sum);
        }
    }
}
