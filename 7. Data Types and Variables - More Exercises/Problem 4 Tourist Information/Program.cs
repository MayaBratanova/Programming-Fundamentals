using System;

namespace Problem_4_Tourist_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            string imperialUnit = Console.ReadLine();
            double value = double.Parse(Console.ReadLine());

            //miles to kilometers, inches to centimeters, feet to centimeters, yards to meters and gallons to liters

            if (imperialUnit == "miles")
            {
                Console.WriteLine($"{value} {imperialUnit} = {value*1.6:f2} kilometers");
            }
            else if (imperialUnit == "inches")
            {
                Console.WriteLine($"{value} {imperialUnit} = {value * 2.54:f2} centimeters");
            }
            else if (imperialUnit == "feet")
            {
                Console.WriteLine($"{value} {imperialUnit} = {value * 30:f2} centimeters");
            }
            else if (imperialUnit == "yards")
            {
                Console.WriteLine($"{value} {imperialUnit} = {value * 0.91:f2} meters");
            }
            else if (imperialUnit == "gallons")
            {
                Console.WriteLine($"{value} {imperialUnit} = {value * 3.8:f2} liters");
            }
        }
    }
}
