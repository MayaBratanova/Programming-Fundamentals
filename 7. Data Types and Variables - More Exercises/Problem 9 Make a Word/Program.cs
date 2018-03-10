using System;
using System.Text;

namespace Problem_9_Make_a_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            var word = new StringBuilder();
            for (int i = 1; i <= num; i++)
            {
                char symbol = char.Parse(Console.ReadLine());
                word.Append(symbol);
            }
            Console.WriteLine($"The word is: {word}");
        }
    }
}
