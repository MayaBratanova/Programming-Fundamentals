using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_4_Numbers_in_Reversed_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            ReverseNumber(number);
        }

        static void ReverseNumber(string number)
        {
            var answer = new List<char>();
            foreach (var symbol in number)
            {
                answer.Add(symbol);
            }
            answer.Reverse();
            Console.WriteLine(string.Join("", answer));
        }
    }
}
