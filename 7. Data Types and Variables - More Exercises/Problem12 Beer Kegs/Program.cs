using System;

namespace Problem12_Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            double volume = 0.0;
            double maxVolume = int.MinValue;
            string bigName = "";
            for (int i = 1; i <= num; i++)
            {
                string name = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                volume = Math.PI * Math.Pow(radius, 2) * height;
                if (volume>maxVolume)
                {
                    maxVolume = volume;
                    bigName = name;
                }
            }
            Console.WriteLine(bigName);
        }
    }
}
