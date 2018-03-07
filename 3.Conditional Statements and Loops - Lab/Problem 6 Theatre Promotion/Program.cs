using System;

namespace Problem_6_Theatre_Promotion
{
    class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            int price = 0;
            bool firstAge = age <= 18 && age >= 0;
            bool secondAge = age > 18 &&  age <= 64;
            bool thirtAge = age>64 && age <= 122;
            if (day == "Weekday")
            {
                if (firstAge)
                {
                    price = 12;
                }
                else if (secondAge)
                {
                    price = 18;
                }
                else if (thirtAge)
                {
                    price = 12;
                }
                else
                {
                    Console.WriteLine("Error!");
                }
            }
            else if (day == "Weekend")
            {
                if (firstAge)
                {
                    price = 15;
                }
                else if (secondAge)
                {
                    price = 20;
                }
                else if (thirtAge)
                {
                    price = 15;
                }
                else
                {
                    Console.WriteLine("Error!");
                }
            }
            else if (day == "Holiday")
            {
                if (firstAge)
                {
                    price = 5;
                }
                else if (secondAge)
                {
                    price = 12;
                }
                else if (thirtAge)
                {
                    price = 10;
                }
                else
                {
                    Console.WriteLine("Error!");
                   
                }
            }
            else 
            {
                Console.WriteLine("Error!");
                return;
            }
            if (firstAge || secondAge || thirtAge)
            {
                Console.WriteLine($"{price}$");
            }
          
        }
    }
}
