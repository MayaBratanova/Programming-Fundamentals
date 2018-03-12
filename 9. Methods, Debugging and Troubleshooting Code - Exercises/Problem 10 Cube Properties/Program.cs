using System;

namespace Problem_10_Cube_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            if (command == "face")
            {
                GetFace(length);
            }
            else if (command == "space")
            {
                GetSpace(length);
            }
            else if (command == "volume")
            {
                GetVolume(length);
            }
            else if (command == "area")
            {
                GetArea(length);
            }
        }
        static void GetArea(double length)
        {
            var result = 6 * Math.Pow(length, 2);
            Console.WriteLine($"{result:f2}"); 
        }
        static void GetSpace(double length)
        {
            var result = Math.Sqrt(3) * length;
            Console.WriteLine($"{result:f2}");
        }
        static void GetVolume(double length)
        {
            var result = Math.Pow(length, 3);
            Console.WriteLine($"{result:f2}");
        }
        static void GetFace(double length)
        {
            var result = Math.Sqrt(2)* length;
            Console.WriteLine($"{result:f2}");
        }
    }
}
