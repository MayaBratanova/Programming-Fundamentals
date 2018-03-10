using System;

namespace Problem_5_Weather_Forecast
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            string text = "";
            try
            {
                double num = double.Parse(number);
                text = "Rainy";
            }
            catch
            {
            }
            try
            {
                long num = long.Parse(number);
                text = "Windy";
            }
            catch
            {
            }
          
            try
            {
                int num = int.Parse(number);
                text = "Cloudy";
            }
            catch
            {
            }
            try
            {
                sbyte num = sbyte.Parse(number);
                text = "Sunny";
            }
            catch
            {
            }


            Console.WriteLine(text);
        }
    }
}
