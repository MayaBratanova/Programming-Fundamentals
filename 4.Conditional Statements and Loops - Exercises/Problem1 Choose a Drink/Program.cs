using System;

namespace Problem1_Choose_a_Drink
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            string drink = "";
            switch (profession)
            {
                case "Athlete": drink = "Water"; break;
                case "Businessman": drink = "Coffee"; break;
                case "Businesswoman": drink = "Coffee"; break;
                case "SoftUni Student": drink = "Beer"; break;

                default: drink = "Tea";
                    break;
            }
            Console.WriteLine(drink);
        }
    }
}
