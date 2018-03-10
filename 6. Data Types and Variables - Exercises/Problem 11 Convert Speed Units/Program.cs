using System;

namespace Problem_11_Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            double meters = int.Parse(Console.ReadLine());
            double hours = int.Parse(Console.ReadLine());
            double minutes = int.Parse(Console.ReadLine());
            double seconds = int.Parse(Console.ReadLine());
            double timeInSeconds = seconds + minutes * 60 + hours * 60 * 60;
            double timeInHours = hours + minutes/60 + seconds/60/60;
            double distanceInKm = meters / 1000;
            double distanceInMiles = meters / 1609;
            double resultMetersPerSec = meters / timeInSeconds;
            double resultKmPerHour = distanceInKm / timeInHours;
            double resultMilesInHour = distanceInMiles / timeInHours;
            Console.WriteLine(resultMetersPerSec);
            Console.WriteLine(resultKmPerHour);
            Console.WriteLine(resultMilesInHour);
        }
    }
}
