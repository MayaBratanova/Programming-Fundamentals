using System;
using System.Linq;

namespace Problem_2_Manipulate_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                string[] commands = Console.ReadLine().Split(' ').ToArray();
                if (commands[0] == "Reverse")
                {
                    input = input.Reverse().ToArray();
                }
                else if (commands[0]== "Distinct")
                {
                    input = input.Distinct().ToArray();
                }
                else if (commands[0] == "Replace")
                {
                    int position = int.Parse(commands[1]);
                    string word = commands[2];
                    input[position] = word;
                }
            }
            Console.WriteLine(string.Join(", ", input));

        }
    }
}
