using System;

namespace Problem11_Geometry_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine().ToLower();
            if (command == "triangle")
            {
                GetAreaTriangle();
            }
            else if (command == "square")
            {
                GetAreaSquare();
            }
            else if (command == "rectangle")
            {
                GetAreaRectangle();
            }
            else if (command == "circle")
            {
                GetAreaCircle();
            }
        }

        static void GetAreaCircle()
        {
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine($"{Math.PI * (radius * radius):f2}");
        }

        static void GetAreaRectangle()
        {
            double side = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine($"{side * height:f2}");
        }

        static void GetAreaSquare()
        {
            double side = double.Parse(Console.ReadLine());
            Console.WriteLine($"{side * side:f2}");
        }

        private static void GetAreaTriangle()
        {
            double side = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine($"{(side * height)/ 2:f2}");
        }
    }
}
