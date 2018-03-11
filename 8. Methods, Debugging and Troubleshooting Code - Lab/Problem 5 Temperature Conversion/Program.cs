using System;

namespace Problem_5_Temperature_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            double fahrenheit = double.Parse(Console.ReadLine());
            var celsuis =  ConvertTempInCelsius(fahrenheit);
            Console.WriteLine($"{celsuis:f2}");
        }

        static double ConvertTempInCelsius(double fahrenheit)
        {
             return (fahrenheit - 32) * 5 / 9;
        }
    }
}
