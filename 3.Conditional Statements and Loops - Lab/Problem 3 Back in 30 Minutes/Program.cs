using System;

namespace Problem_3_Back_in_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());
            int newTime = seconds + 30;
            if (newTime>59)
            {
                newTime = newTime - 60;
                hours++;
            }
            if (hours>23)
            {
                hours = 0;
            }
            Console.WriteLine($"{hours}:{newTime:d2}");
        }
    }
}
