using System;

namespace Problem_3_Miles_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            double miles = double.Parse(Console.ReadLine());
            //1 mile == 1.60934 kilometers
            double km = miles * 1.60934;
            Console.WriteLine($"{km:f2}");
        }
    }
}
