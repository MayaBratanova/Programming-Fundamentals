using System;

namespace Problem_8_Center_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            //int diagonal = Math.Sqrt(Math.Pow(x2 - x1), 2 + Math.Pow(y2 - y1), 2);
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            ClosestPoint(x1, y1, x2, y2);

        }

         static void ClosestPoint(double x1, double y1, double x2, double y2)
        {
            double diagonalFirst = Math.Sqrt(Math.Pow((x1 -0), 2) + Math.Pow((y1 - 0), 2));
            double diagonalSecond = Math.Sqrt(Math.Pow((x2 - 0), 2) + Math.Pow((y2 - 0), 2));
            if (diagonalFirst<diagonalSecond)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else if (diagonalFirst > diagonalSecond)
            {
                Console.WriteLine($"({x2}, {y2})");
            }
            else
            {
                Console.WriteLine($"({x1}, {y1})");
            }
        }
    }
}
