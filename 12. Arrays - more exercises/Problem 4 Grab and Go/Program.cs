using System;
using System.Linq;

namespace Problem_4_Grab_and_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] input = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            int num = int.Parse(Console.ReadLine());
            int position = 0;
            long sum = 0;
            bool istrue = false;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == num)
                {
                    if (i>position)
                    {
                        position = i;
                        istrue = true;
                    }
                }
                
            }
            if (istrue)
            {
                for (int i = 0; i < position; i++)
                {
                    sum = sum + input[i];
                }
                Console.WriteLine(sum);
            }
            else
            {
                Console.WriteLine("No occurrences were found!");
            }
        }
    }
}
