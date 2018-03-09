using System;

namespace Problem_1_Centuries_to_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int century = int.Parse(Console.ReadLine());
            int years = century * 100;
            int days = (int)(years * 365.2422);
            int hours = days * 24;
            int minutes = hours * 60;

            Console.WriteLine($"{century} centuries = {years} years =" +
                $" {days} days = {hours} hours" +
                $" = {minutes} minutes");
            //1 centuries = 100 years = 36524 days = 876576 hours = 52594560 minutes
        }
    }
}
