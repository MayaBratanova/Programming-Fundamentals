using System;

namespace Problem7_Cake_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "";
            int count = 0;
            while ((line = Console.ReadLine())!="Bake!")
            {
                Console.WriteLine($"Adding ingredient {line}.");
                count++;
            }
            Console.WriteLine($"Preparing cake with {count} ingredients.");
        }
    }
}
