using System;

namespace Problem_2_Add_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            Console.WriteLine($"{firstNum} + {secondNum} = {firstNum+secondNum}");
        }
    }
}
