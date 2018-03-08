using System;

namespace Problem15_Neighbour_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            int peshoDamage = int.Parse(Console.ReadLine());
            int goshoDamage = int.Parse(Console.ReadLine());
            int peshoHealth = 100;
            int goshoHealth = 100;
            int round = 1;
            while (true)
            {
                for (int i = 1; i <= 100; i++)
                {
                    if (i%2==1)
                    {
                        if (goshoHealth<=peshoDamage)
                        {
                            Console.WriteLine($"Pesho won in {round}th round.");
                            return;
                        }
                        goshoHealth = goshoHealth - peshoDamage;
                        Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshoHealth} health.");
                        round++;
                    }
                    else if (i%2==0)
                    {
                        if (peshoHealth <= goshoDamage)
                        {
                            Console.WriteLine($"Gosho won in {round}th round.");
                            return;
                        }
                        peshoHealth = peshoHealth - goshoDamage;
                        Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshoHealth} health.");
                        round++;
                    }
                    if (i%3==0)
                    {
                        goshoHealth = goshoHealth + 10;
                        peshoHealth = peshoHealth + 10;
                    }
                   
                    
                }
                
            }
        }
    }
}
