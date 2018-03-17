using System;
using System.Linq;

namespace Problem_3_Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //8 2 2 4 8 16
            var input = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            for (int i = 0; i < input.Count-1; i++)
            {
                if (input[i] == input[i+1])
                {
                    input[i] = input[i] * 2;
                    input.Remove(input[i+1]);
                    i=-1;
                }
                
            }
            Console.WriteLine(string.Join(" ", input));

        }
    }
}
