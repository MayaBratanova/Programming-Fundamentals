using System;

namespace Problem_6_Calculate_Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double triangleBase = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            var result = TriangleArea(triangleBase, height);
            Console.WriteLine(result);
        }
        static double TriangleArea(double triangleBase , double height)
        {
            double triangleArea = (triangleBase * height) / 2;
            return triangleArea;
        }
    }
}
