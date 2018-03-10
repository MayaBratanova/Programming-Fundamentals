using System;
using System.Numerics;

namespace Problem_10_Centuries_to_Nano
{
    class Program
    {
        static void Main(string[] args)
        {
            //years, days, hours, minutes, seconds, milliseconds, microseconds, nanoseconds.
            long centuries = int.Parse(Console.ReadLine());
            long years = centuries * 100;
            long days = (int)(years * 365.2422);
            long hours = days * 24;
            long minutes = hours * 60;
            BigInteger seconds = minutes * 60;
            BigInteger milliseconds = seconds * 1000;
            BigInteger microseconds = milliseconds * 1000;
            BigInteger nanoseconds = microseconds * 1000;
            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours " +
                $"= {minutes} minutes = {seconds} seconds " +
                $"= {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");

        }
    }
}
