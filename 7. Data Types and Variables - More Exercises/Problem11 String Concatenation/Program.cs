using System;
using System.Collections.Generic;

namespace Problem11_String_Concatenation
{
    class Program
    {
        static void Main(string[] args)
        {
            string separator = (Console.ReadLine());
            string evenOdd = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());
            var answerEven = new List<string>();
            var answerOdd = new List<string>();

            for (int i = 1; i <= num; i++)
            {
                if (i % 2 == 0)
                {
                    answerEven.Add(Console.ReadLine());
                }
                else
                {
                    answerOdd.Add(Console.ReadLine());
                }

            }
            if (evenOdd == "even")
            {
                Console.WriteLine(string.Join(separator, answerEven));
            }
            else
            {
                Console.WriteLine(string.Join(separator, answerOdd));
            }
        }  
    }
}
