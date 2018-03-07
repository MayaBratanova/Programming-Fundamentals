using System;

namespace Problem_5_Character_Stats
{
    class Program
    {
        static void Main(string[] args)
        {
            // name, current health, maximum health, current energy and maximum energy 
            string name = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maximumHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maximumEnergy = int.Parse(Console.ReadLine());
            Console.WriteLine($"Name: {name}");
            string health = new string('|', currentHealth);
            string leftHealth = new string('.', maximumHealth - currentHealth);
            Console.WriteLine($"Health: |{health}{leftHealth}|");
            string energy = new string('|', currentEnergy);
            string leftEnerdgy = new string('.', maximumEnergy - currentEnergy);
            Console.WriteLine($"Energy: |{energy}{leftEnerdgy}|");

        }
    }
}
