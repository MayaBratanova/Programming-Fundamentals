using System;

namespace Problem4_Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double priceStudio = 0;
            double priceDouble = 0;
            double priceSuite = 0;
            double discount = 0;
            switch (month)
            {
                case "May": priceStudio =50 ; priceDouble = 65; priceSuite =75 ; break;
                case "October": priceStudio = 50; priceDouble = 65; priceSuite = 75; break;
                case "June": priceStudio = 60; priceDouble = 72; priceSuite = 82; break;
                case "September": priceStudio = 60; priceDouble = 72; priceSuite = 82; break;
                case "July": priceStudio = 68; priceDouble = 77; priceSuite = 89; break;
                case "August": priceStudio = 68; priceDouble = 77; priceSuite = 89; break;
                case "December": priceStudio = 68; priceDouble = 77; priceSuite = 89; break;
                default:
                    break;
            }
            if ((month == "May" || month == "October") && nights>7)
            {
                discount = 0.95;
                priceStudio = priceStudio *discount;
            }
           
            if ((month == "June" || month == "September") && nights > 14)
            {
                discount = 0.90;
                priceDouble = priceDouble *discount;
            }
           
            if ((month == "July" || month == "August" || month == "December") && nights > 14)
            {
                discount = 0.85;
                priceSuite = priceSuite * discount;
            }
           
            if ((month == "September" || month == "October") && nights > 7)
            {
                
                priceStudio = ((priceStudio * nights) - priceStudio)/nights;
            }
          
            Console.WriteLine($"Studio: {priceStudio*nights:f2} lv.");
            Console.WriteLine($"Double: {priceDouble*nights:f2} lv.");
            Console.WriteLine($"Suite: {priceSuite*nights:f2} lv.");

        }
    }
}
