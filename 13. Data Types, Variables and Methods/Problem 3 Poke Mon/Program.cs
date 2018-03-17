using System;

namespace Problem_3_Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            double pokePowerN = double.Parse(Console.ReadLine());
            double help = pokePowerN;
            int distanceM = int.Parse(Console.ReadLine());
            int exhaustionFactorY = int.Parse(Console.ReadLine());
            int count = 0;
            while (pokePowerN>=distanceM)
            {
                pokePowerN = pokePowerN - distanceM;
                count++;
                if (pokePowerN == help/2)
                {
                    pokePowerN = Math.Floor(pokePowerN / exhaustionFactorY);
                }

            }
            Console.WriteLine(pokePowerN);
            Console.WriteLine(count);
        }
    }
}
