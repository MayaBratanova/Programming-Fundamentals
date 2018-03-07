using System;

namespace Problem_4_Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            //name, volume, energy content per 100ml and sugar content per 100ml.
            string name = Console.ReadLine();
            double volume = double.Parse(Console.ReadLine());
            double energy = double.Parse(Console.ReadLine());
            double sugar = double.Parse(Console.ReadLine());
            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{(volume*energy)/100}kcal, {(volume*sugar)/100}g sugars");
            //220ml Nuka-Cola:
            //660kcal, 154g sugars


        }
    }
}
