using System;

namespace Problem_2_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double recArea = width * height;
            Console.WriteLine($"{recArea:f2}");
        }
    }
}
