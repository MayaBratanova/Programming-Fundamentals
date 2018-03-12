using System;

namespace Problem_1_Hello__Name_
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            PrintGreating(name);
        }

         static void PrintGreating(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
