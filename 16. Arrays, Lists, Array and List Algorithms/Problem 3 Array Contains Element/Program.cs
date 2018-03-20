using System;
using System.Linq;

namespace Problem_3_Array_Contains_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            int num = int.Parse(Console.ReadLine());
            if (input.Contains(num))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
