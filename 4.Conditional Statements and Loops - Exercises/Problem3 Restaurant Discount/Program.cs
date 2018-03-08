using System;

namespace Problem3_Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            string hall = "";
            double price = 0;
            int pricePackage = 0;
            double discount = 0;
            if (people<=50)
            {
                hall = "Small Hall";
                price = 2500;
            }
            else if (people <= 100)
            {
                hall = "Terrace";
                price = 5000;
            }
            else if (people <= 120)
            {
                hall = "Great Hall";
                price = 7500;
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
                return;
            }
            if (package == "Normal")
            {
                discount = 0.95;
                pricePackage = 500;
            }
           else  if (package == "Gold")
            {
                discount = 0.90;
                pricePackage = 750;
            }
            else if (package == "Platinum")
            {
                discount = 0.85;
                pricePackage = 1000;
            }
            Console.WriteLine($"We can offer you the {hall}");
            price = ((price + pricePackage) * discount)/people;
            Console.WriteLine($"The price per person is {price:f2}$");
        }
    }
}
