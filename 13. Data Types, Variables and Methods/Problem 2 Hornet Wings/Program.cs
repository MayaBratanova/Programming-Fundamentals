using System;

namespace Problem_2_Hornet_Wings
{
    class Program
    {
        static void Main(string[] args)
        {
            long wingFlaps = long.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());//for 1000 wingFlats
            long endurance = long.Parse(Console.ReadLine());
            //rest 5 sec
            //100 wingFlaps perSecond
            double answerDistance = (wingFlaps / 1000)*distance;
            double time = wingFlaps / 100 + (wingFlaps / endurance) * 5;
            Console.WriteLine($"{answerDistance:f2} m.");
            Console.WriteLine(time + " s.");
        }
    }
}
