using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_5_Short_Words_Sorted
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .ToLower()
                .Split(new char[] { '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?' , ' '}, StringSplitOptions.RemoveEmptyEntries)
                .OrderBy(x => x)
                .Where(x=>x.Length<5)
                .Distinct()
                .ToList();
            Console.WriteLine(string.Join(", ", input));
        }
    }
}
