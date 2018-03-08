using System;

namespace Problem1_Choose_a_Drink
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            string drink = "";
            double price = 0;
            switch (profession)
            {
                case "Athlete": drink = "Water"; price = 0.70; break;
                case "Businessman": drink = "Coffee"; price = 1.00; break;
                case "Businesswoman": drink = "Coffee";price = 1.00; break;
                case "SoftUni Student": drink = "Beer"; price = 1.70; break;

                default:
                    drink = "Tea"; price = 1.20;
                    break;
            }
            Console.WriteLine($"The {profession} has to pay {count*price:f2}.");
        }
    }
}
