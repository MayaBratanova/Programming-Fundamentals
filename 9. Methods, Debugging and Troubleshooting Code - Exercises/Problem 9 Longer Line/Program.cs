using System;

public class Program
{

    public static void Main()
    {
        double x1 = double.Parse(Console.ReadLine()); //Координати отсечка точки 1-2
        double y1 = double.Parse(Console.ReadLine());
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());

        double x3 = double.Parse(Console.ReadLine()); // Координати отсечка точки 3-4
        double y3 = double.Parse(Console.ReadLine());
        double x4 = double.Parse(Console.ReadLine());
        double y4 = double.Parse(Console.ReadLine());
        GetTheLongestLine(x1, y1, x2, y2, x3, y3, x4, y4);
    }
    static void GetTheLongestLine(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
    {
        double firstLenght = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
        double secondLenght = Math.Sqrt(Math.Pow((x3 - x4), 2) + Math.Pow((y3 - y4), 2));
        if (firstLenght>secondLenght)
        {
            WhichPointIsSmaller(x1, y1, x2, y2);
        }
        else if (firstLenght<secondLenght)
        {
            WhichPointIsSmaller(x3, y3, x4, y4);
        }
        else if (firstLenght == secondLenght)
        {
            Console.WriteLine($"({x1}, {x2})({y1}, {y2})");
        }
    }

    static void WhichPointIsSmaller(double x1, double x2, double y1, double y2)
    {
        double diagonalFirst = Math.Sqrt(Math.Pow((x1 - 0), 2) + Math.Pow((y1 - 0), 2));
        double diagonalSecond = Math.Sqrt(Math.Pow((x2 - 0), 2) + Math.Pow((y2 - 0), 2));
        if (diagonalFirst<diagonalSecond)
        {
            Console.WriteLine($"({x1}, {x2})({y1}, {y2})");
        }
        else if (diagonalFirst > diagonalSecond)
        {
            Console.WriteLine($"({y1}, {y2})({x1}, {x2})");
        }
        else
        {
            Console.WriteLine($"({x1}, {x2})({y1}, {y2})");
        }
    }
}