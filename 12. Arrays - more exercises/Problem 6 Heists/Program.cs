using System;
using System.Linq;

namespace Problem_6_Heists
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputPrice = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string line = "";
            int jewelPrice = inputPrice[0];
            int goldPrice = inputPrice[1];
            long totalHeist = 0;
            long totalEarning = 0;
            while ((line = Console.ReadLine())!="Jail Time")
            {
                string[] input = line.Split(' ').ToArray();
                int heist = int.Parse(input[1]);
                int countJewel = 0; //%
                int countGold = 0; //$
                
                foreach (var symbol in input[0])
                {
                    if (symbol=='%')
                    {
                        countJewel++;
                    }
                    else if (symbol=='$')
                    {
                        countGold ++;
                    }
                }
                long earning = countJewel * jewelPrice + countGold * goldPrice;
                totalHeist += heist;
                totalEarning = totalEarning + earning;
                //line = Console.ReadLine();

            }
            if (totalEarning>=totalHeist)
            {
                Console.WriteLine($"Heists will continue. Total earnings: {totalEarning-totalHeist}.");
            }
            else
            {
                long lost = Math.Abs(totalHeist - totalEarning);
                Console.WriteLine($"Have to find another job. Lost: {lost}.");
            }
        }
    }
}
