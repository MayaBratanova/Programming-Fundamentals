using System;
using System.Collections.Generic;
using System.Linq;

namespace CountNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            input.Sort();
            int count = 1;
            int firstELement = input[0];
            bool isLastElementPrinted = false;

            List<int> counter = new List<int>();

            for (int i = 1; i < input.Count; i++)
            {
                int nextElement = input[i];
                if (firstELement == nextElement)
                {
                    count++;
                    if (i ==input.Count-1)
                    {                        
                        Console.WriteLine($"{nextElement} -> {count}");
                        isLastElementPrinted = true;
                    }


                }
                else
                {
                    Console.WriteLine($"{firstELement} -> {count}");
                    count = 1;

                }
                firstELement = input[i];

            }
            if (!isLastElementPrinted)
            {
                Console.WriteLine($"{firstELement} -> {count}");
            }





        }
    }
}
