using System;

namespace Problem_3_Employee_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Name: {Console.ReadLine()}");
            Console.WriteLine($"Age: {int.Parse(Console.ReadLine())}");
            Console.WriteLine($"Employee ID: {int.Parse(Console.ReadLine()):d8}");
            Console.WriteLine($"Salary: {double.Parse(Console.ReadLine()):f2}");

        }
    }
}
