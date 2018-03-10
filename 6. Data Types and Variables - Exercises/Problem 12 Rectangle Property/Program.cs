using System;

namespace Problem_12_Rectangle_Property
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double perimeter =Math.Sqrt(Math.Pow(width,2) + Math.Pow(height,2));
            double area = width* height;
            double diagonal = 2*width + 2*height;
            Console.WriteLine(diagonal);
            Console.WriteLine(area);
            Console.WriteLine(perimeter);

        }
    }
}
