using System;

namespace Problem_9_Index_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            foreach (var symbol in input)
            {
                char num = char.Parse(symbol.ToString());
                int n = num-'a';
                Console.WriteLine($"{symbol} -> {n}");
            }
        }
    }
}
