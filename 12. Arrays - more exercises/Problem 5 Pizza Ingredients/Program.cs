using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_5_Pizza_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            int lenght = int.Parse(Console.ReadLine());
            List <string> answer = new List<string>();
            int count = 0;
            
                for (int j = 0; j < input.Length; j++)
                {
                    if (input[j].Length == lenght)
                    {
                        Console.WriteLine($"Adding {input[j]}.");
                        answer.Add(input[j]);
                        count++;
                        if (count==10)
                        {
                            break;
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
            
            Console.WriteLine($"Made pizza with total of {count} ingredients.");
            Console.WriteLine($"The ingredients are: {string.Join(", ", answer)}.");
        }
    }
}
