using System;
using System.Linq;

namespace Problem_3_Safe_Manipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            string line = "";
            while ((line = Console.ReadLine())!= "END")
            {
                string[] commands = line.Split(' ').ToArray();
                if (commands[0] == "Reverse")
                {
                    input = input.Reverse().ToArray();
                }
                else if (commands[0] == "Distinct")
                {
                    input = input.Distinct().ToArray();
                }
                else if (commands[0] == "Replace")
                {
                    int position = int.Parse(commands[1]);
                    if (position<0 || position>=input.Length)
                    {
                        Console.WriteLine("Invalid input!");
                        continue;
                    }
                    string word = commands[2];
                    input[position] = word;
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
                
            }
            Console.WriteLine(string.Join(", ", input));
        }
    }
}
