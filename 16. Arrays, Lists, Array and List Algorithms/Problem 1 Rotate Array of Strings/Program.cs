using System;
using System.Linq;

namespace Problem_1_Rotate_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //soft uni hi -> hi soft
            var input = Console.ReadLine().Split(' ').ToList();
            string lastString = input[input.Count - 1];
            for (int i = input.Count - 1; i >= 1; i--)
            {
                input[i] = input[i-1];
            }
            input[0] = lastString;
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
